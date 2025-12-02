using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string nome, int vita) : base(nome, vita) { }


    public override void Attack(Character target) // Override di Attack: infligge 10 danni e stampa messaggio specifico
    {
        int danno = 10;
        Debug.Log("Giocatore: " + Nome + " | Colpisce con la spada: " + target.Nome + " | Danno: " + danno);
        target.TakeDamage(danno);
    }
}
