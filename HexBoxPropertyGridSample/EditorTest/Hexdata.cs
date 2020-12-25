using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTest
{
    public class Hexdata
    {
        [Editor(typeof(HexDataEditor), typeof(UITypeEditor))]
        public byte[] Data { get; set;}
        public Hexdata()
        {
            Data = new byte[100];
            var random = new Random();
            random.NextBytes(Data);
        }
    }
}
