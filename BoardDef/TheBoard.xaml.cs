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
    public partial class TheBoard : UserControl
    {
        ImageBrush BackPng = new ImageBrush();
        Dados DadoActual = new Dados();



        public TheBoard()
        {
            InitializeComponent();
            ChangeBackground("/Images/ImageBoard.png");
            ChangeSize(CanvasOne, 600, 600);
            ChangeSize(Canvas2, 200, 300);
            ChangeSize(Canvas3, 200, 300);


            Canvas2.Children.Add( DadoActual );


        }

        public void  ChangeBackground(string X_url)
        {
            
            MCutilities.PNGToImageBRush(X_url, BackPng);
            CanvasOne.Background = BackPng;
            

        }

        public void ChangeSize(Canvas canvas,float W ,float H)
        {
            canvas.Width = W;
            canvas.Height = H;
            
        }

        public void TurnLeft()
        {


            SimpleJob SJ = new SimpleJob();
            CanvasOne.RenderTransform = SJ.RotateUI(CanvasOne, -90);
        }


        public void TurnRight()
        {
            SimpleJob SJ = new SimpleJob();
            CanvasOne.RenderTransform = SJ.RotateUI(CanvasOne, 90);


        }




    }
}
