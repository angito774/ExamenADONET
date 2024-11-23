using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenADONET
{
	internal class ProductoEN
	{
		public string Nombre { get; set; } = string.Empty;
		public decimal Precio { get; set; }
		public int Stock { get; set; }
		public DateTime FechaCreacion { get; set; }
	}
}
