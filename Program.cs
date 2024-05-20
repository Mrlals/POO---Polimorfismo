// Metodo Main()

using Polimorfismo;

Funcionario f = new Funcionario(1, "Maicão", 1500);
Console.WriteLine($"Bonificação de funcionário: R${f.CalcularBonificacao()}");


Secretario s = new Secretario(2, "Bola de Fogo", 1800);
Console.WriteLine($"Bonificação do Secretário: R${s.CalcularBonificacao()}");


Gerente g = new Gerente(3,"Cabrero", 5000);
Console.WriteLine($"Bonificação do Gerente: R${g.CalcularBonificacao()}");


Diretor d = new Diretor(4,"Cabuloso", 10000);
Console.WriteLine($"Bonificação do Diretor: R${d.CalcularBonificacao()}");

//polimorfismo utilizando associação de dependencia com Gerenciador de Bonificação
GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
gerenciador.TotalizadorBonificacao(f);
Console.WriteLine($"Bonificação de funcionário: R${f.CalcularBonificacao()}");

gerenciador.TotalizadorBonificacao(s);
Console.WriteLine($"Bonificação do Secretário: R${s.CalcularBonificacao()}");

gerenciador.TotalizadorBonificacao(g);
Console.WriteLine($"Bonificação do Gerente: R${g.CalcularBonificacao()}");

gerenciador.TotalizadorBonificacao(d);
Console.WriteLine($"Bonificação do Diretor: R${d.CalcularBonificacao()} ");

Console.WriteLine($"Total de bonificação: R${gerenciador.TotalBonificacao}");