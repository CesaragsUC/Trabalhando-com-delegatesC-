namespace Delegates
{
    public class Usuario
    {

        public event EventHandler<UsuarioCadastradaEventHandler> UsuarioCadastro;
        public void UsuarioCadastrado(UsuarioCadastradaEventHandler usuario)
        {
            if (usuario.Idade >= 18 && ValidaCPF.IsValidCpf(usuario.Cpf))
            {
                OnRegistrarUsuario(usuario);
            }
        }

        protected virtual void OnRegistrarUsuario(UsuarioCadastradaEventHandler e)
        {
            var handler = UsuarioCadastro;

            if (handler != null)
                handler.Invoke(this, e);

        }
    }
}
