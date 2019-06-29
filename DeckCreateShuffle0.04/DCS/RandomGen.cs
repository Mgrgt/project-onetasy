using System.Security.Cryptography;

namespace DCS004
{
    class RandomGen
    {//my random generator
        public static byte RNCryp(byte Param1)
        {
            byte[] MyRN = new byte[1];

            MyRN[0] = Param1++;

            do
            {
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(MyRN);
                }
            }
            while (MyRN[0] >= Param1);

            return (MyRN[0]);
        }
    }
}
