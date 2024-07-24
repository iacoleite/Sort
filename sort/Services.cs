namespace Calcola
{

    public class Calcolatore
    {
        private int number1;

        public Calcolatore()
        {}
        public Calcolatore(int num1)
        {
            this.number1 = num1;
        }

        public override string ToString()
        {
            return this.number1.ToString();
        }

        // public override bool Equals(object? obj)
        // {
        //     if (obj == null || GetType() != obj.GetType()) {
        //         return false;
        //     }
        //     else {
        //         Calcolatore t;
        //     }
        // }

        public static Calcolatore operator -(Calcolatore c1)
        {
            c1.number1 *= -1;
            return c1;
        }

        
        public int getNumber1() {
            if (this.number1 >= 0) {
                return this.number1;
            } else {
                return 0;
            }
        }

        public void setNumber1(int n) {
            if (this.number1 != 0){ 
                this.number1 = n;
            } else {
                this.number1 = 10000;
            }
        }
    }
}