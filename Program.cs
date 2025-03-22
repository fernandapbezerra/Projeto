//Vamos criar um programa que gerencie uma lista de notas de alunos e calcule a média. O usuário poderá:
//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas):

int[] notas = new int[5];
for (int i = 0; i< notas.Length; i ++)
{
   Console.WriteLine("Informe a nota");
    notas[i] = int.Parse(Console.ReadLine());
}

//2.Exibir as notas:

for (int i = 0;i<notas.Length;i ++)
{
    Console.WriteLine(notas[i]);
}

//3.calcular a média:
//Soma das Notas - Quantidade (ja possuo)

int somaNotas = 0;

for (int i = 0; i < notas.Length ; i ++)
{
    somaNotas = notas[i] + somaNotas;
}

int media = somaNotas / notas.Length;
Console.WriteLine(media);

//4.Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação):

if (media >= 7)
{
    Console.WriteLine("O aluno foi APROVADO");
}
else
{

    Console.WriteLine("O aluno foi REPROVADO");
}