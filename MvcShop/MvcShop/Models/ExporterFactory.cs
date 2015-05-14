using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop.Models
{
    public class ExporterFactory
    {
        public Exporter GenerateExporter(string TipExporter)
        {
            if (TipExporter.Equals("CSV"))
            {
                return new CsvExporter();
            }
            else if (TipExporter.Equals("JSON"))
            {
                return new JsonExporter();
            }
            else return null;
        }
    }
}