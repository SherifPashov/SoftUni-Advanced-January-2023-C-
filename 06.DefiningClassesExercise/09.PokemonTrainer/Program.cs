using _09.PokemonTrainer;


    
   List<Trainer> trainers = new();
string command;

while ((command = Console.ReadLine()) != "Tournament")
{
       

       string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

       Trainer trainer = trainers.SingleOrDefault(t => t.Name == tokens[0]);

       if (trainer == null)
       {
           trainer = new(tokens[0]);
           trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
           trainers.Add(trainer);
       }
       else
       {
           trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
       }
}


    

   while ((command = Console.ReadLine()) != "End")
   {
       
       foreach (var trainer in trainers)
       {
           trainer.CheckPokemon(command);
       }
   }

   foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
   {
       Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
   }
  