using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Mage(string nome, int vita) : base(nome, vita) { }

    public override void Attack(Character target) // Override di Attack: infligge 12 danni e stampa messaggio specifico
    {
        int danno = 12;
        Debug.Log("Giocatore: " + Nome + " | Lancia magia su: " + target.Nome + " | Danno: " + danno);
        target.TakeDamage(danno);
    }
}