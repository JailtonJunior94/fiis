using Fii.Models;
using Fii.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;

namespace Fii
{
    class Program
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            string page = webClient.DownloadString("https://www.fundsexplorer.com.br/ranking");

            var content = new HtmlDocument();
            content.LoadHtml(page);

            var list = new List<FII>();

            foreach (HtmlNode table in content.DocumentNode.SelectNodes("//table"))
            {
                foreach (HtmlNode tbody in table.SelectNodes("tbody"))
                {
                    foreach (HtmlNode row in tbody.SelectNodes("tr"))
                    {
                        var fii = new FII();
                        for (int i = 0; i < row.SelectNodes("td").Count; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    fii.CodigoFundo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 1:
                                    fii.Setor = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 2:
                                    fii.PrecoAtual = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 3:
                                    fii.LiquidezDiaria = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 4:
                                    fii.Dividendo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 5:
                                    fii.DividendoYield = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 6:
                                    fii.DividendoYieldAcumulado3M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 7:
                                    fii.DividendoYieldAcumulado6M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 8:
                                    fii.DividendoYieldAcumulado12M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 9:
                                    fii.DividendoYieldMedia3M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 10:
                                    fii.DividendoYieldMedia6M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 11:
                                    fii.DividendoYieldMedia12M = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 12:
                                    fii.DividendoYieldMediaAno = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 13:
                                    fii.VariacaoPreco = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 14:
                                    fii.RentabilidadePeriodo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 15:
                                    fii.RentabilidadeAcumulada = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 16:
                                    fii.PatrimonioLiquido = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 17:
                                    fii.VPA = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 18:
                                    fii.PVPA = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 19:
                                    fii.DividendoYieldPatrimonial = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 20:
                                    fii.VariacaoPatrimonial = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 21:
                                    fii.RentabilidadePatrimonialPeriodo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 22:
                                    fii.RentabilidadePatrimonialAcumulada = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 23:
                                    fii.VariacaoFisica = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 24:
                                    fii.VacanciaFisica = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 25:
                                    fii.QuantidadeAtivos = row.SelectNodes("td")[i].InnerText;
                                    break;
                                default:
                                    break;
                            }
                        }
                        Console.WriteLine(fii.ToString());
                        list.Add(fii);
                    }
                }
            }

            ExcelService.BuildExcel(list);
        }
    }
}
