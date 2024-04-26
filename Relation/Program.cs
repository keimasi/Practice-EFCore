using Relation.Context;

var context = new DataBaseContext();

context.Database.EnsureDeleted();
context.Database.EnsureCreated();

Console.WriteLine("Done !");