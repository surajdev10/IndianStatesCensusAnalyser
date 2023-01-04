using IndianStatesCensusAnalyser;

internal class Program
{
    public static string stateCensusCSVFilePath = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCensusData.csv";
    public static string stateCodeFilePath = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCode.csv";
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.Write("Enter the option : 1.statecensusDatat 2. state code ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CSVStateCensus cSVStateCensus = new CSVStateCensus();
                    cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
                    break;

                case 2:
                    StateCode indianStateCode = new StateCode();
                    indianStateCode.ReadStateCodeData(stateCodeFilePath);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}