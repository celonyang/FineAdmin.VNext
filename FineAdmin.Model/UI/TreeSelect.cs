﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FineAdmin.Model
{
    public class TreeSelect
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool open { get; set; }
        public IEnumerable<TreeSelect> children { get; set; }
    }
}
