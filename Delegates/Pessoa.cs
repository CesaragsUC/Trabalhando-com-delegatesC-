using System;

namespace Delegates
{
    public class Pessoa
    {

        public event EventHandler PessoaMaiorIdade;
        public void VerificarIdade(int idade)
        {
            if (idade >= 18)
            {
                PessoaMaiorIdade?.Invoke(this, EventArgs.Empty);
            }
        }

    }

    public class UsuarioCadastradaEventHandler : EventArgs
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public int Idade { get; set; }
        public DateTime CreateAt { get; set; } =  DateTime.Now;
    }
}
