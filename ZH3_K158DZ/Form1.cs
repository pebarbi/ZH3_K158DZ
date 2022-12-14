using ZH3_K158DZ.ReceptModels;

namespace ZH3_K158DZ
{
    public partial class Form1 : Form
    {
        ReceptContext context = new ReceptContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 usercontrol1 = new UserControl1();
            panel1.Controls.Add(usercontrol1);
            //panel1.Dock = DockStyle.Fill();
            //UserControl1 = DockStyle.Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 usercontrol2 = new UserControl2();
            panel1.Controls.Add(usercontrol2);
            //UserControl2 = DockStyle.Fill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}