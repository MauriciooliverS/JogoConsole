public abstract class Personagem
{
    protected string nome = "";
    protected string classe = "";
    protected int ataque = 0;
    protected int defesa = 0;
    protected int especial = 0;
    protected int vida = 100;

    public Personagem(){}

    public void DefineNome(string nome)
    {
        this.nome = nome;
    }
    public string NomePersonagem()
    {
        return nome;
    }
    public abstract void DefineClasse(int escolha);

    public string ClassePersonagem()
    {
        return classe;
    }
    protected abstract void DefineAtributos();

    public void ImprimeStatus()
    {
        Console.WriteLine("_________________________");
        Console.WriteLine($"|Classe: \t{classe} \t|");
        Console.WriteLine($"|Nome:  \t{nome} \t|");
        Console.WriteLine($"|Ataque: \t{ataque}  \t|");
        Console.WriteLine($"|Defesa: \t{classe} \t|");
        Console.WriteLine("|_______________________|");
    }

    public int Atacar()
    {
        Random valorAtaque= new Random();
        int ataqueRandom = valorAtaque.Next(0, ataque);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{nome} ataca! | Ataque: {ataqueRandom}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter para continuar ====>");
        Console.ReadLine();
        especial++;
        return ataqueRandom;
    }

    public int Defender()
    {
        Random valorAtaque= new Random();
        int defesaRandom = valorAtaque.Next(0, ataque);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{nome} defende! | Defesa: {defesaRandom}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter para continuar ====>");
        Console.ReadLine();
        especial++;
        return defesaRandom;
    }

    public int Especial()
    {
        if(especial >= 3)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{nome} Ataca com Especial! | Ataque: {ataque * 2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter para continuar ====>");
            Console.ReadLine();
            return ataque * 2;
        }
        else
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{nome}, seu especial ainda não está carregado. \n Especial: \t {especial}");
            Console.WriteLine("Aguarde chegar a 3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter para continuar ====>");
            Console.ReadLine();
        }

        return Atacar();
        
    }

    public void Dano(int dano)
    {
        if(dano > 0)
        {
            vida -= dano;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nome} levou {dano} de dano.");
            Console.WriteLine($"Vida Total: {vida}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{nome} não levou dano.");
            Console.WriteLine($"Vida Total: {vida}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        

    }

}