using DAM_Leccion_NHV.View;

namespace DAM_Leccion_NHV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new PersonasView();
        }

        
    }
}