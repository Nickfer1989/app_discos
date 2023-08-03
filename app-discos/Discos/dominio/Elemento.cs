using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
        public string Estilo { get; set; }
        public string TipoEdicion { get; set; }

    }
}
