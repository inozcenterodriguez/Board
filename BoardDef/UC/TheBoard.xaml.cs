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
        int PlacesCounter = 0;
       public int Actualplace=0;

        public TheBoard()
        {
            InitializeComponent();
            ChangeBackground("/Images/ImageBoard.png");
            ChangeSize(CanvasOne, 600, 600);
            ChangeSize(Canvas2, 200, 300);
            ChangeSize(Canvas3, 200, 300);
            Canvas2.Children.Add(DadoActual);


            //ADD PLACES

            AddPlace(PlacesCounter  + 1, 0, 150,false,true);
             


        }



        public void AddPlace(int id,double xleft, double xtop,bool cas,bool pow)
        {

            
            GamePlace GP = new GamePlace(id,cas,pow);
            CanvasOne.Children.Add(GP);
            Canvas.SetLeft(GP,xleft);
            Canvas.SetTop(GP, xtop);
            PlacesCounter = PlacesCounter + 1;


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

        public void FichaToPlace(int placeindex)
        {
            foreach (GamePlace GP  in this.CanvasOne.Children)
            {
                if(GP.Placeindex == placeindex)
                {
                    GP.pawn1.Visibility = Visibility.Visible;


                }
            }
        }


    }
}
