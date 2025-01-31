using DAM_Leccion_NHV.Model;

namespace DAM_Leccion_NHV
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
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

        public void Ejecutar()
        {
            PersonaModel personaModel = new PersonaModel()
            {
                Nombre = "Hola, Aquí estoy!",
            };

            BindingContext = personaModel.Nombre;

            Binding personaBinding = new Binding();
            personaBinding.Source = personaModel;
            personaBinding.Path = "Nombre";
            txtNombre.SetBinding(Entry.TextProperty, personaBinding);


            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Hola aqui estoy";
            //txtNombre.Text = "Hola aqui estoy";
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
        }

    }

}
