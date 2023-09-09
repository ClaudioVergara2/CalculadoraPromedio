using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperSacadorDePromedio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                String snum = tb_nota1.Text;
                if (String.IsNullOrEmpty(snum))
                {
                    MessageBox.Show("Debe ingresar los datos de la nota 1");
                    tb_nota1.Focus();
                }
                String snum2 = tb_nota2.Text;
                if (String.IsNullOrEmpty(snum2))
                {
                    MessageBox.Show("Debe ingresar los datos de la nota 2");
                    tb_nota2.Focus();
                }
                String snum3 = tb_nota3.Text;
                if (String.IsNullOrEmpty(snum3))
                {
                    MessageBox.Show("Debe ingresar los datos de la nota 3");
                    tb_nota3.Focus();
                }
                String spor1 = tb_por1.Text;
                if (String.IsNullOrEmpty(spor1))
                {
                    MessageBox.Show("Debe ingresar los datos del % la nota 1");
                    tb_por1.Focus();
                }
                String spor2 = tb_por2.Text;
                if (String.IsNullOrEmpty(spor2))
                {
                    MessageBox.Show("Debe ingresar los datos del % la nota 2");
                    tb_por2.Focus();
                }
                String spor3 = tb_por3.Text;
                if (String.IsNullOrEmpty(spor3))
                {
                    MessageBox.Show("Debe ingresar los datos del % la nota 3");
                    tb_por3.Focus();
                }
                else
                {
                    double num1 = Convert.ToDouble(snum);
                    double num2 = Convert.ToDouble(snum2);
                    double num3 = Convert.ToDouble(snum3);

                    double por1 = Convert.ToDouble(spor1);
                    double por2 = Convert.ToDouble(spor2);
                    double por3 = Convert.ToDouble(spor3);

                    double resultado = 0;
                    double promedio = 0;

                    if (num1 > 70)
                    {
                        MessageBox.Show("En la Nota 1 debe ingresar notas del 0 al 70");
                        tb_nota1.Focus();
                    }
                    if (num2 > 70)
                    {
                        MessageBox.Show("En la Nota 2 debe ingresar notas del 0 al 70");
                        tb_nota2.Focus();
                    }
                    if (num3 > 70)
                    {
                        MessageBox.Show("En la Nota 3 debe ingresar notas del 0 al 70");
                        tb_nota3.Focus();
                    }
                    if (por1 > 100)
                    {
                        MessageBox.Show("El % Nota 1 debe ingresar % del 1 al 100");
                        tb_por1.Focus();
                    }
                    if (por2 > 100)
                    {
                        MessageBox.Show("El % Nota 2 debe ingresar % del 1 al 100");
                        tb_por2.Focus();
                    }
                    if (por3 > 100)
                    {
                        MessageBox.Show("El % Nota 3 debe ingresar % del 1 al 100");
                        tb_por3.Focus();
                    }
                    else
                    {
                        resultado = por1 + por2 + por3;
                    }
                    if(resultado < 100)
                    {
                        MessageBox.Show("Error al sumar los porcentaje, deben ser igual a 100");
                    }
                    else
                    {
                        promedio = (num1 + num2 + num3) / 3; 
                    }
                    tb_promedio.Text = Convert.ToString(promedio);
                }
            }
            catch
            {

            }
        }

        private void btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            tb_nota1.Clear();
            tb_nota2.Clear();
            tb_nota3.Clear();
            tb_por1.Clear();
            tb_por2.Clear();
            tb_por3.Clear();
            tb_promedio.Clear();
        }
    }
}
