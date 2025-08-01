using System;

public class Contato
{
    public int Id;
    public string Name;
    public string Email;

    public Contato(int id, string nome, string email) 
    {
        Id = id;
        Nome = nome;
        Email = email;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
    }
}