using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CodeWars._6kyu
{
    public class Braking
    {
       
        public void Solve()
        {
            var d = 144;
            var mu = 0.3;
           var v =  Dist(d,mu);
           var result = Speed(v,mu);

            Console.WriteLine(result);

        }
        

        public static double Dist(double v, double mu)        // suppose reaction time is 1
        {
            var g = 9.81;
            var VeloctiyinMSS = (v * 5 / 18)  ;

            var d1 = (Math.Pow(VeloctiyinMSS, 2)  / (2 * mu * g) ) + VeloctiyinMSS ;
            //r  = reaction time  = 1;
            return d1;
        }

      

        public static double Speed(double d, double mu)       // suppose reaction time is 1
        {
           // //distance/time
           // var gravity = 9.81;
           // var t = gravity * mu * 2;
           // var x = "Math.Pow(VeloctiyinMSS, 2)";
            
           //var s = ( / t) + VMSS

           // d1- VMSS = x/t
           //     t * (d1 - vmss) = x
           //     spedd root(x) *5/18
               

           // var t = (2 * mu * gravity);
           // var time = d /  ;
           // var speed = d / time -1;

          
           
            return  0.0;
        }

       

    }
}
