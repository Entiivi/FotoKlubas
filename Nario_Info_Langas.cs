using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FotoKlubas
{
    public partial class Nario_Info_Langas : Form
    {
        public Nario_Info_Langas()
        {
            InitializeComponent();
        }

        private void Nario_Info_Langas_Load(object sender, EventArgs e)
        {
            label_user.Text = Prisijungimas.LoggedInUsername;
            label_pass.Text = Prisijungimas.LoggedInPassword;
        }
    }
}
