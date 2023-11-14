namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] banana = new string[1];
            banana[0] = "test";
            GetStringForm gsf = new GetStringForm("Testing", ref banana);
            gsf.ShowDialog();
            label1.Text = banana[0];
        }
    }
}