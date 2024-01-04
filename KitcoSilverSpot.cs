using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LPS_Utility
{
    public class KitcoSilverSpot
    {
        public decimal _SilverSpot;


        public decimal SpotValue()
        {
            var html1 = @"https://www.kitco.com/price/precious-metals/silver";

            try
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc1 = web.Load(html1);

                var node1 = htmlDoc1.DocumentNode.SelectSingleNode("/html/body/div[1]/div/main/div/div[3]/div[1]/div[1]/div/div[1]/div[2]/h3");
                
                if(node1 != null)
                {
                    _SilverSpot = Convert.ToDecimal(node1.InnerText);

                }
                else
                {

                    _SilverSpot = 0;
                    Console.WriteLine("Internet Or Website Down");
                }
               


            }
            catch (Exception)
            {


                Console.WriteLine("Internet Or Website Down");


            }

            return _SilverSpot;

        }





    }
}
