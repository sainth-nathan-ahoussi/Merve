public class Carte
{
    public string carte_name { get; set; }
	public string carte_description { get; set; }
	public int use_cost { get; set; }

	
    public Carte(string _carte_name, string _carte_description, int _use_cost)
    {
        carte_name = _carte_name;
        carte_description = _carte_description;
        use_cost = _use_cost;  
    }  
    
    
    void appliquerEffet(Partie partie, Joueur joueur);
	/*En fonction du nom de la carte et de son Effet = {"Reveal", "Supp", "Pass", "Give"}, cela impacte le jeu*/
	
    void affichageDescriptionCarte()
    /* fonction membre permettant un affichage long d’une carte.*/
    {
        Console.WriteLine("Cette carte réalise "+ this.carte_description);
    }
}