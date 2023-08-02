using CaixaEletronico.Application.Services;

namespace CaixaEletronico.Testes.Services
{
    public class CaixaEletronicoServiceTest
    {
        private readonly CaixaEletronicoService _service;

        public CaixaEletronicoServiceTest()
        {
            _service = new CaixaEletronicoService();
        }

        [Fact]
        public void CalculaSaquePara30()
        {
            var notas = _service.CalculaSaque(30);

            // ambos são iguais
            //Assert.Equal(1, notas.Where(n => n == 20).Count());
            Assert.Single(notas.Where(n => n == 20));

            Assert.Single(notas.Where(n => n == 10));
        }
    }
}
