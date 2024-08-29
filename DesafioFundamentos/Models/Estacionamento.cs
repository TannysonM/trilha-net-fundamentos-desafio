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
            //IMPLEMENTADO!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            //IMPLEMENTADO!!!
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //IMPLEMENTADO!!!
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                //IMPLEMENTADO!!!
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
               
               //IMPLEMENTADO!!!
                int contador = 0;
                foreach(string listDeVeiculos in veiculos)
                {
                    Console.WriteLine($"{listDeVeiculos}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

 /*
  Deixo os comentarios que o professor coloco por coisa minha.

 //TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
 //IMPLEMENTE AQUI*

 // Pedir para o usuário digitar a placa e armazenar na variável placa
 // *IMPLEMENTE AQUI*

// TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
// TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
// *IMPLEMENTE AQUI*

// TODO: Remover a placa digitada da lista de veículos
// *IMPLEMENTE AQUI*

// TODO: Realizar um laço de repetição, exibindo os veículos estacionados
// *IMPLEMENTE AQUI*
 */