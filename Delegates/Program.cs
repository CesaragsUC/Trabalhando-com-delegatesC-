
using Delegates;

//https://learn.microsoft.com/en-us/dotnet/standard/events/
#region Exemplo 1: Evento Sem dados


//Pessoa c = new Pessoa();

////se inscreve no evento e fica escutando
////se atender alguma logica então ele sera chamado depois
//c.PessoaMaiorIdade += c_ResultadoPesquisa;

//Console.WriteLine("Digite a sua idade");
//var valor = Console.ReadLine();
//c.VerificarIdade(Convert.ToInt32(valor));



//void c_ResultadoPesquisa(object sender, EventArgs e)
//{
//    Console.WriteLine("Maior de idade.");
//    Environment.Exit(0);
//}

#endregion

//https://learn.microsoft.com/en-us/dotnet/standard/events/how-to-raise-and-consume-events
#region Exemplo 2: Evento com dados

var user = new Usuario();

//se inscreve no evento e fica escutando
//se atender alguma logica então ele sera chamado depois
user.UsuarioCadastro += c_UsuarioRegistrado;

var userRegistro = new UsuarioCadastradaEventHandler 
{ 
    Nome = "Cesar Augusto Gadelha Santos",
    Cpf = "45307214340", // testar cpf invalido 4530721430 cpf valido 45307214340
    Idade = 36
};
user.UsuarioCadastrado(userRegistro);

void c_UsuarioRegistrado(object sender, UsuarioCadastradaEventHandler e)
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine($"O cliente {e.Nome} com idade {e.Idade}, foi registrado na data de {e.CreateAt}.");
    Console.ResetColor();
    Environment.Exit(0);
}
#endregion
