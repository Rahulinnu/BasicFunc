using System;

namespace BasicFunc
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            FlipCoin flip = new FlipCoin();
            flip.CalcFlipCoin();

            LeapYear leap = new LeapYear();
            leap.CalcLeapYear();

            PowerOfTwo pot1 = new PowerOfTwo();
            pot1.Pot();

            HarmonicNumber hm = new HarmonicNumber();
            hm.HaNu();

            Factors fa = new Factors();
            fa.Fact();

            QuotientRemainder qr = new QuotientRemainder();
            qr.QuRe();

            SwapNumbers sn = new SwapNumbers();
            sn.SwNu();

            EvenOrOdd eo = new EvenOrOdd();
            eo.EvOd();

            AlphaCons ac = new AlphaCons();
            ac.EvOd();

            LargestThree lt = new LargestThree();
            lt.LaTh();





        }

    }
}
