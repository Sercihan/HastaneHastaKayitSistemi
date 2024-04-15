using HastaneHastaKayit.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneHastaKayit
{
    public partial class DoktorListele : Form
    {
        AdminBLL adminBLL;
        public DoktorListele()
        {
            InitializeComponent();
            adminBLL = new AdminBLL();
            dg_doktorListe.DataSource = adminBLL.DoktorListele();
        }
    }
}
