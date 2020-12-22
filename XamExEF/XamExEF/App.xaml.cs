using Xamarin.Forms;
using XamExEF.Data;
using XamExEF.Services;

namespace XamExEF
{
    public partial class App : Application
    {
        public static string DbPath { get; } = "";

        public App()
        {
            InitializeComponent();

            CreateDb();

            DependencyService.Register<MockDataStore>();

            MainPage = new AppShell();
        }

        private void CreateDb()
        {
            // Cria o banco de dados e as tabelas
            using var db = new XamExEFContext();
            // Verifica se o banco de dados foi criado
            db.Database.EnsureCreated();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}