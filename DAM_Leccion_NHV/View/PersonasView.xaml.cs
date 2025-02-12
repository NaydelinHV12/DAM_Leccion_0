using DAM_Leccion_NHV.ViewModel;

namespace DAM_Leccion_NHV.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();
	}
}