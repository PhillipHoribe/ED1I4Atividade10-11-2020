using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoComecial
{
    class Vendedor
    {
        public int id, dia;
        public string nome;
        public double percComissao;
        public Venda[] asVendas;
        public Vendedor(int id, string nome, double percComissao) {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            this.asVendas = new Venda[31];
        }
        public Vendedor(int id) {
            this.id = id;
        }
        

        public void registrarVenda(int dia, Venda venda) {
            asVendas[dia] = venda;
            
        }
        public double valorVendas() {
            double total = 0;
            for (int i = 0; i < 31; i++)
            {
                Venda venda = asVendas[i];
                if (venda != null)
                {
                    total = total + venda.ValorMedio();
                }
            }
            return total;
        }
        public double valorComissao(){
            return valorVendas() * percComissao;
        }
        
    }
}
