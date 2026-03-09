//Matheus Paiva Batista - 032064
using EXERCICIO_2_ROBINSON;
internal class Program
{
    static void Main(string[] args)
    //ALUNO
    {
        aluno aluno = new aluno();

        aluno.nome = "Matheus";
        aluno.idade = 31;
        aluno.matricula = "032064";

        //PROFESSOR

        professor professor = new professor();

        professor.nomeprofessor = "Robinson";
        professor.codigo = 1234;
        professor.formacao = "Engenharia de Software";

        //DISCIPLINA
        disciplina disciplina = new disciplina();

        disciplina.nomedisciplina = "Programação Orientada a Objetos";
        disciplina.coddiciplina = 5678;
        disciplina.cargaHoraria = 60;

        //NOTAS

        notas notas = new notas();
        notas.nota1 = 9.5;
        notas.nota2 = 8.0;
        notas.nota3 = 7.5;

        double media = (notas.nota1 + notas.nota2 + notas.nota3) / 3;
        double notasonamada = notas.nota1 + notas.nota2 + notas.nota3;

        //BOLETIM   
        boletim boletim = new boletim();

        boletim.aluno = aluno.nome;
        boletim.professor = professor.nomeprofessor;
        boletim.disciplina = disciplina.nomedisciplina;
        boletim.notas = media;


        if (media >= 7.0)
        {
            Console.WriteLine("O aluno foi aprovado!");
        }
        else
        {
            Console.WriteLine("O aluno foi reprovado!");
        }

        Console.WriteLine("Boletim do Aluno:");
        Console.WriteLine("Aluno: " + aluno.nome);
        Console.WriteLine("Professor: " + professor.nomeprofessor);
        Console.WriteLine("Disciplina: " + disciplina.nomedisciplina);
        Console.WriteLine("Primeira nota" + notas.nota1);
        Console.WriteLine("Segunda nota" + notas.nota2);
        Console.WriteLine("Terceira nota" + notas.nota3);
        Console.WriteLine("a nota final do aluno é " + notasonamada);
        Console.WriteLine("A média do aluno é: " + media);

    }
}
