using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FluentFTP;

namespace SelettoreFile
{   
    public partial class Upload : Form
    {   
        public List<string> fileToUpload = new List<string>();
        public Upload()
        {
            InitializeComponent();
            tb_pw.UseSystemPasswordChar = true;
        }

        private void cb_showpw_CheckedChanged(object sender, EventArgs e)
        {
            tb_pw.UseSystemPasswordChar = !tb_pw.UseSystemPasswordChar;
        }

        private void btn_showDialog_Click(object sender, EventArgs e)
        {        

            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "doc files (*.doc)|*.doc|docx files (*.docx)|*.docx|pdf files (*.pdf)|*.pdf|xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx";
                fileDialog.Title = "Select Files";
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = true;
                
                if (fileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.SafeFileName))
                {
                    lb_fileList.Items.AddRange(fileDialog.SafeFileNames);
                    fileToUpload.AddRange(fileDialog.FileNames);
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (tb_server.TextLength > 0 && tb_user.TextLength > 0 && fileToUpload.Count > 0)
            {
                FtpClient conn = new FtpClient(tb_server.Text, tb_user.Text, tb_pw.Text);
               
                try
                {
                    conn.ConnectTimeout = 600000;
                    conn.ReadTimeout = 60000;
                    conn.Connect();

                    List<string> invoices = new List<string>();
                    List<string> documents = new List<string>();

                    //Division of files in two lists that allow the correct creation of the report

                    foreach (string selectedFile in fileToUpload)
                    {
                        string nameOfFile = Path.GetFileName(selectedFile);
                        string folder = nameOfFile.StartsWith("FT") ? "INVOICES" : "DOCUMENTS";

                        conn.UploadFile(selectedFile, $@"{folder}\{nameOfFile}", FtpRemoteExists.Skip, true);

                        if(folder == "INVOICES")
                        {
                            invoices.Add(nameOfFile);
                        }
                        else
                        {
                            documents.Add(nameOfFile);
                        }
                    }

                    string fileName = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report_{DateTime.Now:yyyy-MM-dd}.txt";

                    //Creation of report file
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    using(StreamWriter stream = File.CreateText(fileName))
                    {
                        write_section(stream, "INVOICES\n", invoices);
                        write_section(stream, "\nDOCUMENTS\n", documents);
                    }

                    MessageBox.Show($"Upload of {fileToUpload.Count} files completed!");
                }
                catch (FtpException ftpex)
                {
                    MessageBox.Show(ftpex.Message);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conn.Disconnect();
                }
            } else
            {
                MessageBox.Show("Please fill all the required fields.");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lb_fileList.SelectedIndex != -1)
            {
                fileToUpload.RemoveAt(lb_fileList.SelectedIndex);
                lb_fileList.Items.RemoveAt(lb_fileList.SelectedIndex);
            } else
            {
                MessageBox.Show("No element was selected.");
            }
        }

        public void write_section(StreamWriter stream, string title, List<string> list)
        {
            stream.WriteLine(title);
            if (list.Count > 0)
            {
                foreach (string file in list)
                {
                    stream.WriteLine(file);
                }
            }
        }
    }
}
