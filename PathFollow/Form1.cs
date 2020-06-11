using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFollow
{
    public partial class Form1 : Form
    {
        List<Enemy> enemies = new List<Enemy>();
        SolidBrush enemyBrush = new SolidBrush(Color.Red);

        int counter = 0;

        public Form1()
        {
            InitializeComponent();

            Enemy enemy = new Enemy(50, 0, 20, 5);
            enemies.Add(enemy);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter == 40)
            {
                Enemy enemy = new Enemy(50, 0, 20, 5);
                enemies.Add(enemy);
                counter = 0;
            }

            foreach(Enemy enemy in enemies)
            {
                enemy.Move();
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Enemy enemy in enemies)
            {
                e.Graphics.FillRectangle(enemyBrush, enemy.x, enemy.y, enemy.size, enemy.size);
            }
        }
    }
}
