using DAM_Leccion_NHV.Model;
using DAM_Leccion_NHV.ViewModel;

namespace DAM_Leccion_NHV
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public PersonasModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        //Evento Guardar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //splayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
            //personaModel.Nombre = "Naydelin";
            //personaModel.Apellido = "Hernández";
            //personaModel.Edad = "21";

        }
    }

}
