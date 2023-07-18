using Reto.Core.Model;
using Reto.Data;
using Reto.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto.Forms.Views
{
    public partial class FrmPrincipal : Form
    {
        private readonly int numPalabras = 6;
        private int iTermino;
        private List<Termino> Terminos;
        private IEnumerable<UcInicial> Iniciales => FlpIniciales.Controls.OfType<UcInicial>();

        private bool ayuda = true;

        public FrmPrincipal()
        {
            InitializeComponent();
            Inicializar();
            NextTermino();
        }

        private void Inicializar()
        {
            iTermino = -1;

            Terminos = Repository.GetTerminos(numPalabras).ToList();
            int i = 0;
            foreach (var termino in Terminos)
            {
                (FlpIniciales.Controls[i] as UcInicial).Inicializar(termino);
                i++;
            }
            Terminos = Terminos.Desordenar();
        }

        private void TbxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var inicial in Iniciales)
                {
                    if (inicial.Intentar(Tbx.Text.Trim()))
                    {
                        NextTermino();
                        Tbx.Text = "";
                    }
                }
                return;
            }

            if (e.KeyCode == Keys.Space)
            {
                NextTermino();
                return;
            }
        }

        private void NextTermino()
        {
            iTermino = iTermino == numPalabras - 1 ? 0 : iTermino + 1;
            var termino = Terminos[iTermino];
            Definicion.Titulo = termino.Definicion;

            if (ayuda)
            {
                foreach (var inicial in Iniciales)
                    inicial.MostrarAyudaParaTermino(termino);
            }
        }


    }
}
