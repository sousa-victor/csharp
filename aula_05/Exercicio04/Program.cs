namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[4, 10];
            float[] media = new float[matriz.GetLength(1)];
            float nota = 0;


            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    Console.WriteLine($"Informe a {i + 1}ª nota do {j + 1}º aluno: ");
                    matriz[i, j] = Convert.ToSingle(Console.ReadLine());
                    nota += matriz[i, j];
                }
                Console.Clear();
                media[j] = nota / 4.0f;
                nota = 0;
            }

            for (int i = 0; i < media.Length; i++)
            {
                if (i == media.Length - 1)
                {
                    Console.WriteLine(media[i].ToString("F1"));
                }
                else
                {
                    Console.Write(media[i].ToString("F1") + " | ");
                }
            }
        }
    }
}