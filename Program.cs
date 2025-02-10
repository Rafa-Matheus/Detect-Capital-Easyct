Console.WriteLine(@"
Digite uma palavra que atenda as seguintes condições:
 - Respeite qualquer um dos formatos:
    - GOOGLE, google ou Google
 - Só contenha letras maiúsculas e/ou minúsculas
 - Tenha de 1 a 100 caracteres
");

var word = Console.ReadLine() ?? string.Empty;


var (isWordValid, errorMessage) = InputValidation(word);

if (!isWordValid)
{
    Console.WriteLine($"Erro: {errorMessage}");
}
else
{
    var solution = new Solution();
    string message = solution.DetectCapitalUse(word)
        ? $"A palavra \"{word}\" ATENDE as condições sobre o uso adequado de letras maiúsculas."
        : $"A palavra \"{word}\" NÃO ATENDE as condições sobre o uso adequado de letras maiúsculas.";

    Console.WriteLine(message);
}


static (bool isValid, string errorMessage) InputValidation(string word)
{
    if (word.Length < 1 || word.Length > 100)
        return (isValid: false, errorMessage: "A palavra deve conter de 1 a 100 caracteres.");
    else if (!word.All(char.IsLetter))
        return (isValid: false, errorMessage: "A palavra deve conter apenas letras.");
    else
        return (isValid: true, errorMessage: string.Empty);
}