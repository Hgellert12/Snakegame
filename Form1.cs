namespace snakegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int headx = 100;
        int heady = 100;
        int dirx = 1;
        int diry = 0;
        int length = 5;
        int stepcount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            headx += dirx * snakepart.size;
            heady += diry * snakepart.size;
            snakepart newhead = new snakepart();
            newhead.Left = headx;
            newhead.Top = heady;


            foreach (snakepart item in Controls)
            {
                if (item.Left == headx && item.Top == heady)
                {
                    Application.Exit();
                }
            }
            Controls.Add(newhead);

            if (Controls.Count > length)
            {
                Controls.RemoveAt(0);
            }
            if (stepcount % 5 == 0)
            {
                length++;
            }
            stepcount++;



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                dirx = 0;
                diry = -1;

            }
            if (e.KeyCode == Keys.A)
            {
                dirx = -1;
                diry = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                dirx = 0;
                diry = 1;
            }
            if (e.KeyCode == Keys.D)
            {
                dirx = 1;
                diry = 0;
            }
        }
    }
}
