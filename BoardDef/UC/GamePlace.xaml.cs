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

namespace BoardDef 
{
    public partial class GamePlace : UserControl
    {
       public  int Placeindex;
      public   bool CasualityCard = false;
       public  bool PowerCard = false;




        public GamePlace(int placeindex,bool cas,bool pow)
        {
            

            Placeindex = placeindex;
            CasualityCard = cas;
            PowerCard = pow;
            InitializeComponent();

            if (cas == true)
            {
                casualityeli.Visibility = Visibility.Visible;

            }

            if (pow == true)
            {
               powereli.Visibility = Visibility.Visible;

            }



        }
    }
}
