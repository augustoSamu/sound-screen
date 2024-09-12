interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

class Arquivo : IArmazenavel
{
    public void Salvar()
    {
        Console.WriteLine("Salvando arquivo...");
    }

    public void Recuperar()
    {
        Console.WriteLine("Receba arquivo");

    }
}

class BancoDeDados : IArmazenavel
{
    public void Salvar()
    {
        Console.WriteLine("Salvando dados...");
    }

    public void Recuperar()
    {
        Console.WriteLine("Receba dados");
    }
}