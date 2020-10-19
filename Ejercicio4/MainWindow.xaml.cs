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

namespace Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
            contadorTextBox.Text = contador.ToString() + "/140";
            

        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contador++;
            contadorTextBox.Text = contador.ToString() + "/140";
            if (contador >= 140)
            {
                textoTextBox.IsReadOnly = true;
            }

        }
    }
}
