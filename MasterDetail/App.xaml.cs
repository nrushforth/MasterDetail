using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetail.Views;
using MasterDetail.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MasterDetail
{

    public static class ViewModelLocator
    {
        static ItemsViewModel itemsVM;
        public static ItemsViewModel ItemsViewModel
        => itemsVM ?? (itemsVM = new ItemsViewModel());
    }


    //{
    //    static MonkeysViewModel monkeysVM;
    //    public static MonkeysViewModel MonkeysViewModel
    //    => monkeysVM ?? (monkeysVM = new MonkeysViewModel());

    //    static DetailsViewModel detailsVM;
    //    public static DetailsViewModel DetailsViewModel
    //    => detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));

    //    BindingContext="{x:Static design:ViewModelLocator.MonkeysViewModel}"

    //}

    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
