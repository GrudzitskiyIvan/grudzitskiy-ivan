using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Формы_ЛР5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void Form1_MouseClick(object sender, MouseEventArgs e)
            {
                Random rand = new Random();
                if (e.Button == MouseButtons.Left)
                {
                    Label label = new Label();
                    label.Location = e.Location;
                    label.Size = new Size(rand.Next(50, 50), rand.Next(50, 50));
                    label.Text = "Тыкнул тут";
                    Button button = new Button();
                    button.Location = e.Location;
                    button.Size = new Size(rand.Next(50, 100), rand.Next(50, 100));
                    this.Controls.Add(label);
                    this.Controls.Add(button);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Controls.Clear();
                }
            }       
    }
}
