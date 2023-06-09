using LibrairieConversionNote;

string lettrerentrer;



do
{
    Console.WriteLine("Bienvenue, veuillez rentrer une lettre entre A et G qui correspondent à une note.");


    lettrerentrer = Console.ReadLine();

    ConversionAlphabetiqueToNote.Transformer(lettrerentrer);



} while (lettrerentrer != "A" || lettrerentrer != "a" || lettrerentrer != "B" || lettrerentrer != "b" || lettrerentrer != "C" || lettrerentrer != "c" || lettrerentrer != "D" || lettrerentrer != "d" || lettrerentrer != "E" || lettrerentrer != "e" || lettrerentrer != "F" || lettrerentrer != "f" || lettrerentrer != "G" || lettrerentrer != "g");
