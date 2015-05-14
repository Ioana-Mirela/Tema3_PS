using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MvcShop.Models
{
    public class CsvExporter: Exporter
    {
        public void export(List<Product> productList)
        {
            string path ="E:\\CsvExporter.csv";
           
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("\"Product Id\",\"Product Name\",\"Product Price\"");
                }
            }

            
            foreach (var line in productList)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\"",
                                           line.Id,
                                           line.Name,
                                           line.Price));
                }
                
            } 
        }
    }
}


  
           
