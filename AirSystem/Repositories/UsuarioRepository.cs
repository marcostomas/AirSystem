using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;
        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();
                usuarios.Add(new Usuario
                {
                    admin = true,
                    ID = 1,
                    name = "Marcos",
                    surname = "Tomás",
                    address = "Alameda Barão de Limeira",
                    address2 = "589",
                    username = "marcos",
                    password = "1234"
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    admin = true,
                    ID = 2,
                    name = "Admin",
                    surname = "Do Sistema",
                    address = "Alameda Barão de Limeira",
                    address2 = "589",
                    username = "ademir",
                    password = "admin"
                }
                );
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.ID = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.ID == usuario.ID);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int ID)
        {
            Usuario usuario = usuarios.Find(x => x.ID == ID);

            usuarios.Remove(usuario);
        }
    }
}
