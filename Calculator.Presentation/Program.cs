using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using Calculator.BusinessLogic;
using Calculator.DataAccess;

namespace Calculator.Presentation
{
    static class Program
    {
        static readonly Container _container; 

        static Program()
        {
            _container = new Container();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Registration();
            Application.Run(_container.GetInstance<StartupForm>());
        }

        static void Registration()
        {
            _container.Register<IViewServices, ViewServices>(Lifestyle.Singleton);
            _container.Register<ICalculatorServices, CalculatorServices>(Lifestyle.Singleton);
            _container.Register<IDataService, DataService>(Lifestyle.Singleton);
            _container.Register<StartupForm>(Lifestyle.Singleton);

            _container.Verify();
        }
    }
}
