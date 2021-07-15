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

            _container.Register<IBusinessLogic, ViewServices>();
            _container.Register<IDataAccess, DataWorker>();

            _container.Verify();
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
            Application.Run(new StartupForm());
        }
    }
}
