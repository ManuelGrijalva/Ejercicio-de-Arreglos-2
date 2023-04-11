
void arreglos()
{
    String[] nombre = new string[]
{
    "Fernanda", "Melvin", "Luis", "Brandon", "Yamileth"
};

    int[] notas = new int[]
    {
    70,90,43,85,30
    };

    int notaMasAlta = notas[0];
    int indiceNotaMasAlta = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaMasAlta)
        {
            notaMasAlta = notas[i];
            indiceNotaMasAlta = i;
        }
    }
    Console.WriteLine($"La nota más alta es del alumn@ {nombre[indiceNotaMasAlta]} con una nota de: {notaMasAlta}");
};
arreglos();