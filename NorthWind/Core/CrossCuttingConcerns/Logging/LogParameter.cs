﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public object Type { get; set; }
    }
}
