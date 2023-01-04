using IndianStatesCensusAnalyser;


namespace IndianStateCensusTest
{
    public class Tests
    {

        public static string stateCensusCSVFilePath = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCensusData.csv";
        public static string stateCensusWrongCSVFilePath = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCensusData.csv";
        public static string stateCensusIncorrectCSVFileType = @"C:\Users\suraj\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\file\StateCensus.txt";

        [Test]

        
            public void GivenStateCensusData_WhenAnalyze_ShouldReturnNumberOfRecordMatches()
            {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
           
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            //  Assert.AreEqual(cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath), stateCodeAnalyzer.ReadStateCensusData(stateCensusCSVFilePath));
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath), stateCodeAnalyzer.ReadStateCensusData(stateCensusCSVFilePath));
        }



        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer stateCensusAnalyzer = new StateCodeAnalyzer();
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(stateCensusWrongCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }

        [Test]
        public void GivenStateCensusDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer stateCensusAnalyzer = new StateCodeAnalyzer();
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(stateCensusIncorrectCSVFileType);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FileType");
            }
        }


    }
}