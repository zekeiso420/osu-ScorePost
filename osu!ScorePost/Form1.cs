using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;


namespace osu_ScorePost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openfile.FileName);
                var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndLstm);
                Page page = ocr.Process(img);
                txtOutput.Text = page.GetText();
            }
        }
    }
}
