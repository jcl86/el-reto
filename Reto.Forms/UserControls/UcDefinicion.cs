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
    public partial class UcDefinicion : UserControl
    {
        public string Titulo
        {
            get => LblDefinicion.Text;
            set => LblDefinicion.Text = value;
        }

        public Image Fondo
        {
            get => pPrincipal.BackgroundImage;
            set => pPrincipal.BackgroundImage = value;
        }

        public UcDefinicion()
        {
            InitializeComponent();
        }
    }
}
