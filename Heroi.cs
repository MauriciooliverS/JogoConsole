public class Heroi : Personagem
{
    public Heroi(){}

    public override void DefineClasse(int escolha)
    {
        if(escolha == 1)
        {
            classe = "Guerreiro";
        }
        else if(escolha == 2)
        {
            classe = "Mago";
        }

        DefineAtributos();
    }

    protected override void DefineAtributos()
    {
        if(classe == "Guerreiro")
        {
            ataque = 20;
            defesa = 15;
        }
        else if(classe == "Mago")
        {
            ataque = 15;
            defesa = 20;
        }
    }
}