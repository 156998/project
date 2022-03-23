using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOBJ
{
    public class Celular
    {
        public string marca;
        public string modelo;
        public string cor;
        public string preco;
        public List<string> caracteristicas = new List<string>();
        public List<string> avaliacoes = new List<string>();

        public void Comprar()
        {   //ENTRADA DE DADOS

            Console.WriteLine(" /////////////////////////////////////////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" DADOS D0 CELULAR: ");
            Console.WriteLine(" Marca smartphone: " + marca);
            marca = Console.ReadLine();
            Console.WriteLine(" Modelo smartphone: " + modelo);
            modelo = Console.ReadLine();
            Console.WriteLine(" Cor do smartphone: " + cor);
            cor = Console.ReadLine();
            Console.WriteLine(" Preço do smartphone: " + preco);
            preco = Console.ReadLine();

            //VISUALIZAÇÃO DE DADOS INSERIDOS
            Console.WriteLine(" ");
            Console.WriteLine(" -----  CATALOGO DE CELULARES -----");
            Console.WriteLine(" Marca:   " + marca);
            Console.WriteLine(" Modelo:  " + modelo);
            Console.WriteLine(" Cor:     " + cor);
            Console.WriteLine(" Preço:   R$" + preco);

        }
    }
}



