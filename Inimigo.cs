public class Inimigo : Personagem
{
    public Inimigo()
    {
        vida = 200;
    }

    public override void DefineClasse(int escolha)
    {
        if(escolha == 1)
        {
            classe = "Orc";
        }
        else if(escolha == 2)
        {
            classe = "Dragão";
        }

        DefineAtributos();
    }

    protected override void DefineAtributos()
    {
        if(classe == "Orc")
        {
            ataque = 25;
            defesa = 15;
        }
        else if(classe == "Dragão")
        {
            ataque = 30;
            defesa = 30;
        }
    }
}