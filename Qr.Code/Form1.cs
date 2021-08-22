using System;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Drawing;

namespace Qr.Code
{
    public partial class Form1 : Form
    {

        System.Drawing.Image img;


        public Form1()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            


            if (TxtQr.Text == string.Empty)
             {

                MessageBox.Show("Preencha o Campo Vazio!");

                return;
            }
            else
            {
                QRCoder.QRCodeGenerator Qg = new QRCoder.QRCodeGenerator();
                var Mydata = Qg.CreateQrCode(TxtQr.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(Mydata);
                pictureB.Image = code.GetGraphic(50);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            TxtQr.Text = "";
            pictureB.Image = null;
        }
       

   

        private void pictureB_Click(object sender, EventArgs e)
        {

        }

       
        private void pictureB_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
                {

                img = System.Drawing.Image.FromFile(pic);
                pictureB.Image = img;

            }



        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (pictureB.Image != null)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "JPG(*.JPG)|*.jpg";

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    this.pictureB.Image.Save(sf.FileName);


                }
            }
            else
            {
                MessageBox.Show("erro");
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
