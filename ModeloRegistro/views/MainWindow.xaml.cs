using ModeloRegistro.services;
using System;
using System.IO;
using System.Windows;

namespace ModeloRegistro.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Global.frame=frame;
            Global.sqlite=new model.SQLite("data.db");
            LoadInit();

            //var html = Util.LoadHtmlReport("anexo_3.certificacion_de_nacimiento_1 (1).html");

            //string outputFileName = @"D:\PROGRAMACION\Enmanuel\report\output\reporte_llenado.html";

            //reports.entidades.Anexo3 anexo = new reports.entidades.Anexo3()
            //{
            //    ciudad="La Habana",
            //    pais="Cuba",
            //    nombre_apellido="Juan Pérez",
            //    dia="15",
            //    mes="Octubre",
            //    anno="2023",
            //    municipio="Playa",
            //    provincia="La Habana",
            //    registro="12345",
            //    municipio_registro="Playa",
            //    provincia_registro="La Habana",
            //    tomo="1",
            //    folio="100",
            //    dia_asiento="15",
            //    mes_asiento="Octubre",
            //    anno_asiento="2023",
            //    nombre_padre="Pedro Pérez",
            //    nombre_madre="María López",
            //    legalizacion_minred="Sí",
            //    legalizacion_embajada="Sí",
            //    fecha_solicitud="15/10/2023"
            //};

            //Util.LlenarSpans(html,anexo);

            //Util.SaveHtmlReport(html,outputFileName);

        }

        public async void LoadInit()
        {
            await PageService.LoadPage(new dashboard.Dashboard(),frame,1500);
        }
    }
}
