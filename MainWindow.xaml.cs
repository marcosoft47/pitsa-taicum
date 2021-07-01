using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Teste_Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Instanciar dinheiros e sabores

        int dinheiros = 0;
        public string nomePizzaria = "";
        SaborPizza pzaQueijo = new SaborPizza("Queijo", 20, 5, 0);
        SaborPizza pzaCalabresa = new SaborPizza("Calabresa", 40, 10, 100);
        SaborPizza pzaDoce = new SaborPizza("Doce", 80, 15, 150);
        SaborPizza pzaOvo = new SaborPizza("Ovo", 120, 20, 250);
        SaborPizza pzaFrango = new SaborPizza("Frango", 150, 30, 300);
        SaborPizza pzaMaconha = new SaborPizza("Ervas Medicinais", 200, 35, 500);
        SaborPizza pzaPneu = new SaborPizza("Pneu", 250, 40, 600);
        SaborPizza pzaJs = new SaborPizza("JavaScript", 400, 60, 700);
        SaborPizza pzaZap = new SaborPizza("Whatsapp", 500, 70, 1000);
        SaborPizza pzaJoao = new SaborPizza("Divina", 1000, 80, 2000);

        int sabores = 2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void pizzaria_onload(object sender, RoutedEventArgs e)
        {
            txtQueijo.Text = pzaQueijo.GetNome();
            txtCalabresa.Text = pzaCalabresa.GetNome();
            txtDoce.Text = pzaDoce.GetNome();
            txtOvo.Text = pzaOvo.GetNome();
            txtFrango.Text = pzaFrango.GetNome();
            txtMaconha.Text = pzaMaconha.GetNome();
            txtPneu.Text = pzaPneu.GetNome();
            txtJs.Text = pzaJs.GetNome();
            txtZap.Text = pzaZap.GetNome();
            txtJoao.Text = pzaJoao.GetNome();

            queijoLoading.Maximum = pzaQueijo.tempo;
            calabresaLoading.Maximum = pzaCalabresa.tempo;
            doceLoading.Maximum = pzaDoce.tempo;
            ovoLoading.Maximum = pzaOvo.tempo;
            frangoLoading.Maximum = pzaFrango.tempo;
            maconhaLoading.Maximum = pzaFrango.tempo;
            pneuLoading.Maximum = pzaFrango.tempo;
            jsLoading.Maximum = pzaFrango.tempo;
            zapLoading.Maximum = pzaFrango.tempo;
            joaoLoading.Maximum = pzaFrango.tempo;

            MessageBox.Show("Bem vindo ao pizzaria tycoon!");
            MessageBox.Show("Você estava cansado da sua vida pacata, então você decide sair de seu emprego");
            MessageBox.Show("Sua família era famosa por fazer pizzas deliciosas, mas você nunca deu muita atenção a como eram feitas");
            MessageBox.Show("Decidido a restaurar o legado de sua família, você abre sua própria pizzaria");
            MessageBox.Show("Toda pizzaria tem um bom nome, o nome é a alma do negócio");
            pedirNome pedirNome = new pedirNome();
            pedirNome.ShowDialog();
            nomePizzaria = pedirNome.nome();
            nomePizza.Text = nomePizzaria;
            MessageBox.Show("Você então abre a pizzaria " + nomePizzaria + ", que irá se tornar sucesso mundial rapidamente");
            MessageBox.Show("Como você não sabe como fazer pizzas deliciosas, você começa com a mais simples de todas...");
            MessageBox.Show("Pizza de Queijo! Simples e saborosa");
            MessageBox.Show("Clique na imagem da pizza para começar a fazer");
            MessageBox.Show("Quando tiver dinheiro suficiente, clique em comprar sabor para ter mais opções");
        }

        //Daqui para frente: Quando apertamos um botão de começar

        //Sim, eu podia colocar o código dentro da classe
        //Não, eu não sei como fazer isso
        //Não sei mudar as variaveis (queijoStart, queijoLoading...) dentro da classe

        //Sim, pesquisei cada coisa usada aqui
        private async void queijoStart_Click(object sender, RoutedEventArgs e)
        {
            queijoStart.IsEnabled = false;
            for (int i = 0; i < pzaQueijo.tempo; i++)
            {
                queijoLoading.Value = i;
                await Task.Delay(1000);
            }
            queijoLoading.Value = 0;
            this.dinheiros += pzaQueijo.valor;
            queijoStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: "+ this.dinheiros.ToString();
        }

        private async void calabresaStart_Click(object sender, RoutedEventArgs e)
        {
            calabresaStart.IsEnabled = false;
            for (int i = 0; i < pzaCalabresa.tempo; i++)
            {
                calabresaLoading.Value = i;
                await Task.Delay(1000);
            }
            calabresaLoading.Value = 0;
            this.dinheiros += pzaCalabresa.valor;
            calabresaStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void doceStart_Click(object sender, RoutedEventArgs e)
        {
            doceStart.IsEnabled = false;
            for (int i = 0; i < pzaDoce.tempo; i++)
            {
                doceLoading.Value = i;
                await Task.Delay(1000);
            }
            doceLoading.Value = 0;
            this.dinheiros += pzaDoce.valor;
            doceStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void ovoStart_Click(object sender, RoutedEventArgs e)
        {
            ovoStart.IsEnabled = false;
            for (int i = 0; i < pzaOvo.tempo; i++)
            {
                ovoLoading.Value = i;
                await Task.Delay(1000);
            }
            ovoLoading.Value = 0;
            this.dinheiros += pzaOvo.valor;
            ovoStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void frangoStart_Click(object sender, RoutedEventArgs e)
        {
            frangoStart.IsEnabled = false;
            for (int i = 0; i < pzaFrango.tempo; i++)
            {
                frangoLoading.Value = i;
                await Task.Delay(1000);
            }
            frangoLoading.Value = 0;
            this.dinheiros += pzaFrango.valor;
            frangoStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void maconhaStart_Click(object sender, RoutedEventArgs e)
        {
            maconhaStart.IsEnabled = false;
            for (int i = 0; i < pzaMaconha.tempo; i++)
            {
                maconhaLoading.Value = i;
                await Task.Delay(1000);
            }
            maconhaLoading.Value = 0;
            this.dinheiros += pzaMaconha.valor;
            maconhaStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void pneuStart_Click(object sender, RoutedEventArgs e)
        {
            pneuStart.IsEnabled = false;
            for (int i = 0; i < pzaPneu.tempo; i++)
            {
                pneuLoading.Value = i;
                await Task.Delay(1000);
            }
            pneuLoading.Value = 0;
            this.dinheiros += pzaPneu.valor;
            pneuStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void jsStart_Click(object sender, RoutedEventArgs e)
        {
            jsStart.IsEnabled = false;
            for (int i = 0; i < pzaJs.tempo; i++)
            {
                jsLoading.Value = i;
                await Task.Delay(1000);
            }
            jsLoading.Value = 0;
            this.dinheiros += pzaJs.valor;
            jsStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void zapStart_Click(object sender, RoutedEventArgs e)
        {
            zapStart.IsEnabled = false;
            for (int i = 0; i < pzaZap.tempo; i++)
            {
                zapLoading.Value = i;
                await Task.Delay(1000);
            }
            zapLoading.Value = 0;
            this.dinheiros += pzaZap.valor;
            zapStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }

        private async void joaoStart_Click(object sender, RoutedEventArgs e)
        {
            joaoStart.IsEnabled = false;
            for (int i = 0; i < pzaJoao.tempo; i++)
            {
                joaoLoading.Value = i;
                await Task.Delay(1000);
            }
            joaoLoading.Value = 0;
            this.dinheiros += pzaJoao.valor;
            joaoStart.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        }


        //Comprar Sabores novos
        //queijo, calabresa, doce, ovo, frango, maconha, pneu, js, zap, jao
        private void comprar_Click(object sender, RoutedEventArgs e)
        {
            switch (sabores)
            {
                case 2:
                    if (dinheiros >= pzaCalabresa.custo)
                    {
                        MessageBox.Show("Com a simplicidade de fazer pizzas de queijo, você decide dar uma melhorada nos sabores");
                        MessageBox.Show("Com toda sua genialidade, você coloca calabresa na sua pizza, fazendo assim a pizza de calabresa!");
                        calabresaLoading.Visibility = Visibility.Visible;
                        txtCalabresa.Visibility = Visibility.Visible;
                        calabresaStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaCalabresa.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaDoce.custo + ")";
                        break;
                    }
                    else
                        break;
                case 3:
                    if (dinheiros >= pzaDoce.custo)
                    {
                        MessageBox.Show("Cansado de fazer pizzas salgados, você dá uma variedade de sabores");
                        MessageBox.Show("Você pega uma barra de chocolate Garoto e confeitos e lambuza toda a pizza");
                        MessageBox.Show("Você cria então a pizza doce, que algum italiano deve estar chorando por causa de sua mais nova invenção");
                        doceLoading.Visibility = Visibility.Visible;
                        txtDoce.Visibility = Visibility.Visible;
                        doceStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaDoce.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaOvo.custo + ")";
                        break;
                    }
                    else
                        break;
                case 4:
                    if (dinheiros >= pzaOvo.custo)
                    {
                        MessageBox.Show("Você ganhou o bingo da igreja!");
                        MessageBox.Show("O prêmio que você recebou foi um frango, que você apelidou de Ricardo");
                        MessageBox.Show("Como agora você tem um estoque infinito de ovo graças ao frango, você cria uma pizza de ovo!");
                        MessageBox.Show("Não pergunte como um frango bota ovo...");
                        ovoLoading.Visibility = Visibility.Visible;
                        txtOvo.Visibility = Visibility.Visible;
                        ovoStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaOvo.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaFrango.custo + ")";
                        break;
                    }
                    else
                        break;
                case 5:
                    if (dinheiros >= pzaFrango.custo)
                    {
                        MessageBox.Show("Ricardo está ficando velho, e não põe tantos ovos quanto botava");
                        MessageBox.Show("Ele pede para você tornar ele um sabor de pizza...");
                        MessageBox.Show("Ricardo foi seu companheiro por anos, e você não tem coragem de matar ele");
                        MessageBox.Show("Então você cria uma pizza com frangos vivos!");
                        frangoLoading.Visibility = Visibility.Visible;
                        txtFrango.Visibility = Visibility.Visible;
                        frangoStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaFrango.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaMaconha.custo + ")";
                        break;
                    }
                    else
                        break;
                case 6:
                    if (dinheiros >= pzaMaconha.custo)
                    {
                        MessageBox.Show("Depois do caso da pizza de frango, suas medidas de sanitização foram questionadas, afastando vários clientes...");
                        MessageBox.Show("Querendo trazer eles de volta você cria o sabor de pizza mais viciante e agradável...");
                        MessageBox.Show("A pizza de ervas medicinais!");
                        maconhaLoading.Visibility = Visibility.Visible;
                        txtMaconha.Visibility = Visibility.Visible;
                        maconhaStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaMaconha.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaPneu.custo + ")";
                        break;
                    }
                    else
                        break;
                case 7:
                    if (dinheiros >= pzaPneu.custo)
                    {
                        MessageBox.Show("Você se atrasa para o trabalho porque o pneu do seu carro furou, e você não tinha um reserva");
                        MessageBox.Show("Para se vingar desse pneu, você cria uma pizza de pneu");
                        MessageBox.Show("Agora os familiares daquele pneu serão servidos e devorados por toda a eternidade");
                        MessageBox.Show("Você não faz ideia de como essa pizza é comestível...");
                        pneuLoading.Visibility = Visibility.Visible;
                        txtPneu.Visibility = Visibility.Visible;
                        pneuStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaPneu.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaJs.custo + ")";
                        break;
                    }
                    else
                        break;
                case 8:
                    if (dinheiros >= pzaJs.custo)
                    {
                        MessageBox.Show("Sua pizzaria está tão grande que você quer abrir um site para ela");
                        MessageBox.Show("Como você é mão de vaca, você aprende por conta própria");
                        MessageBox.Show("Você aprende tão bem, mas tão bem, que você consegue usar JavaScript para criar seu próprio sabor de pizzas!");
                        jsLoading.Visibility = Visibility.Visible;
                        txtJs.Visibility = Visibility.Visible;
                        jsStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaJs.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaZap.custo + ")";
                        break;
                    }
                    else
                        break;
                case 9:
                    if (dinheiros >= pzaZap.custo)
                    {
                        MessageBox.Show("Um novo aplicativo está para vir, e muitos da cidade estão animados com a vinda desse aplicativo");
                        MessageBox.Show("Para fazer propaganda desse aplicativo, você cria uma pizza dedicada para esse aplicativo");
                        MessageBox.Show("Assim, vocÊ cria a pizza Whatsapp para comemorar a vinda do Whatsapp 2");
                        zapLoading.Visibility = Visibility.Visible;
                        txtZap.Visibility = Visibility.Visible;
                        zapStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaZap.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Comprar Sabor (" + pzaJoao.custo + ")";
                        break;
                    }
                    else
                        break;
                case 10:
                    if (dinheiros >= pzaJoao.custo)
                    {
                        MessageBox.Show("Sem ideias de novos sabores, você vai a igreja pedindo ajuda para criar um novo sabor");
                        MessageBox.Show("Deus, ouvindo seu pedido te dá a benção de criar um sabor divino, um sabor que parece um pedacinho do céu");
                        MessageBox.Show("Assim, você cria a pizza Divina, vinda diretamente dos deuses");
                        joaoLoading.Visibility = Visibility.Visible;
                        txtJoao.Visibility = Visibility.Visible;
                        joaoStart.Visibility = Visibility.Visible;
                        dinheiros -= pzaJoao.custo;
                        dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
                        sabores++;

                        comprar.Content = "Se aposentar (5000)";
                        break;
                    }
                    else
                        break;
                case 11:
                    if (dinheiros >= 5000)
                    {
                        MessageBox.Show("Com seus 5000 dinheiros, você consegue se aposentar de alguma forma");
                        MessageBox.Show("Abandonando a vida de pizzaiolo, você vai viver o resto de sua vida tranquilamente");
                        MessageBox.Show("Seu legado no mundo das pizzas jamais será esquecido");
                        MessageBox.Show("Obrigado por jogar! Feito por Marco Rigon - 3B Informática");
                        this.Close();
                    }
                    break;
            }
        }

        /*Start.IsEnabled = false;
            for (int i = 0; i<pza.tempo; i++)
            {
                Loading.Value = i;
                await Task.Delay(1000);
            }
            Loading.Value = 0;
            this.dinheiros += pza.valor;
            Start.IsEnabled = true;

            dinheiroShow.Content = "Dinheiro: " + this.dinheiros.ToString();
        */
    }
}
