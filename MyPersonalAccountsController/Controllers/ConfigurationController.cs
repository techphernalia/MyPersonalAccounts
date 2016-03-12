using com.techphernalia.MyPersonalAccounts.Controller.DAL;
using com.techphernalia.MyPersonalAccounts.Model.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Controller.Controllers
{
    public class ConfigurationController
    {
        private static List<string> SystemNames = new List<string>() { "StockUnit", "StockGroup", "StockItem", "LedgerGroup" };
        static Dictionary<string, string> SystemIdConfiguration = null;
        static ConfigurationController()
        {
            var temp = SQLController.GetInstance().ExecuteProcedure("CongifurationGetAll",null).Tables[0].ToNameConfiguration();
            foreach(var t in temp)
            {
                SystemIdConfiguration.Add(t.SystemName.ToUpper(), t.Prefix + ("{0:" + new String('0', t.IDLength) + "}") + t.Suffix);
            }
            foreach(var t in SystemNames)
            {
                if (!SystemIdConfiguration.ContainsKey(t.ToUpper()))
                {
                    SystemIdConfiguration.Add(t.ToUpper(), "{0}");
                }
            }
        }

        public static ConfigurationController instance = new ConfigurationController();

        public string this[string key]
        {
            get
            {
                if (!SystemIdConfiguration.ContainsKey(key.ToUpper()))
                {
                    SystemIdConfiguration.Add(key.ToUpper(), "{0}");
                }
                return SystemIdConfiguration[key.ToUpper()];
            }
        }
    }
}
