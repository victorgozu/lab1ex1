/* Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
• Google: volumul paralelipipedului dreptunghic*/

Console.WriteLine("Introduceti valoare pentru latura A");
int laturaA = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoare pentru latura B");
int laturaB = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoare pentru latura C");
int laturaC = int.Parse(Console.ReadLine());

int volumulParalelipipedului = laturaA * laturaB * laturaC;

Console.WriteLine("Volumul paralelipipedului este "+ volumulParalelipipedului);

