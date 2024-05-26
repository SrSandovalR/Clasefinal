using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clasefinal.Data.DataAcces
{
    internal class model
    {
        public int Id_ { get; set; } 
        public string nombre_consola_ { get; set; }
        public string compania_ { get; set; }
        public int generacion_ { get; set; }
        public DateTime anio_lanzamiento_ { get; set; }

           public model()
        {
        }

        public model(int id, string nombre_consola, string compania, int generacion, DateTime anio_lanzamiento)
        {
            Id_ = id;
            nombre_consola_ = nombre_consola;
            compania_ = compania;
            generacion_ = generacion;
            anio_lanzamiento_ = anio_lanzamiento;
            
        }

       
    }
}
