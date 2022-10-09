// See https://aka.ms/new-console-template for more information
using Act1_Video_game;

Personaje mono = new Personaje();

mono.mensaje();
mono.Anexo = "Y este es el amigo.";

Console.WriteLine(mono.Mensaje2 + "Ok.");
Console.WriteLine(mono.Anexo);

mono.ambos();

Console.ReadKey();