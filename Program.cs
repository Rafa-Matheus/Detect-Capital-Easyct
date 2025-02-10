Console.WriteLine(@"
Digite uma palavra que atenda as seguintes condições:
 - Respeite qualquer um dos formatos:
    - GOOGLE, google ou Google
 - Só contenha letras maiúsculas e/ou minúsculas
 - Tenha de 1 a 100 caracteres
");

var word = Console.ReadLine() ?? string.Empty;