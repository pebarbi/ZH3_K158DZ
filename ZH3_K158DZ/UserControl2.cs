using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_K158DZ.ReceptModels;

namespace ZH3_K158DZ
{
    public partial class UserControl2 : UserControl
    { 
        ReceptContext context = new ReceptContext();

        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            //var dgv = from y in context.Receptek
            //          selext y.ReceptId;

            dataGridView1.DataSource = receptekBindingSource;
        }

        private void textBoxNyersanyagSzűrés_TextChanged(object sender, EventArgs e)
        {
            var keresettnyersanyag = from x in context.Nyersanyagok
                                     where x.NyersanyagNev.Contains(textBoxNyersanyagSzűrés.Text)
                                     select x;

            listBoxNyersanyagok.DataSource = keresettnyersanyag.ToList();
            listBoxNyersanyagok.DisplayMember = "NyersanyagNev";
        }

        private void listBoxNyersanyagok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
