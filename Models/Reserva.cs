namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            //Implementado, esse contador irá atribuir o valor somado de cada vez que o foreach passar por ele
            int quantidadeDeHospedes = 0;
            foreach (var item in hospedes)
            {
                quantidadeDeHospedes++;
            }

            if (quantidadeDeHospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else 
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*

                //Implementado, ele lança uma exception apontando o problema
                throw new ArgumentException("A capacidade das suítes é menor do que a quantidade de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            int quantidadeDeHospedes = 0;
            foreach (var item in Hospedes)
            {
                quantidadeDeHospedes++;
            }

            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*

            if (DiasReservados > 10)
            {
                decimal porcentagem = 20;
                decimal porcentagemASeradicionada = porcentagem / 100;
                decimal resultado = valor + (valor *  porcentagemASeradicionada);

                return resultado;
            }

            return valor;
        }
    }
}