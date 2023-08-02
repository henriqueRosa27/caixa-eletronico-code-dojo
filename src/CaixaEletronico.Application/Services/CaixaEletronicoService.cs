namespace CaixaEletronico.Application.Services
{
    public class CaixaEletronicoService
    {
        private readonly IEnumerable<int> NotasDisponiveis = new List<int> { 100, 50, 20, 10, 5, 2 };

        public IEnumerable<int> CalculaSaque(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
