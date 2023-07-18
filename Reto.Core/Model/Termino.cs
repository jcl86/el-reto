using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Reto.Core.Model
{
    [Table("Terminos")]
    public class Termino
    {
        public Termino(int id, string nombre, string definicion, TipoTermino tipo)
        {
            Id = id;
            Nombre = nombre;
            Definicion = definicion;
            Tipo = tipo;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(800)]
        public string Definicion { get; set; }

        public TipoTermino Tipo { get; set; }

        public string Iniciales() => Nombre.Iniciales();

        public bool Comprobar(string texto) => Nombre.CompararTexto(texto);


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Termino)obj).Id == Id;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
