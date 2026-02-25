namespace exercicio_1_par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            string entrada = Console.ReadLine();

            // Converte a entrada para int
            int numero;
            if (int.TryParse(entrada, out numero))
            {
                // Verifica se é par ou ímpar
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é PAR.");
                }
                else
                {
                    Console.WriteLine("O número é ÍMPAR.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
            }
        }
}
