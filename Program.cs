// De standaardbibliotheek bevat generieke collecties voor elke situatie.
// Ze staan in de namespace System.Collections.Generic, die dankzij
// ImplicitUsings al beschikbaar is. Hieronder de vijf die je het meest
// gebruikt, met telkens de vraag: wanneer kies je welke?

// ---- List<T>: een geordende lijst, index-toegang, duplicaten toegestaan ----
List<string> boodschappen = ["brood", "melk", "brood"];
boodschappen.Add("kaas");
Console.WriteLine($"List: {boodschappen.Count} items, eerste = {boodschappen[0]}");
Console.WriteLine($"  bevat 'melk'? {boodschappen.Contains("melk")}");

// ---- Dictionary<TKey, TValue>: opzoeken op sleutel ----
// Gebruik dit als je waarden wil terugvinden via een unieke sleutel.
Dictionary<string, int> voorraad = new()
{
    ["appel"] = 5,
    ["peer"] = 3,
};
voorraad["appel"] += 2;
Console.WriteLine($"Dictionary: appels = {voorraad["appel"]}");

// TryGetValue vermijdt een exception bij een onbekende sleutel.
if (voorraad.TryGetValue("banaan", out int aantal))
{
    Console.WriteLine($"  bananen = {aantal}");
}
else
{
    Console.WriteLine("  geen bananen in voorraad");
}

// ---- HashSet<T>: unieke waarden, snel controleren op lidmaatschap ----
// Duplicaten worden genegeerd. Gebruik dit als je enkel wil weten of
// iets al gezien is, en de volgorde niet uitmaakt.
HashSet<string> bezochteSteden = ["Brussel", "Gent", "Brussel"];
bezochteSteden.Add("Antwerpen");
Console.WriteLine($"HashSet: {bezochteSteden.Count} unieke steden");
Console.WriteLine($"  al in Gent geweest? {bezochteSteden.Contains("Gent")}");

// ---- Queue<T>: eerst erin, eerst eruit (FIFO) ----
// Denk aan een wachtrij: wie eerst komt, wordt eerst geholpen.
Queue<string> wachtrij = new();
wachtrij.Enqueue("Ann");
wachtrij.Enqueue("Bob");
Console.WriteLine($"Queue: eerst aan de beurt = {wachtrij.Dequeue()}"); // Ann

// ---- Stack<T>: laatst erin, eerst eruit (LIFO) ----
// Denk aan een stapel borden: het laatste bord ligt bovenaan.
Stack<string> stapel = new();
stapel.Push("onder");
stapel.Push("boven");
Console.WriteLine($"Stack: bovenaan = {stapel.Pop()}");                 // boven
