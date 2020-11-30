using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoComecial
{
    class Vendedores
    {
        public Vendedor[] osVendedores;
        int max;
        int qtde;
        public Vendedores() {
            max = 10;
            qtde = 0;
            osVendedores = new Vendedor[max];
        }
        public bool addVendedor(Vendedor v) {
            if (qtde <= 9)
            {
                osVendedores[qtde] = v;
                qtde = qtde + 1;
                return true;
            }
            else {
                return false;
            }
        }
        public bool delVendedor(Vendedor v)
        {
            for(int i = 0; i < qtde; i++)
            {
                Vendedor vendedor = osVendedores[i];
                if (vendedor.id == v.id && vendedor.valorVendas() > 0)
                {
                    osVendedores[i] = osVendedores[qtde];
                    osVendedores[qtde] = null;
                    qtde = qtde - 1;
                    return true;
                }
            }
            return false;
        }
        public Vendedor searchVendedor(Vendedor v) {
            for (int i = 0; i < qtde; i++)
            {
                Vendedor vendedor = osVendedores[i];
                if (vendedor.id == v.id) {
                    Console.WriteLine("id:" + vendedor.id + "\nnome" + vendedor.nome + "\nvalor vendas:" + valorVendas() + "\nvalor comissão:" + valorComissao());
                    //return vendedor;
                }
            }
            return null;
        }
        public double valorVendas()
        {
            double total = 0;
            for (int i = 0; i < qtde; i++)
            {
                Vendedor vendedor = osVendedores[i];
                total = total + vendedor.valorVendas();
            }
            return total;
        }
        public double valorComissao()
        {
            double total = 0;
            for (int i = 0; i < qtde; i++)
            {
                Vendedor vendedor = osVendedores[i];
                total = total + vendedor.valorComissao();
            }
            return total;
        }
        public void listarVendedor() {
            for (int i = 0; i < qtde; i++)
            {
                Vendedor vendedor = osVendedores[i];
                Console.WriteLine("nome:" + vendedor.nome + " id:" + vendedor.id + " valor total:" + valorVendas() + " Valor Comissao:" + valorComissao() + "\n");
                Console.WriteLine();
            }   
        }
    }

}
