using System;
using System.Security.Cryptography;

namespace Lab4
{
    public class Trapeze
    {
        private int[] a = new int[2]{0, 0};
        private int[] b = new int[2]{0,0};
        private int[] c = new int[2]{0,0};
        private int[] d = new int[2]{0,0};
        
        public Trapeze(int[] x, int[] y, int[] z, int[] f)
        {
            for (int i = 0; i < 2; i++)
            {
                this.a[i] = x[i];
                this.b[i] = y[i];
                this.c[i] = z[i];
                this.d[i] = f[i];    
            }
            
        }
        
        public Trapeze()
        {
            var rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                this.a[i] = rnd.Next(0, 100);
                this.b[i] = rnd.Next(0, 100);
                if (i == 0)
                {
                    this.c[i] = rnd.Next(Math.Min(this.a[i], this.b[i]), Math.Max(this.a[i], this.b[i]));
                    this.d[i] = rnd.Next(Math.Min(this.a[i], this.b[i]), Math.Max(this.a[i], this.b[i]));    
                }
                else
                {
                    this.c[i] = rnd.Next(0, 100);
                    this.d[i] = ((d[0] - c[0])*(b[1]-a[1]))/(b[0]-a[0]) + b[1];
                }
                    
            }
            
        }

        public Trapeze(string type)
        {
            if (type == "sameside")
            {
                var rnd = new Random();
                for (int i = 0; i < 2; i++)
                {
                    this.a[i] = rnd.Next(0, 100);
                    this.b[i] = rnd.Next(0, 100);
                    if (i == 0)
                    {
                        this.c[i] = rnd.Next(Math.Min(this.a[i], this.b[i]), Math.Max(this.a[i], this.b[i]));
                        this.d[i] = rnd.Next(Math.Min(this.c[i], this.b[i]), Math.Max(this.c[i], this.b[i]));    
                    }
                    else
                    {
                        this.c[i] = rnd.Next(0, 100);
                        this.d[i] = (b[i] * c[i]) / a[i];
                    }
                    
                }   
            }
            else
            {
                Trapeze temp = new Trapeze();
                this.a = temp.a;
                this.b = temp.b;
                this.c = temp.c;
                this.d = temp.d;
            }
            
            
        }

        public int[] A { get { return a; } set {a = value;} }
        public int[] B { get { return b; } set {b = value;} }
        public int[] C { get { return c; } set {c = value;} }
        public int[] D { get { return d; } set {d = value;} }


        public static Trapeze operator-(Trapeze trap, int y)
        {
            Trapeze temp = new Trapeze();
            for (int i = 0; i < 2; i++)
            {
                temp.a[i] = trap.a[i] - y;
                temp.b[i] = trap.b[i] - y;
                temp.c[i] = trap.c[i] - y;
                temp.d[i] = trap.d[i] - y;    
            }
            
            return temp;
        }


        public void PrintCoord()
        {
            Console.WriteLine("{0}, {1}", this.A[0], this.A[1]);
            Console.WriteLine("{0}, {1}", this.B[0], this.B[1]);
            Console.WriteLine("{0}, {1}", this.C[0], this.C[1]);
            Console.WriteLine("{0}, {1}", this.D[0], this.D[1]);
        }


        public static double operator *(Trapeze tr1, Trapeze tr2)
        {
            return Math.Round(tr1.GetSquare()*tr2.GetSquare(), 2);
        }


        public double GetSquare()
        {
            double h_s = Math.Sqrt((this.c[0] - this.c[1]) ^ 2 + (this.d[0] - this.d[1]) ^ 2);
            double l_s = Math.Sqrt((this.a[0] - this.a[1]) ^ 2 + (this.b[0] - this.b[1]) ^ 2);
            double m_l = (h_s + l_s) / 2;
            double h = Math.Abs(this.a[1] - this.c[1]);
            return Math.Round(m_l * h, 2);
        }
        
        public static implicit operator Trapeze(double x)
        {
            Trapeze temp = new Trapeze();
            for (int i = 0; i < 2; i++)
            {
                temp.a[i] = Convert.ToInt32(x);
                temp.b[i] = Convert.ToInt32(x);
                temp.c[i] = Convert.ToInt32(x);
                temp.d[i] = Convert.ToInt32(x);
            }

            return temp;
        }
    }
    
    
       
}
