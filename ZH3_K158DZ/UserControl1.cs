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
    public partial class UserControl1 : UserControl
    {
        ReceptContext context = new ReceptContext();

        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            FogásSzűrés();
            FogásListázás();
        }

        private void textBoxFogásSzűrés_TextChanged(object sender, EventArgs e)
        {
            FogásSzűrés();
        }

        private void FogásSzűrés()
        {
            var keresettfogás = from x in context.Fogasok
                                where x.FogasNev.Contains(textBoxFogásSzűrés.Text)
                                select x.FogasNev;

            listBoxFogások.DataSource = keresettfogás.ToList();
            listBoxFogások.DisplayMember = "Name";
        }

        private void listBoxFogások_SelectedIndexChanged(object sender, EventArgs e)
        {
            FogásListázás();

        }

        private void FogásListázás()
        {
            var kivalasztottfogas = /*(Hozzavalok)*/listBoxFogások.SelectedItem;

            //join r on f.FogasId equals r.FogasId
            //join Receptek r on r.Fogasid equals f.FogasId

            var recept = from f in context.Fogasok
                         where f.FogasNev == kivalasztottfogas.ToString()
                         select f;
                         //select new Hozzavalok
                         //{
                         //    FogasId = f.FogasId,
                         //    ReceptId = f.ReceptId,
                         //    Ár = f.Mennyiseg_4fo * (double?)Egysegar,
                         //};

            //dataGridView1.DataSource = recept.ToList();

            dataGridView1.DataSource = hozzavalokBindingSource;
        }
    }
}
