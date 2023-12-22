using Moldovan_Luminita_Lab11_2.Data;
using System.Security.Cryptography.X509Certificates;

namespace Moldovan_Luminita_Lab11_2
{
    public partial class App : Application
    {
        public static ShoppingListDatabase database { get; private set; }

        public App()
        {
            database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

        }
    }
}