using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistLogin {
    class Cadastro {
        private static Usuario _logedUser = null;

        public static Usuario LogedUser {
            get { return _logedUser; }
            private set { _logedUser = value; }
        }

        private static Usuario[] usuarios = {
            new Usuario(){Nome = "Ianael", Senha = "123456"},
            new Usuario(){Nome = "Gabriel", Senha = "abc123"},
            new Usuario(){Nome = "Danny", Senha = "123abc"},
            new Usuario(){Nome = "Arthur", Senha = "abcdef"}
        };

        public static bool Login(string name, string password) {
            foreach(Usuario user in usuarios) {
                if (name.Equals(user.Nome) && password.Equals(user.Senha)) {
                    LogedUser = user;
                    return true;
                }
            }

            return false;
        }
    }
}
