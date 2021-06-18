using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;



namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos",Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos",Inferencia.Executar },
                {"Interpolãção - Fundamentos",Interpolacao.Executar },
                {"Notação Ponto- Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados- Fundamentos",LendoDados.Executar },
                {"Formatando Numeros- Fundamentos",FormatandoNumero.Executar },
                {"Conversões- Fundamentos",Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos",OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos",OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos",OperadoresUnarios.Executar },
                {"Operadores Ternários - Fundamentos",OperadorTernario.Executar },
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle",EstruturaIfElse.Executar },
                {"Estrutura If/Else If - Estruturas de Controle",EstruturaIfElseIf.Executar },
                {"Estrutura Switch- Estruturas de Controle",EstruturaSwitch.Executar },
                {"Estrutura While- Estruturas de Controle",EstruturaWhile.Executar },
                {"Estrutura Do While- Estruturas de Controle",EstruturaDoWhile.Executar },
                {"Estrutura For- Estruturas de Controle",EstruturaFor.Executar },
                {"Estrutura Foreach- Estruturas de Controle",EstruturaForeach.Executar },
                {"Usando Break- Estruturas de Controle",UsandoBreak.Executar },
                {"Usando Continue- Estruturas de Controle",UsandoContinue.Executar },
               
                // Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar },
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
                {"Métodos Estaticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Atributos Estaticos - Classes e Métodos",AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos",DesafioAtributo.Executar },
                {"Parâmetros Variáveis - Classes e Métodos",Params.Executar },
                {"Parâmetros Nomeados - Classes e Métodos",ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos",GetSet.Executar },
                {"Propriedades - Classes e Métodos",Props.Executar },
                {"Readonly - Classes e Métodos",Readonly.Executar },
                {"Enum - Classes e Métodos",ExemploEnum.Executar },
                {"Struct - Classes e Métodos",ExemploStruct.Executar },
                {"Struct VS Classe - Classes e Métodos",StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e Métodos",ValorVsReferencia.Executar },
                {"Parametros por Referencia - Classes e Métodos",ParametrosPorReferencia.Executar },
                {"Parametros com Valor Padrão - Classes e Métodos",ParametroPadrao.Executar },
                
                
                //Coleçoes
                {"Array - Coleções",Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"ArrayList - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stacks - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
              

                //OO
                 {"Heranca - OO",Heranca.Executar },
                 {"Construtor This - OO",ConstrutorThis.Executar },
                 {"Encapsulamento - OO",OO.Encapsulamento.Executar },
                 {"Polimorfismo - OO",Polimorfismo.Executar },
                 {"Abstract - OO",Abstract.Executar },
                 {"Interface - OO",Interface.Executar },
                 {"Sealed - OO",Sealed.Executar },
                 
                //Metodos E Funções
                 {"Exemplo Lambda - Metodos E Funções ",ExemploLambda.Executar },
                 {"Lambda Delegate - Metodos E Funções ",LambdaDelegate.Executar },
                 {"Usando Delegates - Metodos E Funções ",UsandoDelegates.Executar },
                 {"Delegates com Funções Anônimas - Metodos E Funções ",DelegateFunAnonima.Executar },
                 {"Delegates como Parametros - Metodos E Funções ",DelegatesComoParametros.Executar },
                 {"Metodos de Extensão - Metodos E Funções ",MetodosDeExtensao.Executar },
                
                
                // Exceçoes
                {"Primeira Exceção - Exceções ",PrimeiraExcecao.Executar },
                {"ExcecoesPersonalizadas - Exceções ",ExcecoesPersonalizadas.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}