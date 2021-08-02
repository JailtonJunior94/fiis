namespace Fii.Models
{
    public class FII
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
        public string DividendoYieldMedia3M { get; set; }
        public string DividendoYieldMedia6M { get; set; }
        public string DividendoYieldMedia12M { get; set; }
        public string DividendoYieldMediaAno { get; set; }
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
        public string VariacaoFisica { get; set; }
        public string VacanciaFisica { get; set; }
        public string QuantidadeAtivos { get; set; }

        //public override string ToString()
        //{
        //    return $@"
        //        CODIGO DO FUNDO: {CodigoFundo}
        //        SETOR: {Setor}
        //        PREÇO ATUAL: {PrecoAtual}
        //        LIQUIDEZ DIÁRIA: {LiquidezDiaria}
        //        DIVIDENDO: {Dividendo}
        //        DIVIVENDO YIELD: {DividendoYield}
        //        DIVIVENDO YIELD ACUMULADO 3 (MESES): {DividendoYieldAcumulado3M}
        //        DIVIVENDO YIELD ACUMULADO 6 (MESES): {DividendoYieldAcumulado6M}
        //        DIVIVENDO YIELD ACUMULADO 12 (MESES): {DividendoYieldAcumulado12M}
        //        DIVIVENDO YIELD ACUMULADO ANO: {DividendoYieldAcumuladoAno}
        //        VARIAÇÃO PREÇO: {VariacaoPreco}
        //        RENTABILIDADE PERIODO: {RentabilidadePeriodo}
        //        RENTABILIDADE ACUMULADA: {RentabilidadeAcumulada}
        //        PATRIMONIO LIQUIDO: {PatrimonioLiquido}
        //        VPA: {VPA}
        //        P/VPA: {PVPA}
        //        DIVIDENDO YIELD PATRIMONIAL: {DividendoYieldPatrimonial}
        //        RENTABILIDADE PATRIMONIAL PERIODO: {RentabilidadePatrimonialPeriodo}
        //        RENTABILIDADE PATRIMONIAL ACUMULADA: {RentabilidadePatrimonialAcumulada}
        //        VACANCIA FÍSICA: {VacanciaFisica}
        //        QUATIDADE ATIVOS: {QuantidadeAtivos}
        //        ";
        //}
    }
}
