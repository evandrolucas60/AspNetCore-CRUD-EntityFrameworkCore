using ProjetoCrudMvc.Models;
using System.Linq;

namespace ProjetoCrudMvc.Data
{
    //uma classe para inserir dados quando o
    //modelo for inicializado e a base de dados for criada.

    //A criação da base de dados é dada quando o
    //método EnsureCreated() é invocado.Inicialmente, é verificado
    //se existe algum objeto/registro em Departamentos via LINQ.

    public class IESDbInitializer
    {

        private IESContext _context;

        public IESDbInitializer(IESContext context)
        {
            _context = context;
        }
        public void Initializer()
        {

            if (_context.Departments.Any())
            {
                return;
            }
            var departments = new Department[]
            {
                 new Department {Name ="Computer Science"},
                 new Department {Name = "Food Engineer"},
                 new Department {Name = "Fashion"}
        };

            foreach (Department d in departments)
            {
                _context.Departments.Add(d);
            }
                        
            _context.SaveChanges();
        }
    }
}
