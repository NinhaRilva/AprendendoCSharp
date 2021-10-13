using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{ class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get {
                return "Opcional " + nome;
            }
            set {
                nome = value;
            }
        }
        // propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }

    
    public CarroOpcional()
    {

    }
    public CarroOpcional(string nome, double preco)
        {
            this.nome = nome;
            Preco = preco;
        }

}

    class Props
    {
         public static void Executar()
        {
            var carOpc1 = new CarroOpcional("Ar Condicionado", 3499.9);
           // Console.WriteLine(carOpc1.PrecoComDesconto);

            // carOpc.PrecoComDesconto = 3000; 
            //  CarOpc não pode ser atribuida pois e get só leitura não tem set associada a ela

            var carOpc2 = new CarroOpcional();
            carOpc2.Nome = "Direção Eletrica ";
            carOpc2.Preco = 2349.9;

            Console.WriteLine(carOpc1.Nome+" R$ " + carOpc1.Preco);
            Console.WriteLine( " com Desconto " + carOpc1.PrecoComDesconto);
            Console.WriteLine(carOpc2.Nome + "R$ " + carOpc2.Preco);
            Console.WriteLine(" com Desconto "+carOpc2.PrecoComDesconto);

        }
    }
}
