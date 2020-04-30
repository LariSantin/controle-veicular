using ControleVeicular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ControleVeicular.Repository
{
    public interface IPDFRepository
    {
        void gerarPDF();
    }

    public class PDFRepository : IPDFRepository
    {
        public PDFRepository() 
        {
        }

        public void gerarPDF()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string caminho = @"C:\Users\" + "CONTRATO.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            doc.Open();
            string dados = "";    
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));  
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("TESTE TESTE TESTE");
            doc.Add(paragrafo);
            doc.Close();
        }

      

    }
}
