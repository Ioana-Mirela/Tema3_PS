using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MvcShop.Models
{
    public class JsonExporter: Exporter
    {
        public void export(List<Product> productList)
        {
            string ans = JsonConvert.SerializeObject(productList, Formatting.Indented);

            string script = "var productsList = {\"Products\": " + ans + "};";
            script += "for(i = 0;i<productsList.Products.length;i++)";
            script += "{";
            script += "alert ('Name : ='+productsList.Products[i].Name+'Price : = '+productsList.Products[i].Price);";
            script += "}";

            string path ="E:\\JsonExporter.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(script);
                }
            }
            

            

            
          
        }
    }
}



 

         