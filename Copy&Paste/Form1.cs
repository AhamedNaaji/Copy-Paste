using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_Paste
{
    public partial class CopyPaste : Form
    {
        public CopyPaste()
        {
            InitializeComponent();
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            txtCopy.SelectAll();
            txtCopy.Focus();
            txtCopy.Copy();

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtPaste.Paste();   
        }
    }
}
