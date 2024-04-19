using UIKit;

namespace mariaapp;


public partial class MainPage : ContentPage
	{
		Results resultado;
		public MainPage()
		{
			InitializeComponent();
			TestalLayout();
			PreencherPagina();
		}
		void TestalLayout();
		{
			resultado = new Results();
			resultado.temp = 23;
			resultado.description = "Tempo nublado";
		}
		void PreencherPagina()
		{
			labelTemp.Text = resultado.temp.ToString();

			labeldescription.Text = resultado.description();

			labelcity.Text = resultado.temp.ToString(); 
		}

	}

	

	

