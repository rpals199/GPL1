namespace Graphical_Programming_Language
{
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(640, 480);
        Canvass MyCanvass;
        public Form1()
        {
            InitializeComponent();
            MyCanvass = new Canvass(Graphics.FromImage(OutputBitmap));       
        }

        private void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(Command.Equals("line") == true)
                {
                    MyCanvass.DrawLinee(160, 120);
                    Console.WriteLine("LINE");

                }
                else if(Command.Equals("square")== true)
                {
                    MyCanvass.DrawSquare(25);
                    Console.WriteLine("LINE");

                }
                commandLine_KeyDown().Text = "";
                Refresh();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }
    }


}