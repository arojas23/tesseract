using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tesseract;

namespace TesseractOCR.Tests.Console
{
    class TesseractOCRFax
    {
        private Tesseract.TesseractEngine engine = null;
        private Bitmap faxImage = null;


        public TesseractOCRFax(Bitmap image)
        {
            faxImage = image;
            engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
        }

        public string getText(Bitmap image)
        {
            string res = "";
            using (var page = engine.Process(image))
            {
                res = page.GetText();
            }
            return res;
        }

        //Return the fax text of the entire fax
        public string getText()
        {
            return getText(faxImage);
        }

        public string getTextByRectangle(Rectangle rectangle)
        {
            Bitmap bmpCrop = faxImage.Clone(rectangle, faxImage.PixelFormat);
            return getText(bmpCrop);
        }
    }
}
