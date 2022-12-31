using Chapter_9.Model.Data;
using Chapter_9.ModelView.DepandencyInjectionClasses;
using Chapter_9.ModelView.DependencyInjectionExtention;
using Chapter_9.ModelView.Interfaces;
using Chapter_9.ModelView.ModelViewData;

using System.Collections;

namespace Chapter_9.View;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
		lsv.ItemsSource = new ModelViewProducts().GetproductsData();
		usersListView.ItemsSource = new UsersDependencyInjection(new ModelViewUsers()).GetUsersListByDI();

		departmentListView.ItemsSource = DependencyInjectionExtention.ServiceProvider.GetService<ListPage>().lstDepartment;
		//departmentListView.ItemsSource = DependencyInjectionExtention.ServiceProvider.GetService() ;
		//Test_DI.Text = DependencyInjectionExtention.ServiceProvider.GetService<MainPageModel>().strMP;
		Test_DI.BindingContext = DependencyInjectionExtention.ServiceProvider.GetService<MainPageModel>();
		//this.BindingContext = listDepartment;
    }

    private void lsv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var item = e.Item as ProductsData;
		DisplayAlert("Item selected", item.Name + " ==> " + item.Number, "Cancel" );
		((ListView)sender).SelectedItem = null;
    }
}