using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageAstra : CharacterAstra
{
    public MageAstra(string nome, int vita) : base(nome, vita) { }

    public override void Attack(CharacterAstra target)
    {
        int danno = 12;
        Debug.Log("ATTACCO: " + nome + " lancia una magia su " + target.nome + " | Danno: " + danno);
        target.TakeDamage(danno);
    }

    public override void TakeDamage(int damage)
    {
        int vitaPrima = vita;
        vita -= damage;
        if (vita < 0) vita = 0;

        Debug.Log("DANNO: " + nome + " subisce: " + damage + " | Vita: " + vitaPrima + " -> " + vita);
    }
}