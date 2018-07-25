using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;

namespace Aikido.BLO
{
    public  class ExportWord
    {
        public void CreateDocument()
        {
            //section.PageSetup.PageSize = PageSize.A4;
            //042
            //section.PageSetup.Margins.Top = 72f;
            //043
            //section.PageSetup.Margins.Bottom = 72f;
            //044
            //section.PageSetup.Margins.Left = 89.85f;
            //045
            //section.PageSetup.Margins.Right = 89.85f;

            //Create New Word
            Document doc = new Document();
            //Add Section
            Spire.Doc.Section section = doc.AddSection();


           //Add Paragraph
            Paragraph pHeader = section.AddParagraph();
            //Header
            TextRange textRangel = pHeader.AppendText("HỒ SƠ HỌC VIÊN");
            textRangel.CharacterFormat.Bold = true;
            textRangel.CharacterFormat.TextColor = System.Drawing.Color.Blue;
            textRangel.CharacterFormat.FontSize = 24;
            textRangel.CharacterFormat.FontName = "Calibri Light (Headings)";
            pHeader.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            pHeader.Format.AfterSpacing =15;
            //SKU
            draw(doc, 210, 22, 20, 10, "SKU : Ma SKU");
            //Register Number
            draw(doc, 210, 22, 260, -5, "SỐ ĐĂNG KÝ : 00000");
            //Name
            draw(doc, 450, 22, 20, 15, "HỌ TÊN : HUỲNH KIẾN KINH");
            //Quốc Tịch
            draw(doc, 450, 22, 20, 35, "QUỐC TỊCH : VIỆT NAM");
            //Address
            draw(doc, 450, 22, 20, 55, "ĐỊA CHỈ : 1287/15 Đường 3/2 P16 Q11 TPHCM");
            //PHONE
            draw(doc, 450, 22, 20, 75, "SỐ ĐIỆN THOẠI : 01285939674");
            //Image
            imageDraw(doc,140,120,15,95);
            //Register Day
            draw(doc, 314, 22, 155, 86,"NGÀY ĐĂNG KÝ : 24/7/2018");
            // Day of Birth
            draw(doc, 314, 22, 155, 107, "NGÀY SINH : 24/7/2018");
            //Place of Birth
            draw(doc, 314, 22, 155, 131, "NGÀY ĐĂNG KÝ: 24/7/2018");
            //Class 
            draw(doc, 314, 22, 155, 151, "LỚP: AIKIDO 001");
            ////Register Number
            //TextRange RegisterNumberxt = doc.Sections[0].AddParagraph().AppendText("Số Đăng Ký: ");
            //TextBox Registertxtbox = doc.Sections[0].AddParagraph().AppendTextBox(180, 20);
            //SKUtxtbox.Format.HorizontalPosition = 30f;
            //SKUtxtbox.Format.VerticalPosition = -18f;
            //SKUtxtbox.Format.LineColor = System.Drawing.Color.DarkBlue;
            //SKUtxtbox.Format.LineStyle = TextBoxLineStyle.Simple;
            ////Paragraph paraSKU = SKUtxtbox.Body.AddParagraph();
            ////TextRange trSKU = paraSKU.AppendText("Textbox in Word Document");
            ////trSKU.CharacterFormat.FontName = "Century Gothic";
            //trSKU.CharacterFormat.FontSize = 12;
            // trSKU.CharacterFormat.TextColor = Color.White;


            //Save and launch
            doc.SaveToFile("MyWord.docx", FileFormat.Docx);
            System.Diagnostics.Process.Start("MyWord.docx");
        }
        public void draw(Document doc,int d, int r, int Hposition,int Vposition,String content)
        {
            TextBox txtbox = doc.Sections[0].AddParagraph().AppendTextBox(d, r);
            txtbox.Format.HorizontalPosition = Hposition;
            txtbox.Format.VerticalPosition = Vposition;
            txtbox.Format.LineColor = System.Drawing.Color.DarkBlue;
            txtbox.Format.LineStyle = TextBoxLineStyle.Simple;
            Paragraph p = txtbox.Body.AddParagraph();
            p.AppendText(content);
        }
        public void imageDraw(Document doc, int d, int r, int Hposition, int Vposition)
        {
            TextBox txtbox = doc.Sections[0].AddParagraph().AppendTextBox(r+20, d+10);
            txtbox.Format.HorizontalPosition = Hposition;
            txtbox.Format.VerticalPosition = Vposition;
            txtbox.Format.LineColor = System.Drawing.Color.White;
            txtbox.Format.LineStyle = TextBoxLineStyle.Simple;
            Paragraph p = txtbox.Body.AddParagraph();
            DocPicture picture = p.AppendPicture(Image.FromFile(@"M:\Untitled.png"));
            picture.Width = r;
            picture.Height = d;
            
        }
    }
}
