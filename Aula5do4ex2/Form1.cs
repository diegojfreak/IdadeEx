using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5do4ex2
{
    public partial class frmCNH : Form
    {
        public frmCNH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Verifica_Click(object sender, EventArgs e)
        {
           
            int dataResult = (DateTime.Now.Year - dataUsuario.Value.Year);

            
            if(dataResult >= 18)
            {
                MessageBox.Show("Voce esta na idade!");
            }
            else
            {
                MessageBox.Show("Voce nao esta na idade!");
            }
            
        }
    }
}
