double PesoOuro = 0, pesoPrata = 1, pesoBronze = 0, peso = 0, c = 0;
string nome, nomeOuro = "", nomePrata = "", nomeBronze = "", x = "";
bool R = true;


while (R == true)
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o peso levantado:");
    peso = Convert.ToDouble(Console.ReadLine());
    if (peso > PesoOuro)
    {
        pesoPrata = PesoOuro;
        nomePrata = nomeOuro;
        PesoOuro = peso;
        nomeOuro = nome;
        
    }
    else if (peso > pesoPrata )
    {
        pesoBronze = pesoPrata;
        nomeBronze = nomePrata;
        pesoPrata = peso;
        nomePrata = nome;
                
    }
    else if (peso > pesoBronze)
    {
        pesoBronze = peso;
        nomeBronze = nome;
    }
    Console.WriteLine("Calcular o resultado? Sim ou Não");
        x = Console.ReadLine().ToLowerInvariant();
    if (x == "sim")
    {
        R = false;
    }
}
Console.WriteLine("Ouro");
Console.WriteLine("Nome: " + nomeOuro);
Console.WriteLine("Peso: " + PesoOuro);
Console.WriteLine("Prata ");
Console.WriteLine("Nome: " + nomePrata);
Console.WriteLine("Peso: " + pesoPrata);
Console.WriteLine("Bronze");
Console.WriteLine("Nome: " + nomeBronze);
Console.WriteLine("Peso: " + pesoBronze);
Console.ReadKey();