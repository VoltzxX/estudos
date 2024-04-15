using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;
        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }
        public  IEnumerable<T> Listar()
        {
            try
            {
                return context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<T>();
            }
        }
        public void Adicionar(T objeto)
        {
            try
            {
                context.Set<T>().Add(objeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Atualizar(T objeto)
        {
            try
            {
                context.Set<T>().Update(objeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Deletar(T objeto)
        {
            try
            {
                context.Set<T>().Remove(objeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public T? ProcurarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }
        public IEnumerable<T> ListarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao);
        }

    }
}
