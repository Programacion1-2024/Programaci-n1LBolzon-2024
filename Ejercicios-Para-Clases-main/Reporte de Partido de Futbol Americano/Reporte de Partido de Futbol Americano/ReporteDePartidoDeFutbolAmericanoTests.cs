namespace Reporte_de_Partido_de_Futbol_Americano
{
    public class ReporteDePartidoDeFutbolAmericanoTests
    {
        [Fact]
        public void AnalyzeOnField_1()
        {
            Assert.Equal("goalie", PlayAnalyzer.AnalyzeOnField(1));
        }

        [Fact]
        public void AnalyzeOnField_8()
        {
            Assert.Equal("midfielder", PlayAnalyzer.AnalyzeOnField(8));
        }

        [Fact]
        public void AnalyzeOnField_10()
        {
            Assert.Equal("striker", PlayAnalyzer.AnalyzeOnField(10));
        }

        [Fact]
        public void AnalyzeOnField_11()
        {
            Assert.Equal("right wing", PlayAnalyzer.AnalyzeOnField(11));
        }

        [Fact]
        public void AnalyzeOnField_throws_unknown_shirt_number()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PlayAnalyzer.AnalyzeOnField(1729));
        }

        [Fact]
        public void AnalyzeOffField_number()
        {
            Assert.Equal("There are 4200 supporters at the match.", PlayAnalyzer.AnalyzeOffField(4200));
        }

        [Fact]
        public void AnalyzeOffField_throws_unknown_type()
        {
            Assert.Throws<ArgumentException>(() => PlayAnalyzer.AnalyzeOffField(90.0f));
        }

        [Fact]
        public void AnalyzeOffField_text()
        {
            Assert.Equal("They think it's all over!", PlayAnalyzer.AnalyzeOffField("They think it's all over!"));
        }

        [Fact]
        public void AnalyzeOffField_incident()
        {
            Assert.Equal("An incident happened.", PlayAnalyzer.AnalyzeOffField(new Incident()));
        }

        [Fact]
        public void AnalyzeOffField_foul()
        {
            Assert.Equal("The referee deemed a foul.", PlayAnalyzer.AnalyzeOffField(new Foul()));
        }

        [Fact]
        public void AnalyzeOffField_injury()
        {
            Assert.Equal("Oh no! Player 3 is injured. Medics are on the field.", PlayAnalyzer.AnalyzeOffField(new Injury(3)));
        }

        [Fact]
        public void AnalyzeOffField_manager_no_club()
        {
            Assert.Equal("David Moyes", PlayAnalyzer.AnalyzeOffField(new Manager("David Moyes", null)));
        }

        [Fact]
        public void AnalyzeOffField_manager_with_club()
        {
            Assert.Equal("Thomas Tuchel (Chelsea)", PlayAnalyzer.AnalyzeOffField(new Manager("Thomas Tuchel", "Chelsea")));
        }
    }
}