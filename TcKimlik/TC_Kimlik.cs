using System;

namespace TcKimlik
{
    public class Kimlik
    {
        public bool Dogrula(string tckimlik)
        {
            if (tckimlik.Length != 11) return false;
            var d11 = Convert.ToInt32(tckimlik[10].ToString());
            var d10 = Convert.ToInt32(tckimlik[9].ToString());
            var d9 = Convert.ToInt32(tckimlik[8].ToString());
            var d8 = Convert.ToInt32(tckimlik[7].ToString());
            var d7 = Convert.ToInt32(tckimlik[6].ToString());
            var d6 = Convert.ToInt32(tckimlik[5].ToString());
            var d5 = Convert.ToInt32(tckimlik[4].ToString());
            var d4 = Convert.ToInt32(tckimlik[3].ToString());
            var d3 = Convert.ToInt32(tckimlik[2].ToString());
            var d2 = Convert.ToInt32(tckimlik[1].ToString());
            var d1 = Convert.ToInt32(tckimlik[0].ToString());

            if (((((d1 + d3 + d5 + d7 + d9)*7) - (d2 + d4 + d6 + d8))%10) != d10) return false;
            return (d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10) % 10 == d11;
        }


        //public bool Dogrula(string tckimlik)
        //{
        //    bool returnvalue = false;
        //    if (tckimlik.Length == 11)
        //    {
        //        int D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11;
        //        D11 = Convert.ToInt32(tckimlik[10].ToString());
        //        D10 = Convert.ToInt32(tckimlik[9].ToString());
        //        D9 = Convert.ToInt32(tckimlik[8].ToString());
        //        D8 = Convert.ToInt32(tckimlik[7].ToString());
        //        D7 = Convert.ToInt32(tckimlik[6].ToString());
        //        D6 = Convert.ToInt32(tckimlik[5].ToString());
        //        D5 = Convert.ToInt32(tckimlik[4].ToString());
        //        D4 = Convert.ToInt32(tckimlik[3].ToString());
        //        D3 = Convert.ToInt32(tckimlik[2].ToString());
        //        D2 = Convert.ToInt32(tckimlik[1].ToString());
        //        D1 = Convert.ToInt32(tckimlik[0].ToString());

        //        if (((((D1 + D3 + D5 + D7 + D9) * 7) - (D2 + D4 + D6 + D8)) % 10) == D10)
        //        {
        //            if ((D1 + D2 + D3 + D4 + D5 + D6 + D7 + D8 + D9 + D10) % 10 == D11)
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }

        //    return false;
        //}

        public string RasgeleTcNo(Random rnd)
        {
            int rasgele = rnd.Next(100000000, 1000000000); // İlk 9 rakamı üret
            return Uret(rasgele);
        }

        private string Uret(int ilkDokuz)
        {
            var d9 = ilkDokuz / 100000000;
            var d8 = (ilkDokuz / 10000000) % 10;
            var d7 = (ilkDokuz / 1000000) % 10;
            var d6 = (ilkDokuz / 100000) % 10;
            var d5 = (ilkDokuz / 10000) % 10;
            var d4 = (ilkDokuz / 1000) % 10;
            var d3 = (ilkDokuz / 100) % 10;
            var d2 = (ilkDokuz / 10) % 10;
            var d1 = ilkDokuz % 10;


            var teklerToplami = d1 + d3 + d5 + d7 + d9;
            var ciftlerToplami = d2 + d4 + d6 + d8;
            var kontrol1 = ((teklerToplami * 7) - ciftlerToplami) % 10;
            var kontrol2 = (teklerToplami + ciftlerToplami + kontrol1) % 10;

            return $"{ilkDokuz}{kontrol1}{kontrol2}";
        }





       




    }
}
