using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace ServiceTemplate
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        public void ToStart()
        {
        }

        public void ToStop()
        {
        }

        protected override void OnStart(string[] args)
        {
            ToStart();
        }

        protected override void OnStop()
        {
            ToStop();
        }
    }
}
