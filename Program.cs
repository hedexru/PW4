namespace PW4
{
    internal class Program
    {
        class Spell
        {
            public int Mana { get; set; }
            public string Effect { get; set; }
            public string Name { get; set; }

            public Spell (int mana, string effect, string name)
            {
                Mana = mana;
                Effect = effect;
                Name = name;
            }
            public void Use()
            {
                Console.WriteLine( Effect );
            }
        }
        class Magician
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }

            public Magician (string name, int mana)
            {
                Name = name;
                Mana = mana;
            }

            public void CastSpell(Spell spell)
            {
                if (Mana >= spell.Mana)
                {
                    Console.Write(Name);
                    Console.Write(" колдует ");
                    spell.Use();
                    Mana -= spell.Mana;
                }
                else
                {
                    int howMuchNeeds = spell.Mana - Mana ;
                    Console.Write("Для использования ");
                    Console.Write(spell.Name);
                    Console.Write(" необходимо еще ");
                    Console.Write(howMuchNeeds);
                    Console.WriteLine(" маны");
                }
            }

        }
        static void Main(string[] args)
        {
            Spell pivo = new Spell(50, "литр пивка!", "Хлебнуть пивка");
            Spell vodka = new Spell(60, "литр водки!", "Хлебнуть водки");

            Magician AleksandrVasilevich = new Magician("Александр Васильевич", 100);

            AleksandrVasilevich.CastSpell(pivo);
            AleksandrVasilevich.CastSpell(vodka);

        }
    }
}