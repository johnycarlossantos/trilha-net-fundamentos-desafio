namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // IMPLEMENTADO a inclusão de um novo veiculo a lista de veiculos
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add($"{Console.ReadLine()}");
        }

        public void RemoverVeiculo()
        {
            //IMPLEMENTADO EXTRA, criei um lista com os veiculos estacionados para facilitar o check-out
            Console.WriteLine("Veiculos atualmente estacionados.");
            foreach(string estacionados in veiculos)
            {
                Console.WriteLine(estacionados);
            }

            Console.WriteLine("Digite a placa do veículo para remover:");

            // IMPLEMENTADO a captação da placa do veiculo que esta fazendo checkout do estacionamento
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 
                
                Console.WriteLine("Digite quantas horas o veiculo ficou estacionado");

                //IMPLEMENTADO uma checagem para forçar o usuário a utilizar somente numeros
                while (!int.TryParse(Console.ReadLine(), out horas))
                {
                    Console.WriteLine("Digite apenas numeros.");
                    Console.WriteLine("Digite quantas horas o veiculo ficou estacionado: ");

                }
                Console.WriteLine($"O veiculo ficou estacionado por {horas} horas");

                //IMPLEMENTADO o calculo do valor total a pagar
                valorTotal = precoInicial + precoPorHora * horas;

                //IMPLEMENTADO a remoção do veiculo do estacionamento e exibição do valor total a pagar
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal} reais");
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
                // IMPLEMENTADO a exibição de todos os veiculos estacionados
                foreach(string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
