namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var grx = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                Color c = Color.FromName(listBox1.Text);
                SolidBrush s = new SolidBrush(c);
                grx.FillEllipse(s, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Right)
            {
                SolidBrush s = new SolidBrush(BackColor);
                grx.FillEllipse(s, e.X - 10, e.Y - 10, 40, 40);
            }
        }
    }
}
