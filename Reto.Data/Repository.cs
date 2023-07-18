using Reto.Core;
using Reto.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reto.Data
{
    public static class Repository
    {
        public static IEnumerable<Termino> GetTerminos(int numero)
        {
            foreach (var (id, palabra, definicion) in Data.DataCreator.GetPalabrasRaras().ElementosAleatorios(numero).ToList())
                yield return new Termino(id, palabra, definicion, TipoTermino.Rara);
        }
    }
}
