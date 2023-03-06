using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiatLogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private List<Color> colors = new List<Color>() { Color.Green, Color.White, Color.White, Color.Red };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            //
            Draw();
        }

        private void Draw()
        {
            int y = 592;//516
            int dif = 30;
            int xCenter = 959;
            int x1 = 839;
            int x2 = 869;
            x2 += dif * 3;//INCLINAÇÃO
            //
            for (int i = 0; i < colors.Count; i++)
            {
                graphics.DrawLine(new Pen(new SolidBrush(colors[i]), 30), x1, y, x2, (y - 346));
                x1 += (dif * 2);
                x2 += (dif * 2);
            }
            //
            graphics.DrawLine(new Pen(new SolidBrush(Color.Black), 150), (xCenter - 134), y, (xCenter + 195), y);//TARJA INFERIOR
            graphics.DrawLine(new Pen(new SolidBrush(Color.Black), 150), (xCenter - 134), (y - 346), (xCenter + 195), (y - 346));//TARJA SUPERIOR
            //
            //graphics.DrawLine(new Pen(new SolidBrush(Color.White), 1), xCenter, y, xCenter, (y - 346));//LINHA CENTRAL
        }
    }
}
