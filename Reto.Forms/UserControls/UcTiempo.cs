using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto.Forms.UserControls
{
    public partial class UcTiempo : UserControl
    {
        private int segundos;
        public Action TiempoFinalizado { get; set; }

        public UcTiempo()
        {
            InitializeComponent();
        }

        public void IniciarCrono(int segundos)
        {
            if (timerSegundos.Enabled)
                timerSegundos.Stop();

            this.segundos = segundos;
            LblSegundos.Text = segundos.ToString();
            timerSegundos.Start();
        }

        public void DetenerCrono() => timerSegundos.Stop();

        private void TimerSegundosTick(object sender, EventArgs e)
        {
            segundos--;
            LblSegundos.Text = (segundos < 10 ? "0" : "") + segundos.ToString();
            if (segundos <= 0)
            {
                TiempoFinalizado.Invoke();
                timerSegundos.Stop();
            }
        }
    }
}
