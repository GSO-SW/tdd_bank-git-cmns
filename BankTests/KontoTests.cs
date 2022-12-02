using Bank;

namespace BankTests

{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Konto_KannMitGuthabenErstelltWerden()
        {
            //arrange
            int startguthaben = 256;

            //act
            Konto k = new Konto(startguthaben);

            //assert
            Assert.AreEqual(startguthaben, k.Guthaben);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_KannNichtMitNegativwertErstelltWerden()
        {
            //arrange
            int startguthaben = -256;

            //act
            Konto k = new Konto(startguthaben);

            //assert
            Assert.AreEqual(startguthaben, k.Guthaben);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_KannNichtMitNegativemBetragErstelltWerden()
        {
            //Arrange
            int guthaben = -1;
            //Act
            Konto k = new Konto(guthaben);
        }

    }
}