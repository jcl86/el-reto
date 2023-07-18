using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Core
{
    public static class StringHelper
    {
        public static string Iniciales(this string texto)
        {
            if (texto.IsEmpty()) return "";
            if (texto.Count() < 3) return texto;
            return texto.Substring(0, 3);
        }

        public static bool CompararTexto(this string texto1, string texto2)
        {
            if (texto1.IsEmpty() && texto2.IsEmpty()) return true;
            if (texto1.IsEmpty() || texto2.IsEmpty()) return false;

            return texto1.Limpiar().Equals(texto2.Limpiar());
        }

        public static string Limpiar(this string texto)
        {
            if (texto.IsEmpty()) return "";
            return texto.Trim().ToLower().Replace('á', 'a')
                .Replace('é', 'e')
                .Replace('í', 'i')
                .Replace('ó', 'o')
                .Replace('ú', 'u');
        }

        public static bool IsEmpty(this string texto) => string.IsNullOrWhiteSpace(texto);
    }
}
