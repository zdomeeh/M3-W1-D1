using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Nome { get; private set; } // Nome del personaggio
    public int Vita { get; private set; }    // Punti vita del personaggio

    // Costruttore: inizializza nome e vita
    public Character(string nome, int vita)
    {
        Nome = nome;
        Vita = vita;
    }

    // Metodo virtuale Attack: infligge 1 danno di default
    public virtual void Attack(Character target)
    {
        int danno = 1;
        Debug.Log("Giocatore: " + Nome + " | Attacca: " + target.Nome + " | Danno: " + danno);
        target.TakeDamage(danno);
    }

    // Metodo per subire danno
    public void TakeDamage(int danno)
    {
        int vitaIniziale = Vita;
        Vita -= danno;

        if (Vita < 0) Vita = 0;

        Debug.Log("Personaggio: " + Nome + " | Subisce danno: " + danno + " | Vita iniziale: " + vitaIniziale + " | Vita attuale: " + Vita);
    }
}
