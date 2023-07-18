using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reto.Core.Model;
using Reto.Core;

namespace Reto.Forms.UserControls
{
    public partial class UcInicial : UserControl
    {
        private Termino termino;
        public bool Acertado { get; set; }
        public int Intentos { get; private set; }

        public UcInicial()
        {
            InitializeComponent();
        }

        public void Inicializar(Termino termino)
        {
            this.termino = termino;
            LblInicial.Text = termino.Iniciales().ToUpper();
            Acertado = false;
            Intentos = 0;
            PbxIcon.Visible = false;
        }

        public void MostrarAyudaParaTermino(Termino t) => PbxIcon.Visible = t.Equals(termino);

        public bool Intentar(string texto)
        {
            if (texto.Iniciales().Equals(termino.Iniciales()))
                Intentos++;

            if (termino.Comprobar(texto))
            {
                Acertado = true;
                Visible = false;
                return true;
            }
            return false;
        }
    }
}
