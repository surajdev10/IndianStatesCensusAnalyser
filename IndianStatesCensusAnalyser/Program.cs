using IndianStatesCensusAnalyser;

internal class Program


{
    public static string stateCensusCSVFilePath = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCensusData.csv";
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        CSVStateCensus cSVStateCensus = new CSVStateCensus();
        cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
    }
}