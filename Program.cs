using GestionStockGeneriqe.Classe;
DepotProduit<Produit> depot = new DepotProduit<Produit>();

depot.Add(new Produit { Nom = "PC", Prix = 1000 });
depot.Add(new Produit { Nom = "Souris", Prix = 50 });

Console.WriteLine($"Total : {depot.PrixTotal()}");
