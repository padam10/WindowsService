using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceDemo
{
    using System.IO;

    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            File.Create(AppDomain.CurrentDomain.BaseDirectory + "Start.txt");
        }

        protected override void OnStop()
        {
            File.Create(AppDomain.CurrentDomain.BaseDirectory + "Stop.txt");
        }
    }
}
