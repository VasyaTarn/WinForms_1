namespace WinForms__1
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            //MessageBox.Show("ARARARARAR");
            button1.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256), r.Next(256));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random r = new Random();

            button1.Location = new Point(r.Next(Size.Width - (button1.Size.Width / 2)), r.Next(Size.Height - (button1.Size.Height / 2)));
        }
    }
}