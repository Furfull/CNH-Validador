namespace CNH.Test
{
    public class CNHTest
    {
        [Fact]
        public void ValidaDigitacaoOK()
        {
            string numCnh = "12345678910";
            CNHValida cnh = new CNHValida();
            bool validador = cnh.Execute(numCnh);
            Assert.True(validador);
        }
        [Fact]
        public void ValidaDigitacaoErro12nums()
        {
            string numCnh = "123456789910";
            CNHValida cnh = new CNHValida();
            bool validador = cnh.Execute(numCnh);
            Assert.False(validador);
        }
        [Fact]
        public void ValidaDigitacaoErro10nums()
        {
            string numCnh = "1234567899";
            CNHValida cnh = new CNHValida();
            bool validador = cnh.Execute(numCnh);
            Assert.False(validador);
        }
        [Fact]
        public void ValidaDigitacaoErroComString()
        {
            string numCnh = "1234567899e";
            CNHValida cnh = new CNHValida();
            bool validador = cnh.Execute(numCnh);
            Assert.False(validador);
        }
    }
}