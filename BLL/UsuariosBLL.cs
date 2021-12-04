using CondominioADM.DAL;
using CondominioADM.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios Usuario)
        {
            if (!Existe(Usuario.UsuarioId))
                return Insertar(Usuario);
            else
                return Modificar(Usuario);
        }

        private static bool Insertar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Usuario.Clave = GetSHA256(Usuario.Clave);
                if (contexto.Usuarios.Add(Usuario) != null)
                    paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Usuario.Clave = GetSHA256(Usuario.Clave);

            try
            {
                contexto.Entry(Usuario).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuario = UsuariosBLL.Buscar(id);

                if (usuario != null)
                {
                    contexto.Usuarios.Remove(usuario);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Usuarios usuario;
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return usuario;
        }


        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Usuarios.Any(x => x.UsuarioId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> Criterio)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Usuarios.Where(Criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static bool Validar(string email, string clave)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                paso = contexto.Usuarios
                    .Any(u => u.Email.Equals(email)
                                && u.Clave.Equals(GetSHA256(clave))
                          );
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Usuarios getUser(string email)
        {
            List<Usuarios> lista = new();
            Contexto contexto = new();
            Usuarios user = new();

            try
            {
                lista = contexto.Usuarios.ToList();

                foreach(var item in lista)
                {
                    if(item.Email == email)
                    {
                        user = item;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return user;
        }

        private static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
