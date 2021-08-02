using System.Net;
using HtmlAgilityPack;
using System.Collections.Generic;
using System;

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
                                    fii.DividendoYieldAcumuladoAno = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 10:
                                    fii.VariacaoPreco = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 11:
                                    fii.RentabilidadePeriodo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 12:
                                    fii.RentabilidadeAcumulada = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 13:
                                    fii.PatrimonioLiquido = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 14:
                                    fii.VPA = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 15:
                                    fii.PVPA = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 16:
                                    fii.DividendoYieldPatrimonial = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 17:
                                    fii.VariacaoPatrimonial = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 18:
                                    fii.RentabilidadePatrimonialPeriodo = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 19:
                                    fii.RentabilidadePatrimonialAcumulada = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 20:
                                    fii.VacanciaFisica = row.SelectNodes("td")[i].InnerText;
                                    break;
                                case 21:
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
        }
    }

    class FII
    {
        public string CodigoFundo { get; set; }
        public string Setor { get; set; }
        public string PrecoAtual { get; set; }
        public string LiquidezDiaria { get; set; }
        public string Dividendo { get; set; }
        public string DividendoYield { get; set; }
        public string DividendoYieldAcumulado3M { get; set; }
        public string DividendoYieldAcumulado6M { get; set; }
        public string DividendoYieldAcumulado12M { get; set; }
        public string DividendoYieldAcumuladoAno { get; set; }
        public string VariacaoPreco { get; set; }
        public string RentabilidadePeriodo { get; set; }
        public string RentabilidadeAcumulada { get; set; }
        public string PatrimonioLiquido { get; set; }
        public string VPA { get; set; }
        public string PVPA { get; set; }
        public string DividendoYieldPatrimonial { get; set; }
        public string VariacaoPatrimonial { get; set; }
        public string RentabilidadePatrimonialPeriodo { get; set; }
        public string RentabilidadePatrimonialAcumulada { get; set; }
        public string VacanciaFisica { get; set; }
        public string QuantidadeAtivos { get; set; }

        public override string ToString()
        {
            return $@"
                CODIGO DO FUNDO: {CodigoFundo}
                SETOR: {Setor}
                PREÇO ATUAL: {PrecoAtual}
                LIQUIDEZ DIÁRIA: {LiquidezDiaria}
                DIVIDENDO: {Dividendo}
                DIVIVENDO YIELD: {DividendoYield}
                DIVIVENDO YIELD ACUMULADO 3 (MESES): {DividendoYieldAcumulado3M}
                DIVIVENDO YIELD ACUMULADO 6 (MESES): {DividendoYieldAcumulado6M}
                DIVIVENDO YIELD ACUMULADO 12 (MESES): {DividendoYieldAcumulado12M}
                DIVIVENDO YIELD ACUMULADO ANO: {DividendoYieldAcumuladoAno}
                VARIAÇÃO PREÇO: {VariacaoPreco}
                RENTABILIDADE PERIODO: {RentabilidadePeriodo}
                RENTABILIDADE ACUMULADA: {RentabilidadeAcumulada}
                PATRIMONIO LIQUIDO: {PatrimonioLiquido}
                VPA: {VPA}
                P/VPA: {PVPA}
                DIVIDENDO YIELD PATRIMONIAL: {DividendoYieldPatrimonial}
                RENTABILIDADE PATRIMONIAL PERIODO: {RentabilidadePatrimonialPeriodo}
                RENTABILIDADE PATRIMONIAL ACUMULADA: {RentabilidadePatrimonialAcumulada}
                VACANCIA FÍSICA: {VacanciaFisica}
                QUATIDADE ATIVOS: {QuantidadeAtivos}
                ";
        }
    }
}
