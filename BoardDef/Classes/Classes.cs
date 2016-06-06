using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;

namespace MC_Utilities 
{
    public static  class MCutilities
    {
        public static void PNGToImageBRush(string Xurl , ImageBrush Ximage)
        {

            Ximage.ImageSource =new BitmapImage(new Uri(Xurl, UriKind.Relative));

        }

       

    }




    public class SimpleJob
    {


        public RotateTransform RotateUI(FrameworkElement element,double angle   )
        {
            
            double CY;
            double CX;
            RotateTransform RT = new RotateTransform();
            RT.Angle = angle;
            element.UpdateLayout();
            
            CX = element.Width / 2;
            CY= element.Height/ 2;
            RT.CenterX = CX;
            RT.CenterY = CY;
            MessageBox.Show(element.Width.ToString());
            return (RT);




        }


       





    }




    public class LanzarDados
    {
        int xmin;
        int xmax;
        Random rd = new Random();


        public LanzarDados(int min, int max)
        {

            
            xmin = min;
            xmax = max;


        }

        public int StartDados()
        {
           
            return (rd.Next(xmin, xmax));


        }
    }


}
