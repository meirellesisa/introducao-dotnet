
Console.WriteLine("Primeira Aula");

// Declarando constantes gerais para exemplos
const int numero1 = 1;
const int numero2 = 2;

#region Declarando variáveis em C#
/*
int idade = 12;
Console.WriteLine(idade);

string nomePessoa = "Maria";
Console.WriteLine(nomePessoa);

decimal valor = 200.99m;
Console.WriteLine(valor);

double altura = 1.75;
Console.WriteLine(altura);

float peso = 70.5f;
Console.WriteLine(peso);

var cidade = "São Paulo";
Console.WriteLine(cidade);

var idadePessoa = 33;
Console.WriteLine(idadePessoa);

var flag = 'A';
Console.WriteLine(flag);

bool ativo = false;
Console.WriteLine(ativo);
*/
#endregion

#region Declarando constantes em C#
/*
var ativo = false; // Variável que pode ser alterada
const string descricao = "Curso de C# Básico";
Console.WriteLine(descricao);

ativo = true;

//descricao = "Curso de C# Avançado";
//-> erro ao tentar modificar uma constante
//   pois uma constante diferente de uma variál não pode ser alterada
*/
#endregion

#region Declarando comentários em C#
// Comentário de uma linha  
/*
 Comentário 
 de 
 múltiplas
 linhas
*/
#endregion

#region Declarando Operadores Aritméticos em C#
/*
Console.WriteLine("Operadores Aritméticos");

var soma = 4 + 2;
Console.WriteLine(soma);

var somaDosValores = numero1 + numero2;
Console.WriteLine(somaDosValores);

var subtracao = numero2 - numero1 ;
Console.WriteLine(subtracao);

int multiplicacao = numero1 * numero2;
Console.WriteLine(multiplicacao);

var divisao = numero2 / numero1;
Console.WriteLine(divisao);

var somaDosValores2 = (numero1 + numero2) * 10;
Console.WriteLine(somaDosValores2);
*/
#endregion

#region Declarando Operadores de Relacionais em C#
/*
Console.WriteLine("Operadores de Relacionais");
var igual = numero1 == numero2;
Console.WriteLine(igual);

var maior = numero2 > numero1;
Console.WriteLine(maior);

var menor = numero1 < numero2;
Console.WriteLine(menor);

var menorOuIgual = numero1 <= numero2;
Console.WriteLine(menorOuIgual);

var maiorOuIgual = numero1 >= numero2;
Console.WriteLine(maiorOuIgual);

var diferente = numero1 != numero2;
Console.WriteLine(diferente);
*/
#endregion

#region Declarando Operadores Lógicos em C#
/*
Console.WriteLine("Operadores Lógicos");

var valido = numero2 > numero1 && 8 > 7; // AND
Console.WriteLine(valido);


var valido2 = numero2 > numero1 && 6 > 7; // AND
Console.WriteLine(valido2);

bool operadorOu = numero2 > numero1 || 6 > 7; // OR
Console.WriteLine(operadorOu);

bool operadorOu2 = numero2 < numero1 || 6 > 7; // OR
Console.WriteLine(operadorOu2);

bool operadorDeNegacao = !(numero2 > 10);
Console.WriteLine(operadorDeNegacao);
*/
#endregion

#region Declarando Operadores Ternários em C#
/*
Console.WriteLine("Operadores Ternários");

bool ativo = false;

string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";
Console.WriteLine(status);

string status2 = !ativo ? "Cadastro Ativo" : "Cadastro inativo";
Console.WriteLine(status2);
*/
#endregion

#region Declarando Funções sem parâmetros em C#
/*
Console.WriteLine("Declarando funções no C#");

string NomeCompleto()
{
    return "João da Silva";
};

var NomeUsuario = NomeCompleto();
Console.WriteLine(NomeUsuario);

var ativo = true;

int Soma()
{
    return numero1 + numero2;
};

var resultadoSoma = Soma();
Console.WriteLine(resultadoSoma);

void DesativarCadastro()
{
    ativo = false;
};

DesativarCadastro();

Console.WriteLine(ativo);
*/
#endregion

#region Declarando Funções com parâmetros em C#
/*
string NomeCompleto2(string nome, string segundoNome)
{
    return nome + " " + segundoNome;
};

var nomeCompleto = NomeCompleto2("Isabella", "Meirelles");

Console.WriteLine(nomeCompleto);

// Essa função multiplica dois valores 
int Multiplicar(int numero1, int numero2)
{
    return numero1 * numero2;
};

var resultadoDaMultiplicacao = Multiplicar(numero1, numero2);
Console.WriteLine(resultadoDaMultiplicacao);

var resultadoDaMultiplicacao2 = Multiplicar(10, 8);
Console.WriteLine(resultadoDaMultiplicacao2);

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos.";
};

var nomeEIdade = NomeEIdade("Maria", 30);
Console.WriteLine(nomeEIdade);
*/
#endregion

#region Declarando Função com Validação de Parâmetro

// Não se atente a isso pois é a resposta de uma pergunta 
// feita em aula mas que usa pontos que não vimos ainda como:
// estruturas de controle (if),
// funções de string(IsNullOrEmpty) 

/*

 string Usuario(string nome)
{   // condição ? se for verdadeiro : se for falso
    var nomeValido = string.IsNullOrEmpty(nome)
        ? "Nome é obrigatório" 
        : nome;

    return nomeValido;
};

var usuario = Usuario("João");
Console.WriteLine(usuario);

var usuario2 = Usuario("");
Console.WriteLine(usuario2);
*/
#endregion
