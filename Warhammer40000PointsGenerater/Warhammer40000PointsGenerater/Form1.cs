using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warhammer40000PointsGenerater
{
    public partial class Form1 : Form
    {
        double price=0;
        Model nowMod;
        public Form1()
        {
            nowMod = new InfanryModels(4, 4, 4, 4, 1, 4, 1, 8, 3, 7, new List<Weapon> { new RangeWeap(4, 5, 12, 2) });
            InitializeComponent();
            price = nowMod.price();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
