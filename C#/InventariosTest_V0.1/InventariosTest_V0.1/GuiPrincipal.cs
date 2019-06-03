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
    public partial class GuiPrincipal : Form
    {
        public GuiPrincipal()
        {
            InitializeComponent();
            
        }

        private void GuiPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected)
            {
                
                Console.WriteLine("hola");
                Console.WriteLine(e.Node.Name);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            Console.WriteLine("safasdfasdfasdfasdf");
        }
    }
}
