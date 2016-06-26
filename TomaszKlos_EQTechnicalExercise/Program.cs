using Common.Interfaces;
using Common.Repositories;
using Microsoft.Practices.Unity;
using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszKlos_EQTechnicalExercise.Presenters;

namespace TomaszKlos_EQTechnicalExercise
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = container.Resolve<MainForm>();

                  
            Application.Run(mainForm);
        }

        public static IUnityContainer BuildContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<MainForm>(
            new InjectionConstructor(
            new ResolvedParameter<FundRepository>("fundRepository")));

            container.RegisterType<IPresenter, FundPresenter>();

            container.RegisterType<IFundRepository, FundRepository>();


            return container;
        }

    }
}
