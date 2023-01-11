/* DESAFIO ARRAYS */

/* Escrever um programa que recebe um produto como argumento,
 * validar se esse produto está na lista de itens disponíveis do mercado.
 * Caso esteja, avisar se possui ou não e, por último, exibir a lista de
 * produtos disponíveis ordenados por ordem alfabética do mercado,
 * para que o usuário possa pedir na próxima vez. */

string mensagem = "";
string[] listaDeMercado = { "Tomate", "Carne", "Chocolate", "Leite", "Alface", "Pão", "Queijo", "Salame" };

try
{
    string produtoSelecionado;

    Console.WriteLine("Qual produto deseja comprar?");
    produtoSelecionado = Console.ReadLine();

    bool validaProduto = listaDeMercado.Where(l => l.ToLower().Equals(produtoSelecionado.ToLower())).Any();

    if (validaProduto)
    {
        mensagem = $"{produtoSelecionado} está disponível, pode comprar!";
    }
    else
    {
        mensagem = $"{produtoSelecionado} não está disponível no mercado no momento";
    }
}
catch (Exception ex)
{
    mensagem = $"Ocorreu o seguinte erro: {ex.Message}";
}
finally
{
    Console.WriteLine(mensagem);

    Console.WriteLine("Os produtos disponíveis para compra no momento são:");
    foreach (string produto in listaDeMercado.OrderBy(produto => produto))
    {
        Console.WriteLine($"{produto}");
    }
}