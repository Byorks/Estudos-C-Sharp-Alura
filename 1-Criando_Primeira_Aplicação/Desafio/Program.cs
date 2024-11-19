//A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

//Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

//    Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
//    Mostrar o conteúdo da variável curso no console.
//    Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
//    Mostrar na tela o nome dos instrutores do curso.

string curso = "C# Criando sua primeira aplicação";
string nome, sobrenome;
string instrutorA = "Guilherme Lima";
string InstrutorB = "Daniel Portugal";

// Mostra o conteúdo da variável
Console.WriteLine(curso);

Console.WriteLine("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.WriteLine("Agora digite o seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.WriteLine($"Olá,{nome} {sobrenome}, seja bem vindo(a)!（*＾-＾*）\n");

Console.Write("Seu curto atual é: " + curso + "\nSeus instrututores são: " + instrutorA + " e " + InstrutorB);



