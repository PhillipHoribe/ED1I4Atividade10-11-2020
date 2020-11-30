using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoComecial
{
    class Venda
    {
        int qtde;
        double valor, valorMedio;
        public int getQtde {
            get { return qtde; }
            set { qtde = value; }
        }
        public double getValor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Venda(int qtde,double valor){
            this.qtde = qtde;
            this.valor = valor;
        }
        public double ValorMedio() {
            valorMedio = qtde * valor;
            return valorMedio;
        }
    }
}
