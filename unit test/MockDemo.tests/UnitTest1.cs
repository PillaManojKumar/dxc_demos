using Moq;

namespace MockDemo.tests
{
    public class Tests
    {
        [Test]
        public void ReadText_WhenCalled_ReturnsAllTextFromFile()
        {            
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadText()).Returns("Welcome to Mocking");
            var service = new FileService(fileReader.Object);
            
            var result = service.ReadData();
            
            Assert.That(result, Does.Contain(""));
        }
    }
}