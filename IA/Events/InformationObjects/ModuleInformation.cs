﻿using System.Collections.Generic;

namespace IA.Events
{
    public class ModuleInformation
    {
        public string name;
        public bool enabled;

        List<CommandEvent> events = new List<CommandEvent>();
    }
}