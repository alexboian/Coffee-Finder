namespace pag_setari
{
    public partial class PROFIL : Form
    {
        public PROFIL()
        {
            InitializeComponent();
        }

        private void PROFIL_Load(object sender, EventArgs e)
        {   //fac poza cerc
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, profilepicture.Width - 1, profilepicture.Height - 1);

            // aplic forma
            profilepicture.Region = new Region(gp);

        }

        private void profilepicture_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FAV3_Click(object sender, EventArgs e)
        {

        }

        private void FAV1_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, FAV1.Width - 1, FAV1.Height - 1);
            FAV1.Region = new Region(gp);
        }

        private void FAV2_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, FAV2.Width - 1, FAV2.Height - 1);
            FAV2.Region = new Region(gp);

        }

        private void FAV3_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, FAV3.Width - 1, FAV3.Height - 1);
            FAV3.Region = new Region(gp);

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOutProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
