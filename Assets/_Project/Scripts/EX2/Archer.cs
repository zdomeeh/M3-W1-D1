using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string nome, int vita) : base(nome, vita) { }

    public override void Attack(Character target)
    {
        int danno = 7;
        for (int i = 1; i <= 2; i++)
        {
            Debug.Log("Giocatore: " + Nome + " | Lancia freccia " + i + " su: " + target.Nome + " | Danno: " + danno);
            target.TakeDamage(danno);
        }
    }
}
