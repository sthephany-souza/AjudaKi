namespace ProjetoVaquinha.Models{
    public static class RepositorioRegistrar
    {
        private static List<Registro> registros = new List<Registro>()
        {
            new Registro {
                Id = 1, 
                Nome = "José da Silva",
                Email = "jose@gmail.com",
                CPF = 12345678900,
                Senha = "jose123",
                ConfSenha = "jose123"
            },

            new Registro {
                Id = 2,
                Nome = "Marta Rodrigues",
                Email = "marta@gmail.com",
                CPF = 12345678911,
                Senha = "marta789",
                ConfSenha = "marta789"
            }        
        };
        

        public static IEnumerable<Registro> Registros => registros;

        public static int AdicionarUsuario(Registro registro)
        {
            registro.Id = registros.Max(n => n.Id) + 1;
            registros.Add(registro);

            return registro.Id;
        }

        public static void RemoverUsuario(int Id)
        {
            var registro = registros.FirstOrDefault(n=> n.Id == Id);

            if(registro != null)
            {
                registros.Remove(registro);
            }
        }
    }
}