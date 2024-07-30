bool play = true;
int menu = 0;
int fasePlay = 1;

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("#########################################");
    Console.WriteLine("##### BEM-VINDO À CAVERNA DO DRAGÃO #####");
    Console.WriteLine("#########################################");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Um jogo emocionante onde você enfrentará \nos monstros mais terríveis de toda a terra média");
    Console.WriteLine();
    Console.WriteLine("Prepare-se para a batalha, escolha o seu personagem!");
    Console.WriteLine("Enter para continuar ====>");
    Console.ReadLine();

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1 - Guerreio | 2 - Mago");
    Console.ForegroundColor = ConsoleColor.White;
    Heroi heroi= new Heroi();
    heroi.DefineClasse(int.Parse(Console.ReadLine()));

    Console.Clear();

    if(heroi.ClassePersonagem() == "Guerreiro")
    {
        Console.WriteLine("Qual o nome do seu Guerreiro? o=|=====>");
    }
    else if(heroi.ClassePersonagem() == "Mago")
    {
        Console.WriteLine("Qual o nome do seu Mago? -~~~~~~*");
    }

    heroi.DefineNome(Console.ReadLine().ToUpper());

    Console.Clear();

    Console.WriteLine("Belo nome! Espero que sobreviva!");
    heroi.ImprimeStatus();

    Console.Clear();

    Console.WriteLine("Em um pequeno vilarejo, chamado Landir, próximo à sua terra natal.");
    Console.WriteLine("Pessoas estão desaparecendo, no meio da noite.");
    Console.WriteLine("Famílias inteiras deixam suas casas e seus pertences.");
    Console.WriteLine("Enter para continuar ====>");
    Console.ReadLine();

    Console.Clear();

    Console.WriteLine("Certo dia, em sua missão mensal de ajudar seu clã.");
    Console.WriteLine("Levando mercadorias para serem vendidas e trocadas na cidade de Truzan");
    Console.WriteLine("O caminho habitual está bloqueado e você só vê um caminho por Landir.");
    Console.WriteLine("Enter para continuar ====>");
    Console.ReadLine();

    Console.Clear();
    Console.WriteLine("A cidade é distante e você decide repousar ali.");
    Console.WriteLine("Durante o entardecer na taverna da Serpente Alegre, você ouve os boatos.");
    Console.WriteLine("Mas não acredita nessas histórias e vai dormir.");
    Console.WriteLine("No meio da noite, você ouve gritos...");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Um grande Orc, vai em sua direção! Prepare-se...");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Enter para continuar ====>");
    Inimigo inimigo = new Inimigo();
    inimigo.DefineNome("Babaloo");
    inimigo.DefineClasse(1);
    Console.ReadLine();

    //GamePlay
    do
    {

        Console.WriteLine("");
        //Console.Clear();
        Console.WriteLine($"{heroi.NomePersonagem()}, digite uma das opções: ");
        Console.WriteLine("1-Atacar | 2-Defender | 3-Especial | 4-Reiniciar | 5-Sair");
        menu = int.Parse(Console.ReadLine());


        switch(menu)
        {
            case 1:
                inimigo.Dano(heroi.Atacar());
                break;
            case 2:
                heroi.Dano(inimigo.Atacar() - heroi.Defender());
                break;
            case 3:
                inimigo.Dano(heroi.Especial());
                break;
            case 4:
                fasePlay = 0;
                break;
            case 5:
                Console.Clear();
                Console.WriteLine($"{heroi.NomePersonagem()}, Landir precisa de você. Volte logo!");
                fasePlay = 0;
                play = false;
                break;
            default:
                Console.WriteLine("Escolha uma opção!");
                break;
        }

    } while(fasePlay == 1);


} while(play);


