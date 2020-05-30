using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using CointMarket.Models.Coins;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace CointMarket.Services
{
    public class RealtimeDatabaseService
    {
      private static readonly IFirebaseConfig Config = new FirebaseConfig
      {
          AuthSecret = "gEnXwIHs168Q4dry1WFlbS1dYKYBqSO4Jcn07W04",
          BasePath = "https://coin-market-2020.firebaseio.com"
      };

      private static IFirebaseClient Client;

      static readonly CoinService CoinService = new CoinService();
      public static void RealtimeCoin()
      {
        Task.Run(async () => {
          for (; ; )
          {
            await Task.Delay(Constant.IntervalTime);
            string coins = await CoinService.GetCryptocompareCoint(Constant.Coins);
            Coin coin = JsonConvert.DeserializeObject<Coin>(coins);
            Client = new FirebaseClient(Config);
            SetResponse response = await Client.SetAsync("CryptoCompare" , coin);
            Debug.WriteLine("inserted");
          }
        });
      }
    }
}