using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Pizza
{
    public class SaborPizza
    {
        public string nome;

        public int valor;
        public int tempo;
        public int custo;

        public SaborPizza(string nome, int valor, int tempo, int custo)
        {
            this.nome = nome;
            this.valor = valor;
            this.tempo = tempo;
            this.custo = custo;
        }

        public string GetNome()
        {
            return this.nome;
        }
    }
}
