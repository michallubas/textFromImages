using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace TextFromImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Bitmap image = new Bitmap("demo picture.jpg");

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {

            //var ocr = new IronTesseract().Read(image);
            var Ocr = new IronTesseract();
            //test for polish...
            Ocr.Language = OcrLanguage.Polish;

            using (var input = new OcrInput())
            {
                input.AddImage(image);
                // IronTesseract can read bad quality of image, Tesseract cannot.
                var Result = Ocr.Read(input);
                // option to save on disk
                //Result.SaveAsTextFile("test.txt");
                resultBox.Text = Result.Text;
            }
            //resultBox.Text = ocr.Text;


        }

        //testinng converting many images from a specific folder
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Directory.SetCurrentDirectory(@"C:\Users\user\Desktop\zdjecia");
            string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory());

            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.English;

            foreach (var file in fileEntries)
            {

                    using (var input = new OcrInput())
                {
                    image = new Bitmap(file);
                    input.AddImage(image);
                    
                    var Result = Ocr.Read(input);
                    
                    resultBox.Text += Result.Text;
                    resultBox.Text += Environment.NewLine;
                    resultBox.Text += "---------";
                }
                    //resultBox.Text += file;
            }

            
        }
    }
}
