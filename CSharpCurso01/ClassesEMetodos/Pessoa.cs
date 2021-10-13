using System;
namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
            
        
        public string Apresentar()
        {
            
            if (Nome != null && Idade >= 0)
            {
                 Console.WriteLine(" Dados incompleto ");

            }
            else
            {
                // O metodo Format faz o que ReadLine faz mas ele retona  a string formantada
            string.Format("Ola ! Meu nome é " + Nome + " e Tenho " + Idade + " anos");
            }
            return string.Format("Atenção Nome e Idade  precisa ser Preenchido ! ");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
      
    }
}
