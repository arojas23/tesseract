using System;
using System.Diagnostics;
using System.Drawing;
using Tesseract;

namespace TesseractOCR.Tests.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var testImagePath = "./phototest.tif";
            var img = new Bitmap(testImagePath);
            
            System.Console.WriteLine(img.Width);
            System.Console.WriteLine(img.Height);
            
            TesseractOCRFax tess = new TesseractOCRFax(img);
            Rectangle rect = new Rectangle(0, 0, 800, 800);
            
            //System.Console.WriteLine(tess.getText());
            System.Console.WriteLine(tess.getTextByRectangle(rect));


            //using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            //{
            //    using (var img = Pix.LoadFromFile("./faxsample.tif"))
            //    {
            //        using (var page = engine.Process(img))
            //        {
            //            var text = page.GetText();
            //            System.Console.WriteLine(text);
            //            using (var iter = page.GetIterator())
            //            {
            //                iter.Begin();
            //                do
            //                {

            //                } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
            //            }
            //        }
            //    }
            //}
            System.Console.ReadKey();
        }
    }

}
