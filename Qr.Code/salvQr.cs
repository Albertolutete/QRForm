using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr.Code
{
    public static class salvQr
    {
        public static void Save (Image imgQrcode, string Format)
        {
            SaveFileDialog SfDialog = new SaveFileDialog();


           
            SfDialog.Filter = "PNG image|*.png";
              
            SfDialog.FileName = "Qr.Code";
            SfDialog.Title = "Save Qr.Code";
            SfDialog.InitialDirectory = @"C:\Users\pc\Documents\Qr";

            SfDialog.ShowDialog();

            if (!SfDialog.FileName.Equals(string.Empty))
            {
                FileStream fs = (FileStream)SfDialog.OpenFile();
                if (Format.Equals("png"))
                {
                    imgQrcode.Save(fs, ImageFormat.Png);
                }
                
                
                
                 
               
                fs.Close();
            }

            





        }
       
    }
}
