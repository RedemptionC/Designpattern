using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    class AppConfig
    {
        private string ParameterA;
        public string getParameterA() { return ParameterA; }
        public void setParameterA(string pa) { this.ParameterA = pa; }
        private static AppConfig appconfig = null;
        private AppConfig() { }
        public static AppConfig GetAppconfig()
        {
            if (appconfig == null)
            {
                appconfig = new AppConfig();
            }
            return appconfig;
        }

    }
}
