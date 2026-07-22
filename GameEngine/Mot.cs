public class Mot
{
	string word { get; set; }
    public List<char> lettresRevelees { get; set; }
    public List<char> lettresIncorrectes { get; set; }
    public string indice { get; set; }
    public string indiceSecondaire { get; set; }

	
    public Mot(string _word, List<char> _lettresRevelees, List<char> _lettresIncorrectes, string _indice, string _indiceSecondaire)
    {
        word = _word;
        lettresRevelees = _lettresRevelees;
        lettresIncorrectes = _lettresIncorrectes;  
        indice = _indice;  
        indiceSecondaire = _indiceSecondaire;  
    }  
    
    void showFirstHint();
    /*Fonction montrant le premier indice */

    void showSecondHint();
    /*Fonction montrant le deuxième indice */

    bool containsLetter(char lettre);
    /*Fonction verifiant si oui ou non le mot à deviner contient la lettre donner par le joueur.*/
    void revealLetter(char lettre);
    /*Fonction qui renvoie la lettre si elle fait partie du mot ou non / Peut aussi être utiliser pour afficher la lettre indice. */
    bool isFullyDiscovered();
    /*Fonction qui verifie si le mot a completement été révélé ou non en comparant la liste de charactère révélee avec le mot.r*/
    String getMaskedWord();
    /*Fonction qui renvoie le mot une fois qu'il a été trouvé.*/
}