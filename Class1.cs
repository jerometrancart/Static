using System;

namespace Static
{
    public class Class1
    {
        public void AjouterElement()
        {
            MonCache.AddValue("Depuis class1");
        }
    }

    public class Class2
    {
        public void AjouterElement()
        {
            MonCache.AddValue("Depuis class2");
        }
    }
}
