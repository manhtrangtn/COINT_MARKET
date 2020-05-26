using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using CointMarket.Models.Coins;
using Newtonsoft.Json;

namespace CointMarket.Services
{
    public class CoinService
    {
      private readonly HttpClient _client = new HttpClient();
      public async Task<String> GetBinanceCoint(string coin)
      {
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.binance.com/api/v3/ticker/price?symbol="+coin+"USDT");
        var resp = await _client.SendAsync(httpRequestMessage);
        return await resp.Content.ReadAsStringAsync();
      }      
      public async Task<String> GetCryptocompareCoint(string coins)
      {
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://min-api.cryptocompare.com/data/pricemulti?fsyms="+coins+"&tsyms=USD");
        var resp = await _client.SendAsync(httpRequestMessage);
        _client.DefaultRequestHeaders.Add("Apikey", Constant.CryptocompareApiKeyHeader); 
        return await resp.Content.ReadAsStringAsync();
      }
    }
}