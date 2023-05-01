using System;

namespace Static;

public class MonCache : ICache
{
    ///SERA CREE DES LE PREMIER APPEL A LA METHODE STATIQUE
    private static List<string> data = new();
    public static void AddValue(string value)
    {
        data.Add(value);
    }

    public static IEnumerable<string> GetValues()
    {
        return data;
    }
}

///RECUPERE LA LISTE DE DONNEES OU AJOUTE UNE DONNEE AU CACHE
public interface ICache
{
 static abstract IEnumerable<string> GetValues();
 static abstract void AddValue(string value);

}
