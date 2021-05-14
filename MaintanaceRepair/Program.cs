using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintanaceRepair.Forms;
using StructureMap;

namespace MaintanaceRepair
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Contains("encrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                config.Save();
                return;
            }
            if (args != null && args.Contains("decrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.UnprotectSection();
                }
                config.Save();
                return;
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa-IR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainContainer = new Container(new TypeRegistery());
            var frmLogin = mainContainer.GetInstance<LoginForm>();
            Application.Run(frmLogin);
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                var frmMain = mainContainer.GetInstance<MainForm>();
                frmMain.ShowDialog();
            }
            //else if (frmLogin.DialogResult == DialogResult.Retry)
            //{
            //    var frmSetting = mainContainer.GetInstance<FrmUser>();
            //    frmSetting.ShowDialog();
            //}
            else
                Environment.Exit(0);

        }
    }
}
