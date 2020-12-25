using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTest
{
    public partial class HexEditor : Form
    {
        public byte[] Data;
        ByteProvider _byteProvider;
        public HexEditor(byte[] editData)
        {
            InitializeComponent();
            _byteProvider = new ByteProvider(editData);
            hexBox1.ByteProvider = _byteProvider;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _byteProvider.ApplyChanges();
            Data = _byteProvider.Data;
        }
    }
}
