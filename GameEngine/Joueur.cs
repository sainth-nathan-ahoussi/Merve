
using System.Collections.Generic;


public class Joueur
{
    public string username { get; set; }
    public int ranking_points { get; set; }
    public int hearts { get; set; }
    public int gamemoney { get; set; }
    public List<> CartesJouables { get; set; }
    public int damageDealt { get; set; }
    public bool hasUsedWordGuess { get; set; }
    public List<> lettresProposees { get; set; }
    public bool isCurrentTurn { get; set; }
    public bool isAlive { get; set; }
    public int maxHearts { get; set; }

    public Joueur(string _username, int _ranking_points, int _hearts, int _gamemoney, List<> _CartesJouables, int _damageDealt, bool _hasUsedWordGuess, List<> _lettresProposees, bool _isCurrentTurn, bool _isAlive,int _maxHearts)
    {
        username = _username;
        ranking_points = _ranking_points;
        hearts = _hearts; 
        gamemoney = _gamemoney;  
        CartesJouables = _CartesJouables; 
        damageDealt = _damageDealt;  
        hasUsedWordGuess = _hasUsedWordGuess;  
        lettresProposees = _lettresProposees;
        isCurrentTurn = _isCurrentTurn; 
        isAlive = _isAlive; 
        maxHearts = _maxHearts ;
    }  

    void affichageInfosJoueur()
    /*Fonction membre permettant l’affichage d’un joueur comme son username, ses ranking point et son nombre de gameMoney */
    {
        Console.WriteLine("Votre username est "+ this.username+ "Vous avez"+ this.ranking_points+" points et "+ this.gamemoney+ "en Game Money");
    }  

    bool ToujoursEnVie()
	/*Fonction membre qui dit si le joueur est toujours en vie ou non en regardant si son nombre de coeur est égale à 0 ou moins. */
    {
        return this.isAlive;
    }

	bool UtiliseWordGuess();
	/*Fonction membre qui permet d'utiliser la chance de donner le mot en entier une fois mais si il est faux le joueur perd tout ses coeurs.*/
	bool WrongGuess(Char Lettre)
    /*Fonction membre qui rajoute la lettre proposée fausse à la liste de lettre proposé */
    {
        this.lettresProposees.Add(Lettre);
        return true;
    }
	bool Possedecartes()
    /*Fonction membre booléenne pour savoir si un joueur a encore des cartes */
    {
        if(this.CartesJouables.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
	void jouentUneCarte(Joueur Joueur);
	/*Fonction membre qui met à jour la liste quand un joueur joue un carte et sonn nombre de coeur*/
	int NewRanking() ;
	/*Fonction membre qui met à jour le rang d'un joueur en fonction de si il gagne ou perd*/
	int HeartsDamage()
    /*Fonction membre qui permet de réduire le nombre de coeur en fonction de l'action du joueur ou de l'adversaire*/
    {
    }
	void TirageCarte(List<> Carte)
    /*Fonction membre permettant à joueur d’initialiser sa pile à partir d’un
	   * vecteur de cartes représentant une réserve*/
    {
        Random rnd = new Random();
        for (int i = 0; i <= 3; i++)
        {
            this.CartesJouables.Add(Carte[rnd.Next(4)]);
        }
    }

}