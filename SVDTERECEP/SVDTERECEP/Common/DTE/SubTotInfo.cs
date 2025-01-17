﻿using System.Collections.Generic;
using System;

namespace DTE
{
    public class SubTotInfo
    {
        public Int32 NroSTI { get; set; }
        public String GlosaSTI { get; set; }
        public Int32 OrdenSTI { get; set; }
        public Double SubTotNetoSTI { get; set; }
        public Double SubTotIVASTI { get; set; }
        public Double SubTotAdicSTI { get; set; }
        public Double SubTotExeSTI { get; set; }
        public Double ValSubtotSTI { get; set; }
        public List<LineasDeta> LineasDeta { get; set; }

        public SubTotInfo() {

            LineasDeta = new List<LineasDeta>();
        }
    }

    public class LineasDeta
    {
        public Int32 iLineasDeta { get; set; }

        public LineasDeta() { }
    }
}
