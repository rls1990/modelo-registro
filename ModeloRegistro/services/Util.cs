using HtmlAgilityPack;
using System;
using System.IO;
using System.Linq;

namespace ModeloRegistro.services
{
    class Util
    {
        public static string BaseDirectoryReport()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName +@"\reports\templates";
            return projectDirectory;
        }

        public static HtmlDocument LoadHtmlReport( string reportFileName )
        {
            string reportDirectory = BaseDirectoryReport();
            string reportFilePath = Path.Combine(reportDirectory,reportFileName);

            if(!File.Exists(reportFilePath))
            {
                throw new FileNotFoundException($"El archivo {reportFilePath} no existe.");
            }

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.Load(reportFilePath);
            return htmlDocument;
        }

        public static void LlenarSpans<T>( HtmlDocument htmlDocument,T entidad )
        {
            var properties = typeof(T).GetProperties();

            // Seleccionar todos los elementos <span>
            var spans = htmlDocument.DocumentNode.SelectNodes("//span");

            if(spans!=null)
            {
                foreach(var span in spans)
                {
                    string id = span.GetAttributeValue("id",string.Empty);

                    // Buscar la propiedad correspondiente en la entidad
                    var property = properties.FirstOrDefault(p => p.Name.Equals(id,StringComparison.OrdinalIgnoreCase));
                    if(property!=null)
                    {
                        string value = property.GetValue(entidad)?.ToString()??string.Empty;
                        span.InnerHtml=value;
                    }
                }
            } else
            {
                Console.WriteLine("No se encontraron elementos <span> en el documento.");
            }
        }

        public static void SaveHtmlReport( HtmlDocument htmlDocument,string outputFileName )
        {
            string reportDirectory = BaseDirectoryReport();
            string outputFilePath = Path.Combine(reportDirectory,outputFileName);

            htmlDocument.Save(outputFilePath);
            Console.WriteLine($"Archivo HTML guardado en: {outputFilePath}");
        }
    }
}
