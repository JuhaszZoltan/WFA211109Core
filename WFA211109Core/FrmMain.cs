namespace WFA211109Core
{
    public partial class FrmMain : Form
    {
        static readonly Random rnd = new();
        public FrmMain() => InitializeComponent();

        private void LblHelloCore_Click(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}