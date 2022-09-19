using Transportberegner;

namespace TransportberegnerTest
{
    public class UnitTest1
    {
        [InlineData(3, 2, 0)]
        [InlineData(4, 10, 50)]
        [InlineData(5, 3, 75)]
        [InlineData(30, 23, 100)]

        [Theory]
        public void Test1(int afstand, int vaegt, int transportpris)
        {
            // Arrange

            // Act
            var sut = new IBeregner();
            int mintransportpris = sut.BeregnTransportpris(afstand, vaegt);

            // Assert
            Assert.Equal(transportpris, mintransportpris);
            
        }
    }
}