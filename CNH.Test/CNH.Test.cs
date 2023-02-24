namespace CNH.Test
{
    public class CNHTest
    {
        [Fact]
        public void ValidaDigitacaoOK()
        {
            string numCnh = "12345678910";
            bool validador = CNHValida.Execute(numCnh);
            Assert.True(validador);
        }
        [Fact]
        public void ValidaDigitacaoErro12nums()
        {
            string numCnh = "123456789910";
            bool validador = CNHValida.Execute(numCnh);
            Assert.False(validador);
        }
        [Fact]
        public void ValidaDigitacaoErro10nums()
        {
            string numCnh = "1234567899";
            bool validador = CNHValida.Execute(numCnh);
            Assert.False(validador);
        }
        [Fact]
        public void ValidaDigitacaoErroComString()
        {
            string numCnh = "1234567899e";
            bool validador = CNHValida.Execute(numCnh);
            Assert.False(validador);
        }
    }
}