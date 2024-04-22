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
            if (Suite.Capacidade >= 2) 
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A Quantide de hóspedes não deve exceder a capacidade da Suite."); 
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)  
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária 
            decimal valor = 0; 

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10% 
            if (DiasReservados >= 10)
            {
                valor = DiasReservados * Suite.ValorDiaria * 0.90m;
            }
            else
            { 
                valor = DiasReservados * Suite.ValorDiaria;
            } 
            return valor;
        }
    }
}