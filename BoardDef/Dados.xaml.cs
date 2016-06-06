using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MC_Structures;
using MC_Utilities;

namespace BoardDef
{
    public partial class Dados : UserControl
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LanzarDados Lanzar = new LanzarDados(1,6);
            NumeroDado.Text = Lanzar.StartDados().ToString();

           
        }
             
    }
}
