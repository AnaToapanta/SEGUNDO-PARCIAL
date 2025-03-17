using System;  
using System.Collections.Generic;  
using System.Text;

class Translator  
{  
    static Dictionary<string, string> dictionary = new Dictionary<string, string>  
    {  
        {"time", "tiempo"},  
        {"person", "persona"},  
        {"year", "año"},  
        {"way", "camino/forma"},  
        {"day", "día"},  
        {"blue", "azul"},  
        {"man", "hombre"},  
        {"world", "mundo"},  
        {"life", "vida"},  
        {"hand", "mano"},  
        {"part", "parte"},  
        {"child", "niño/a"},  
        {"eye", "ojo"},  
        {"woman", "mujer"},  
        {"place", "lugar"},  
        {"work", "trabajo"},  
        {"week", "semana"},  
        {"case", "caso"},  
        {"point", "punto/tema"},  
        {"government", "gobierno"},  
        {"sun", "sol"}  
    };  

    static void Main(string[] args)  
    {  
        while (true)  
        {  
            Console.WriteLine("\n𝕄𝔼ℕ𝕌");  
            Console.WriteLine("❁•❁•❁•❁•❁•❁•❁•❁•❁•❁•❁•❁•❁•❁•❁");  
            Console.WriteLine("1. 𝕋ℝ𝔸𝔻𝕌ℂ𝕀ℝ 𝕃𝔸 ℙ𝔸𝕃𝔸𝔹ℝ𝔸 ");  
            Console.WriteLine("2. 𝕀ℕ𝔾ℝ𝔼𝕊𝔸 𝕄𝔸𝕊 ℙ𝔸𝕃𝔸𝔹ℝ𝔸𝕊 𝔸𝕃 𝔻𝕀ℂ𝕀𝕆ℕ𝔸ℝ𝕀𝕆");  
            Console.WriteLine("0.  𝕊𝔸𝕃𝕀ℝ");  
            Console.Write("Seleccione una opción: ");  
            string option = Console.ReadLine();  

            switch (option)  
            {  
                case "1":  
                    TranslateSentence();  
                    break;  
                case "2":  
                    AddWords();  
                    break;  
                case "0":  
                    return;  
                default:  
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");  
                    break;  
            }  
        }  
    }  

    static void TranslateSentence()  
    {  
        Console.Write("Ingrese la frase: ");  
        string input = Console.ReadLine();  
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("La frase no puede estar vacía.");
            return;
        }

        string[] words = input.Split(' ');  
        StringBuilder translatedSentence = new StringBuilder();  

        foreach (string word in words)  
        {  
            string translatedWord = TranslateWord(word);  
            translatedSentence.Append(translatedWord + " ");  
        }  

        Console.WriteLine("Su frase traducida es: " + translatedSentence.ToString().Trim());  
    }  

    static string TranslateWord(string word)  
    {  
        // Traduce la palabra ignorando la capitalización  
        string lowerCaseWord = word.ToLower();  
        if (dictionary.ContainsKey(lowerCaseWord))  
            return lowerCaseWord == word ? dictionary[lowerCaseWord] : Capitalize(dictionary[lowerCaseWord]);  

        return word;  // Si no se encuentra la palabra, retorna la original  
    }  

    static string Capitalize(string word)  
    {  
        return char.ToUpper(word[0]) + word.Substring(1);  
    }  

    static void AddWords()  
    {  
        Console.Write("Ingrese la palabra en inglés: ");  
        string englishWord = Console.ReadLine();  

        Console.Write("Ingrese la traducción en español: ");  
        string spanishWord = Console.ReadLine();  

        if (!dictionary.ContainsKey(englishWord.ToLower()))  
        {  
            dictionary.Add(englishWord.ToLower(), spanishWord.ToLower());  
            Console.WriteLine("Palabra agregada al diccionario.");  
        }  
        else  
        {  
            Console.WriteLine("La palabra ya existe en el diccionario.");  
        }  
    }  
}