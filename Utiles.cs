using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenADONET
{
	internal static class Utiles
	{
		static bool permitir = true;		

		public static bool solonumeros(TextBox txt, int code)
		{
			bool resultado;

			if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
			{
				resultado = true;
			}
			else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
			{
				resultado = false;
			}
			else if (!permitir)
			{
				resultado = permitir;
			}
			else
			{
				resultado = true;
			}

			return resultado;

		}
	}
}
