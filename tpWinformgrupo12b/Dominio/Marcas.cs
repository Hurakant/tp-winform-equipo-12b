using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpWinformgrupo12b
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        // Sobreescribimos para que los ComboBox muestren el nombre y no la ruta del objeto
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
