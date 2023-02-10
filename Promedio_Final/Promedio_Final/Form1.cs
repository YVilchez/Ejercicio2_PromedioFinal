using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Promedio_Click(object sender, EventArgs e)
        {
            ecimal N1 = Convert.ToDecimal(tb_Nota1.Text);
            decimal N2 = Convert.ToDecimal(tb_Nota2.Text);
            decimal N3 = Convert.ToDecimal(tb_Nota3.Text);
            decimal N4 = Convert.ToDecimal(tb_Nota4.Text);


            decimal Notatotal = await PromedioAsync(N1, N2, N3, N4);

            MessageBox.Show($"El promedio FINAL es =  {Notatotal} %");
        }

        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal Promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;

            });
            return Promedio;
        }
    }
}

