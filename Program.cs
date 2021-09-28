using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos ;
<<<<<<< HEAD
using CursoCSharp.OO;
=======
using CursoCSharp.Colecoes;

>>>>>>> be47f22ed7a044543bb92cdffb0b6af45e1b0f97
namespace CursoCSharp {
    class Program {
        static void Main(string[] args)
        {


            CentralDeExercicios central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Iferência - Fundamentos",Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"formantando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversôs - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRealcionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atibuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},
                  // Estrutura de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else- Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar } ,
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estrutura de Controle",UsandoBreak.Executar },
                {"Usando Continue - Estrutura de Controle",UsandoContinue.Executar },
               
                // Classe e Metodos
                 {" Membors - Classes e Metodos ", Membros.Executar  },
                 {" Construtores - Classes e Metodos ", Construtores.Executar },
                 {" Metodo com Retorno - Classes e Metodos ",MetodoscomRetorno.Executar },
                 {" Metodo Estáticos - Classes e Metodos ",MetodosEstaticos.Executar },
                 {" Atributos Estáticos - Classes e Metodos ",AtributosEstaticos.Executar },
                 {" Desafio Atributo - Classes e Metodos ",DesafioAtributo.Executar },
                 {" Params - Classes e Metodos ",Params.Executar },
                 {" Parametros Nomeados - Classes e Metodos ",ParametrosNome.Executar },
                 {" Getters & Setters- Classes e Metodos ",GetSet.Executar },
                 {" Props- Classes e Metodos ",Props.Executar },
                 {" Atributos Readonly- Classes e Metodos ",Readonly.Executar },
                 {"Enum Classes e Metodos ", ExemploEnum.Executar },
<<<<<<< HEAD
                 {"Struct Classes  - Classes e Metodos  ", ExemploStruct.Executar },
                 {"Struct  VS Classes - Classes e Metodos  ", StructVsClass.Executar },
                 {"Valor vs Referência -Class e Metodos ",ValorVsReferencia.Executar }, 
                              
                 // Orientação a objeto OO                              
                  {"Orientação a Objeto - OO  ", Heranca.Executar }, 
                  {"Costrutores  this - OO  ", ConstrutoresThis.Executar }, 
                  {"Encapsumanto - OO  ", Encapsulamento.Executar },


=======
                 {"Struct Classes e Metodos ", ExemploStruct.Executar },
                 {"Struct VS Class - Classes e Metodos ",StructVsClass.Executar },
                 {"Valor vs Referência - Classes e Metodos ",ValorVsReferencia.Executar },
                 {"Paramentro  por Referência- Classes e Metodos",ParamentrosPorReferencia.Executar },
                 {"Paramentro Padrão- Classes e Metodos",ParamentrosPadrao.Executar},
                   
                 // Coleções
                 /*
                   Exemplo de como ficaria se o nome da class fosse uma palavra reservada do C#
                       {"Array - Coleções",Colecao.Array.Executar}, 
                 */
                  {"Array - Coleções",ColecaoArray.Executar},
                  {" List - Coleções",ColecoesList.Executar},  
                  {" Arry List - Coleções",ColecoesArrayList.Executar},
                  {" Set - Coleções",ColecoesSet.Executar},
                  {" Queue - Coleções",ColecoesFilaQueue.Executar}, 
                  {" Igualdade - Coleções",Igualdade.Executar}, 
                  {" Stack - Coleções",ColecaoStack.Executar}, 
                   {"Dictionary - Coleções",ColecoesDictionary.Executar}, 


                 
>>>>>>> be47f22ed7a044543bb92cdffb0b6af45e1b0f97



            }); 


            central.SelecionarEExecutar();
            
        }
    }
}