using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;

namespace TIFFtoPDF
{
    public partial class Form1 : Form
    {
        List<String> filenames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddTiff2Pdf(string tiffFileName, ref PdfWriter writer, ref Document document)
        {

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(tiffFileName);

            int numberOfPages = bitmap.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);

            PdfContentByte cb = writer.DirectContent;

            for (int page = 0; page < numberOfPages; page++)
            {

                bitmap.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, page);

                System.IO.MemoryStream stream = new System.IO.MemoryStream();

                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(stream.ToArray());

                stream.Close();

                img.ScalePercent(72f / bitmap.HorizontalResolution * 100);

                img.SetAbsolutePosition(0, 0);

                cb.AddImage(img);

                document.NewPage();
            }
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            listBox1.Items.Clear();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select TIF files";
            theDialog.Filter = "TIF files|*.tif";          

            // Opening multiple files
            theDialog.Multiselect = true;
            
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (String file in theDialog.FileNames)
                    {
                        listBox1.Items.Add(file);
                        filenames.Add(file);
                    }

                    convert_button.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF file|*.pdf";
            sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss_tt");           

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4, 50, 50, 50, 50);

                PdfWriter writer = PdfWriter.GetInstance(document,
                                                         new FileStream(sfd.FileName,
                                                         FileMode.CreateNew));
                document.Open();

                foreach (String file in filenames)
                {
                    AddTiff2Pdf(file, ref writer, ref document);
                }

                document.Close();

                listBox1.Items.Clear();
                filenames.Clear();
                listBox1.Items.Add("Done.");
                convert_button.Visible = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            listBox1.Items.Clear();
            filenames.Clear();
            convert_button.Visible = false;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            try
            {
                // Get the currently selected item in the ListBox. 
                string curItem = listBox1.SelectedItem.ToString();

                listBox1.Items.Remove(curItem);
                filenames.Remove(curItem);
            }
            catch (NullReferenceException)
            {
                label.Text = "To remove item, you must first select it from the list.";
            }

            if (filenames.Count == 0)
                convert_button.Visible = false;
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            try
            {
                // Get the currently selected item in the ListBox. 
                string curItem = listBox1.SelectedItem.ToString();
                
                int curItemIndex = listBox1.Items.IndexOf(curItem);

                if (curItemIndex != 0)
                {
                    string temp = listBox1.Items[curItemIndex - 1].ToString();
                    listBox1.Items[curItemIndex - 1] = curItem;
                    listBox1.Items[curItemIndex] = temp;
                    listBox1.SelectedItems.Clear();
                    listBox1.SetSelected(curItemIndex - 1, true);

                    filenames[curItemIndex] = temp;
                    filenames[curItemIndex - 1] = curItem;                    
                }
            }
            catch (NullReferenceException)
            {
                label.Text = "To move item, you must first select it from the list.";
            }
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            label.Text = "";
            try
            {
                // Get the currently selected item in the ListBox. 
                string curItem = listBox1.SelectedItem.ToString();

                int curItemIndex = listBox1.Items.IndexOf(curItem);

                if (curItemIndex != filenames.Count - 1)
                {
                    string temp = listBox1.Items[curItemIndex + 1].ToString();
                    listBox1.Items[curItemIndex + 1] = curItem;
                    listBox1.Items[curItemIndex] = temp;
                    listBox1.SelectedItems.Clear();
                    listBox1.SetSelected(curItemIndex + 1, true);

                    filenames[curItemIndex] = temp;
                    filenames[curItemIndex + 1] = curItem;
                }
            }
            catch (NullReferenceException)
            {
                label.Text = "To move item, you must first select it from the list.";
            }
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            label.Text = "";

            if (filenames.Count() != 0)
            {
                filenames.Sort();
                listBox1.Items.Clear();

                foreach (String file in filenames)
                    listBox1.Items.Add(file);
            }
            else label.Text = "You must first insert items to the list.";
        }
    }
}
