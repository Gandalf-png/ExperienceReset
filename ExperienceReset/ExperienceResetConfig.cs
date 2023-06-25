using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExperienceReset
{
    public class ExperienceResetConfig : IRocketPluginConfiguration
    {
        public int DefaultEXP { get; set; }
        public int MaxEXP { get; set; }
        public void LoadDefaults()
        {
            MaxEXP = 200000;
            DefaultEXP = 500;
        }
    }
}