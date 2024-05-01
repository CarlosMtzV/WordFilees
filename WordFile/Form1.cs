using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Windows.Forms;

namespace WordFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Documentos de Word (*.docx)|*.docx";
            saveFileDialog1.Title = "Guardar documento de Word";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                string textBoxContent = txtFile.Text;

                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    Body body = new Body();

                    Paragraph paragraph = new Paragraph();
                    Run run = new Run();
                    Text text = new Text(textBoxContent);
                    run.Append(text);
                    paragraph.Append(run);
                    body.Append(paragraph);

                    mainPart.Document = new Document(body);

                    mainPart.Document.Save();
                }

                MessageBox.Show("¡FileWord created!");
            }
        }
    }
}
