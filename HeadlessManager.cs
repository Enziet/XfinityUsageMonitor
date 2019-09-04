using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XfinityUsageMonitor
{
    class HeadlessManager
    {
        ChromeDriver _driver;
        ChromeOptions _options;

        private bool _status = false;
        public bool Status { get => _status; set => _status = value; }

        HeadlessManager()
        {
            _options = new ChromeOptions();
            _options.AddArgument("--headless");
            _driver = new ChromeDriver(_options);
            _status = true;
        }

        
    }
}
