﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stratis.Guru.Settings
{
    public class SetupSettings
    {
        public SetupSettings()
        {
            Title = "Stratis.Guru";
            Chain = "Stratis";
        }

        public string Title { get; set; }

        public string Chain { get; set; }

        public string Footer { get; set; }
    }
}
