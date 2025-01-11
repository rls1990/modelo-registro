using ModeloRegistro.views.loading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ModeloRegistro.services
{
    class PageService
    {
        public static async Task LoadPage( Page getPageFunction,Frame frame,int duration = 500 )
        {
            // Mostrar la página de carga
            frame.Content=new Loading();

            // Simular una carga larga (reemplace el código siguiente con su lógica real)
            await Task.Delay(duration);

            // Cargar la página real en segundo plano
            var newPage = await Task.Run(() => getPageFunction);

            // Mostrar la página real en el Frame
            frame.Content=newPage;
        }

        public static async void toPage( Page page )
        {
            var navService = Global.frame_dashboard.NavigationService;
            while(navService.CanGoBack)
            {
                navService.RemoveBackEntry();
            }

            await LoadPage(page,Global.frame_dashboard,500);
        }

        public static async void toPage( Page page , Frame frame )
        {
            var navService = Global.frame_dashboard.NavigationService;
            while(navService.CanGoBack)
            {
                navService.RemoveBackEntry();
            }

            await LoadPage(page,frame,500);
        }
    }
}
