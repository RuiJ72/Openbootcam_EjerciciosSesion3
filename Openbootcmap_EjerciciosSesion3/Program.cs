Client myClient = new Client("Rui Lagos", "Portugal", 718987550, "Calle Derecha", "rlagos900@gmail.com", "Nuevo Cliente");

Console.WriteLine(myClient.N);
Console.WriteLine(myClient.P);
Console.WriteLine(myClient.T);
Console.WriteLine(myClient.D);
Console.WriteLine(myClient.E);
Console.WriteLine(myClient.I);





public struct Client
{
    public Client(string nombre, string origen, double telefono, string direccion, string email, string informacion)
    {

        N = nombre;
        P = origen;
        T = telefono;
        D = direccion;
        E = email;
        I = informacion;

    }

    public string N { get; set; }
    public string P { get; set; }
    public double T { get; set; }
    public string D { get; set; }
    public string E { get; set; }
    public string I { get; set; }


    public override string ToString() => $"({N}, {P}, {T}, {D}, {E}, {I})";
}