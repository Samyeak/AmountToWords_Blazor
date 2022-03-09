using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CurrencyToWord;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NumberToText;
using NumberToText.Api;

namespace BlazorAmountToWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string hindiWords = NumberToWords.Converter.ConvertNumbertoWords(60785214);
            string words = NumberConverter.NumberToText(60785214);
            
            decimal number = 60785214.2365M;

            string str = number.ToText();
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
