﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Verse;

namespace static_quality
{
    public class Settings
    {
        //public static bool skill_degrading = false;
        public bool learning_saturation_tweak = true;
        public int skill_switch = 1;

        public bool passion_tweak = false;
        public bool passion_gain = false;
        public bool passion_cap = false;
        public bool no_delevel = false;
        public bool plant_rest = true;
        public int quality_switch = 0;
        public string config_file = Path.Combine(Path.GetDirectoryName(GenFilePaths.SaveDataFolderPath), "sqp_config.xml");
        //public string config_file = Path.Combine(Path.Combine(Path.GetDirectoryName(GenFilePaths.SaveDataFolderPath), "Config"), "SQP.xml");

    }
}
