using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos ;
using CursoCSharp.OO;
using CSharpCurso01.OO;

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

                 {"Struct Classes  - Classes e Metodos  ", ExemploStruct.Executar },
                 {"Struct  VS Classes - Classes e Metodos  ", StructVsClass.Executar },
                 {"Valor vs Referência -Class e Metodos ",ValorVsReferencia.Executar }, 
                              
                 // Orientação a objeto OO                              
                  {"Orientação a Objeto - OO  ", Heranca.Executar }, 
                  {"Costrutores  this - OO  ", ConstrutoresThis.Executar },
                   { "Encapsulamento  - OO  ", Encapsulamento.Executar }, 
                   { "Polimorfismos - OO  ", Polimorfimo.Executar}, 
                   { "Abstract - OO  ", Abstract.Executar}, 


    
            }); 


            central.SelecionarEExecutar();
            
        }
    }
}