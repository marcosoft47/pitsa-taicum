using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Teste_Pizza
{
    /// <summary>
    /// Lógica interna para pedirNome.xaml
    /// </summary>
    public partial class pedirNome : Window
    {
        public string resposta = "";
        public pedirNome()
        {
            InitializeComponent();
        }

        private void aceitarNome_Click(object sender, RoutedEventArgs e)
        {
            if(nomeDigitado.Text == "")
            {
                MessageBox.Show("Sua pizzaria não tem nome? Seja um pouco criativo!");
            }
            else
            {
                resposta = nomeDigitado.Text;
                this.Close();
            }
        }

        public string nome()
        {
            return resposta;
        }
    }
}
