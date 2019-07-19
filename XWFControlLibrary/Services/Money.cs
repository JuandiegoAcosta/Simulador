using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XWFControlLibrary.Config;

namespace XWFControlLibrary.Services
{
   public class Money
   {
      RootObject root = null;
      public Money()
      {
         GET_money();
      }

      private void GET_money()
      {
         using (WebClient webClient = new WebClient())
         {
            string uri = "http://www.floatrates.com/daily/pen.json";
            String json = webClient.DownloadString(uri);
            root = JsonConvert.DeserializeObject<RootObject>(json);
         }
      }

      public Usd GetUSD() { return root.usd; }

      public Eur GetEUR() { return root.eur; }
   }
}
