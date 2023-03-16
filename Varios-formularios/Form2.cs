using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varios_formularios
{
    public partial class form2 : Form
    {
        public form2(String v)
        {
            InitializeComponent();
            txtBoxMultiLines.Text = v;
        }

        private void txtBoxMultiLines_Load(object sender, EventArgs e)
        {

        }
    }
}
