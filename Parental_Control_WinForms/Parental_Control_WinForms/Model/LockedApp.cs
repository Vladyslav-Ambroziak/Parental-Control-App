using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parental_Control_WinForms.Model
{
    public class LockedApp
    {
        public int Id { get; set; }
        public string IconApp { get; set; }
        public string NameApp { get; set; }
        public string NameProcess { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public string StatusTime { get; set; }
        public string Status { get; set; }

        public LockedApp() { }
    }
}
