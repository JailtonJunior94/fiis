using ClosedXML.Excel;
using Fii.Models;
using System.Collections.Generic;
using System.IO;

namespace Fii.Services
{
    public static class ExcelService
    {
        public static void BuildExcel(List<FII> fiis)
        {
            using var workbook = new XLWorkbook();
            using var memoryStream = new MemoryStream();

            var worksheet = workbook.Worksheets.Add($"Melhores FIIs");

            worksheet.Cell("A1").Value = "Código do Fundo";
            worksheet.Cell("B1").Value = "Setor";
            worksheet.Cell("C1").Value = "Preço Atual";
            worksheet.Cell("D1").Value = "Liquidez Diaria";
            worksheet.Cell("E1").Value = "Dividendo";
            worksheet.Cell("F1").Value = "Dividendo Yield";
            worksheet.Cell("G1").Value = "Dividendo Yield Acumulado 3 (Meses)";
            worksheet.Cell("H1").Value = "Dividendo Yield Acumulado 6 (Meses)";
            worksheet.Cell("I1").Value = "Dividendo Yield Acumulado 12 (Meses)";
            worksheet.Cell("J1").Value = "Dividendo Yield Média 3 (Meses)";
            worksheet.Cell("K1").Value = "Dividendo Yield Média 6 (Meses)";
            worksheet.Cell("L1").Value = "Dividendo Yield Média 12 (Meses)";
            worksheet.Cell("M1").Value = "Dividendo Yield Ano";
            worksheet.Cell("N1").Value = "Variação Preço";
            worksheet.Cell("O1").Value = "Rentabilidade Periodo";
            worksheet.Cell("P1").Value = "Rentabilidade Acumulada";
            worksheet.Cell("Q1").Value = "Patrimonio Liquido";
            worksheet.Cell("R1").Value = "VPA";
            worksheet.Cell("S1").Value = "P/VPA";
            worksheet.Cell("T1").Value = "Dividendo Yield Patrominial";
            worksheet.Cell("U1").Value = "Variação Patrimonial";
            worksheet.Cell("V1").Value = "Rentabilidade Patrimonial Periodo";
            worksheet.Cell("W1").Value = "Rentabilidade Patrimonial Acumulada";
            worksheet.Cell("X1").Value = "Variação Física";
            worksheet.Cell("Y1").Value = "Vacância Financeira";
            worksheet.Cell("Z1").Value = "Quantidade Ativos";

            for (int i = 0; i < fiis.Count; i++)
            {
                var item = fiis[i];

                worksheet.Cell("A" + (2 + i)).Value = item.CodigoFundo;
                worksheet.Cell("B" + (2 + i)).Value = item.Setor;
                worksheet.Cell("C" + (2 + i)).SetDataType(XLDataType.Number).Value = item.PrecoAtual;
                worksheet.Cell("D" + (2 + i)).Value = item.LiquidezDiaria;
                worksheet.Cell("E" + (2 + i)).SetDataType(XLDataType.Number).Value = item.Dividendo;
                worksheet.Cell("F" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYield;
                worksheet.Cell("G" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldAcumulado3M;
                worksheet.Cell("H" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldAcumulado6M;
                worksheet.Cell("I" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldAcumulado12M;
                worksheet.Cell("J" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldMedia3M;
                worksheet.Cell("K" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldMedia6M;
                worksheet.Cell("L" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldMedia12M;
                worksheet.Cell("M" + (2 + i)).SetDataType(XLDataType.Number).Value = item.DividendoYieldMediaAno;
                worksheet.Cell("N" + (2 + i)).SetDataType(XLDataType.Number).Value = item.VariacaoPreco;
                worksheet.Cell("O" + (2 + i)).SetDataType(XLDataType.Number).Value = item.RentabilidadePeriodo;
                worksheet.Cell("P" + (2 + i)).SetDataType(XLDataType.Number).Value = item.RentabilidadeAcumulada;
                worksheet.Cell("Q" + (2 + i)).SetDataType(XLDataType.Number).Value = item.PatrimonioLiquido;
                worksheet.Cell("R" + (2 + i)).SetDataType(XLDataType.Number).Value = item.VPA;
                worksheet.Cell("S" + (2 + i)).SetDataType(XLDataType.Number).Value = item.PVPA;
                worksheet.Cell("T" + (2 + i)).Value = item.DividendoYieldPatrimonial;
                worksheet.Cell("U" + (2 + i)).Value = item.VariacaoPatrimonial;
                worksheet.Cell("V" + (2 + i)).SetDataType(XLDataType.Number).Value = item.RentabilidadePatrimonialPeriodo;
                worksheet.Cell("W" + (2 + i)).Value = item.RentabilidadeAcumulada;
                worksheet.Cell("X" + (2 + i)).SetDataType(XLDataType.Number).Value = item.VariacaoFisica;
                worksheet.Cell("Y" + (2 + i)).SetDataType(XLDataType.Number).Value = item.VacanciaFisica;
                worksheet.Cell("Z" + (2 + i)).SetDataType(XLDataType.Number).Value = item.QuantidadeAtivos;
            }

            workbook.SaveAs(memoryStream);
            workbook.SaveAs(@"C:\Fiis\melhores-fiis.xlsx");
        }
    }
}
