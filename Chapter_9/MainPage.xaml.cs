using Chapter_9.Model.Data;
using Chapter_9.View;

namespace Chapter_9;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void list_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ListViewPage());
    }
}

