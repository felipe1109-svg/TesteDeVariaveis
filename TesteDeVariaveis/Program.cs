// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace TesteDeVariaveis
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Olá, Mundo!");// Mensagem inicial com quebra de linha
            Console.WriteLine("Teste de Variaveis");// Título do programa
            string nome = "Felipe";// Alterado para o meu nome
            int idade = 29;// Alterado para a minha idade
            float float1= 71.5f;// Alterado para o meu peso (4bit)
            double double1= 1.75;// Alterado para a minha altura (8bit)
            decimal decimal1= 950.50m;// Valor decimal de exemplo (16bit)
            Console.WriteLine($"Meu nome é {nome}, minha idade é {idade} anos, meu peso é {float1} Kg e minha altura é {double1} metros");
            Console.WriteLine($"Exemplo de valor decimal: R$ {decimal1}");// Exemplo de valor decimal, geralmente usado em valores de dinheiro
            bool isAdult = idade >= 18;// Verifica se a pessoa é maior de idade
            Console.WriteLine($"Sou maior de idade? {isAdult}");// Exibe se a pessoa é maior de idade
            char letraInicial = nome[0];// Pega a primeira letra do nome (permite caracteres únicos)
            Console.WriteLine($"A primeira letra do meu nome é: {letraInicial}");// Exibe a primeira letra do nome
            var cidade = "Itaquaquecetuba";// Usando variável para inferência de tipo
            Console.WriteLine($"Eu moro na cidade: {cidade}");// Exibe a cidade
            const string estado = "São Paulo";// Constante para o estado
            Console.WriteLine($"No estado de: {estado} ");// Exibe o estado
            const string pais = "Brasil";// Constante para o país
            Console.WriteLine($"No país: {pais}");// Exibe o país
            var salarioMensal = 2314.00m;// Variável para o salário mensal
            Console.WriteLine($"Meu salário mensal é: R$ {salarioMensal}");// Exibe o salário mensal
            dynamic variavelDinamica = "salário líquido R$ 1990,00";// Variável dinâmica
            Console.WriteLine($"Valor dinâmico inicial: {variavelDinamica}");// Exibe o valor inicial
            variavelDinamica = 100;// Alterando para um inteiro
            Console.WriteLine($"Valor dinâmico alterado: {variavelDinamica}");// Exibe o valor alterado
            int num1 = 10;// Primeiro número para operação
            int num2 = 20;// Segundo número para operação
            int soma = num1 + num2;// Soma dos dois números
            Console.WriteLine($"A soma de {num1} + {num2} = {soma}");// Exibe o resultado da soma
            int subtracao = num1 - num2;// Subtração dos dois números
            Console.WriteLine($"A subtração de {num1} - {num2} = {subtracao}");// Exibe o resultado da subtração
            int multiplicacao = num1 * num2;// Multiplicação dos dois números
            Console.WriteLine($"A multiplicação de {num1} * {num2} = {multiplicacao}");// Exibe o resultado da multiplicação
            double divisao = (double)num2 / num1;// Divisão dos dois números
            Console.WriteLine($"A divisão de {num2} / {num1} = {divisao}");// Exibe o resultado da divisão
            int modulo = num2 % num1;// Módulo dos dois números
            Console.WriteLine($"O módulo de {num2} % {num1} = {modulo}");// Exibe o resultado do módulo
            int incremento = ++num1;// Incremento do primeiro número sabe-se que agora num1 vale 11 (10 + 1)
            Console.WriteLine($"O incremento de num1 é: {incremento}");// Exibe o valor após o incremento sabendo que num2 agora vale 19 (20 - 1)
            int decremento = --num2;// Decremento do segundo número
            Console.WriteLine($"O decremento de num2 é: {decremento}");// Exibe o valor após o decremento
            Console.WriteLine("Fim do programa.");// Indica o fim do programa
            int num3 = 10;// Número no nome da variável (inválido)
            int num4 = 33;// Número com nome da variável (válido)
            int num5 = num3 + num4;// Soma de num3 e num4
            int num6 = 33;// Número nome da variável (válido)
            Console.WriteLine($"num3: {num3}, num4: {num4}, num5: {num3 + num4}, num6: {num6}");// Exibe os valores de num3 e num4

            if (num6 == num4)
            {
                Console.WriteLine("num6 é igual a num4");// Verifica se num6 é igual a num4
            }
            if(num3 != num4)
            {
                Console.WriteLine("num3 é diferente de num4");// Verifica se num3 é diferente de num4
            }
            if(num5 > num4)
            {
                Console.WriteLine("num5 é maior que num4");// Verifica se num5 é maior que num4
            }
            if(num3 < num4)
            {
                Console.WriteLine("num3 é menor que num4");// Verifica se num3 é menor que num4
            }
            if(num5 >= num4)
            {
                Console.WriteLine("num5 é maior ou igual a num4");
            }
            if(num3 <= num4)
            {
                Console.WriteLine("num3 é menor ou igual a num4");// Verifica se num3 é menor ou igual a num4
            }
            bool booleana1 = true;
            bool booleana2 = true;
            bool booleana3 = false;
            if (booleana1 && booleana2)
            {
                Console.WriteLine("booleana1 E booleana2 é verdadeira");// Verifica se ambas as booleanas são verdadeiras
            }
            if (booleana1 || booleana2)
            {
                Console.WriteLine("booleana1 OU booleana2 é verdadeira");// Verifica se pelo menos uma das booleanas é verdadeira

            }
            if (!booleana3)
            {
                Console.WriteLine("operador de negação");// Verifica se booleana3 é falsa
            }
            void Saudacao(string nome1, string nome2)
            {
                Console.WriteLine($"Olá, {nome1} ou {nome2}! Bem-vindo ao programa de teste de variáveis, estamos verificando sua idade...");// Função para saudar a pessoa pelo nome
            }
            Saudacao("Marcelo", "IuEnergizer");// Chama a função de saudação com o nome fornecido
            int Idade = 26;// Variável para idade

            if (Idade >= 18)
            {
                Console.WriteLine("Adulto");// Verifica se a pessoa é maior de idade
            }

            else
            {
                Console.WriteLine("Menor de idade");// Verifica se a pessoa é menor de idade
            }
            string cor = "vermelho";// Variável para cor
            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("A cor é vermelho");// Caso a cor seja vermelho
                    break;
                case "azul":
                    Console.WriteLine("A cor é azul");// Caso a cor seja azul
                    break;
                case "verde":
                    Console.WriteLine("A cor é verde");// Caso a cor seja verde
                    break;
                default:
                    Console.WriteLine("Cor não reconhecida");// Caso a cor não seja nenhuma das anteriores
                    break;
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Contagem: {i}");// Loop para contar de 1 a 5
            }
            int j = 0;
            do
            {
                Console.WriteLine("Executado pelo menos uma vez");// Loop do while para contar de 0 a 4
                j++;
            } while (j <= 5);
            int k = 0;
            while (k <= 5)
            {
                Console.WriteLine($"Contagem no while: {k}");// Loop while para contar de 0 a 5
                k++;
            }
            string[] frutas = { "Maçã", "Banana", "Laranja", "uva"};// Array de frutas
            foreach (string fruta in frutas)
            {
                Console.WriteLine($"Fruta: {fruta}");// Loop foreach(indice) para exibir cada fruta no array
            }
            Console.WriteLine(frutas[1]);// Acessa o segundo elemento do array (Banana) lembrando q 0 é o primeiro
            Console.WriteLine(frutas.Length);// Exibe o tamanho do array de frutas
        }
    }
}