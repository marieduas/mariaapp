namespace mariaapp;

public partial class MainPage : ContentPage
 
{
	int count = 0;
	Results results=new Results();
	
		public MainPage()
		{
			InitializeComponent();
			TestaLayout();
			PreencherTela();
		}
		void PreencherTela()
		{
			labelTemperatura.Text=results.temp.ToString();
			labelChuva.Text=results.RetainCount.ToString();
			labelUmidade.Text=results.humidity.ToString(); 
			labelAmanhecer.Text=results.sunrise;
			LabelAnoitecer.Text=results.sunset;
			LabelForça.Text=results.wind_speedy;
			LabelDireção.Text=results.wind_direction.ToString();
			LabelFasedaLua.Text=results.moon_plase;
			LabelDescrição.Text=results.description;
			LabelCidade.Text=results.city;

			if (results.currently=="dia")
	    {
				if (Results.rain>=2)
				ImagemDeFundo.Sourse="diachuvoso.jpg";
				else if (Results.cloudiness>=1)
				ImagemDeFundo.Sourse="dianublado.jpg";
				else
				ImagemDeFundo.Sourse="diaensolarado.jpg";
		}
		else
		{
			if (results.Rain>=5)
			ImagemDeFundo.Sourse="noitechuvosa.jpg";
			else if (results.cloudiness>=7)
			ImagemDeFundo.Sourse="noitenublada.jpg";
			else
			ImagemDeFundo.Sourse="noitelimpa.jpg";
		}
}
	void TestalLayout()
	{
		results.tenp=25;
		results.Description="Tempo Nublado";
		results.condition_code="28";
		results.img_id="28";
		results.city="Apucarana,PR";
		results.RainCount=5;
		results.cloudiness=2;
		results.humidity=90;
		results.sunrise="06:15";
		results.sunset="18:25";
		results.whind_speedy="4.99 km/h";
		results.wihnd_direction=40;
		results.moon_plase="Crescente";
		results.currenty="noite";
	}
	}

	

	

