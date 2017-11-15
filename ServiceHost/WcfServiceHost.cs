namespace WcfServiceHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using System.ServiceModel;
    using BusinessServiceContracts;


    public partial class WcfServiceHost : Form
    {
        public List<string> HostedServiceNames = new List<string>();
        public List<ServiceHost> HostedServices = new List<ServiceHost>();
        public int RunningServices, FaultedServices;
        public WcfServiceHost()
        {
            WindowState = FormWindowState.Minimized;
            InitializeComponent();
            serviceNotifier.Visible = true;
            StartServices();
            ConfigureNotifier();
            ShowInTaskbar = false;
            DataGridViewLinkColumn col = new DataGridViewLinkColumn { ReadOnly = true, DataPropertyName = "Url", Name = "Url", Width = 300 };
            dgServiceInfo.Columns.Add(col);
            foreach (var service in HostedServices)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgServiceInfo);
                row.Cells[0].Value = service.Description.Name;
                row.Cells[1].Value = service.State.ToString();
                if (service.State == CommunicationState.Opened)
                {
                    row.Cells[2].Value = service.Description.Endpoints.FirstOrDefault()?.Address;
                }
                dgServiceInfo.Rows.Add(row);
            }
            Hide();
        }
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        private void ConfigureNotifier()
        {
            var iconPath = Application.StartupPath + "..\\..\\..\\Test.ico";
            serviceNotifier.Icon = new System.Drawing.Icon(iconPath);
            serviceNotifier.BalloonTipTitle ="";
            //var parameters = new List<string> { RunningServices.ToString(), FaultedServices.ToString(), "\n" };
            serviceNotifier.BalloonTipText = $"{RunningServices} Services Running\n{FaultedServices} Services Failed\nClick for more Details...";
            serviceNotifier.ShowBalloonTip(300);
            serviceNotifier.BalloonTipIcon = ToolTipIcon.Info;
            serviceNotifier.BalloonTipClicked += notifyIcon_BalloonTipClicked;
            serviceNotifier.Text = "";
        }
        private void StartServices()
        {
            var serviceAssembly = Assembly.Load(nameof(BusinessService));
            if (serviceAssembly != null)
            {
                var services = serviceAssembly.GetTypes().Where(x=>typeof(IUserService).IsAssignableFrom(x)).ToList();
                foreach (var service in services)
                {
                    StartService(service);
                }
            }
        }
        public void StartService(Type service)
        {

            try
            {
                HostedServiceNames.Add(service.Name);
                var serviceHost = new ServiceHost(service);
                HostedServices.Add(serviceHost);
                serviceHost.Open();
                RunningServices++;
            }
            catch (Exception ex)
            {
                FaultedServices++;
            }
        }

        private void WcfServiceHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serviceNotifier.Visible = false;
                serviceNotifier.Icon = null;
                serviceNotifier.Dispose();
                foreach (var service in HostedServices)
                {
                    service.Close();
                }
            }
            finally
            {
                Dispose();
            }
        }

        private void serviceNotifier_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
