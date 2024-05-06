using DesafioFundamentos.Models;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private DateTime _horaAtual = new DateTime();
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private Dictionary<string, int> veiculos = new Dictionary<string, int>();

        


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            DateTime horaChegada = DateTime.Now;
            veiculos.Add(placa.ToUpper(), horaChegada.Hour);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (VerificaCarroExiste(placa))
            {

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // Implementado
                DateTime horaAtual = DateTime.Now;
                int horas = veiculos[placa.ToUpper()] - horaAtual.Hour;
                decimal valorTotal = 0;
                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // Implementado

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Implementado
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Key.ToString()} Hora de chegada: {veiculo.Value.ToString()}Hrs");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        private bool VerificaCarroExiste(string placa)
        {
            if (veiculos.ContainsKey(placa.ToUpper()))
            {
                return true;
            }
            else { return false; }
        }
    }
}
