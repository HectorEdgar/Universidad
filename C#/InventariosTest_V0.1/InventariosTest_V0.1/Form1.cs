using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventariosTest_V0._1
{
    public partial class Form1 : Form
    {
        private GuiPrincipal guiPrincipal;
        private NetBarControl.NetBarControl nbc;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guiPrincipal = new GuiPrincipal();
            guiPrincipal.Visible = true;
            this.Visible = false;
            nbc = new NetBarControl.NetBarControl();
            
        }
    }
}
