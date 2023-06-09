namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote


    {


        public static void Transformer(string lettresalphabétique)
        {
            lettresalphabétique = lettresalphabétique.ToUpper();

            if (lettresalphabétique == "A")
            {
                Console.WriteLine("LA");
            }
            else if (lettresalphabétique == "B")
            {
                Console.WriteLine("SI");
            }
            else if (lettresalphabétique == "C")
            {
                Console.WriteLine("DO");
            }
            else if (lettresalphabétique == "D")
            {
                Console.WriteLine("RÉ");
            }
            else if (lettresalphabétique == "E")
            {
                Console.WriteLine("MI");
            }
            else if (lettresalphabétique == "F")
            {
                Console.WriteLine("FA");
            }
            else if (lettresalphabétique == "G")
            {
                Console.WriteLine("SOL");
            }
            else
            {
                Console.WriteLine("Veuillez entrez une lettre entre A et G");
            }
        }

    }
}