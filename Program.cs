//Vamos criar um programa que gerencie uma lista de notas de alunos e calcule a média. O usuário poderá:
//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
double[] notas = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite a nota {i + 1}: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("As notas do aluno são:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
}

//2.Exibir as notas.
double[] Notas = { 8.5, 7.0, 9.3, 6.7, 5.0 };


Console.WriteLine("Notas dos alunos:");

foreach (double nota in notas)
{
    Console.WriteLine(nota);
}

