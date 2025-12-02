using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherAstra : CharacterAstra
{
    public ArcherAstra(string nome, int vita) : base(nome, vita) { }

    public override void Attack(CharacterAstra target)
    {
        int danno = 7;

        for (int i = 1; i <= 2; i++)
        {
            Debug.Log("ATTACCO: " + nome + " scaglia freccia " + i + " su " + target.nome + " | Danno: " + danno);
            target.TakeDamage(danno);
        }
    }

    public override void TakeDamage(int damage)
    {
        int vitaPrima = vita;
        vita -= damage;
        if (vita < 0) vita = 0;

        Debug.Log("DANNO: " + nome + " subisce: " + damage + " | Vita: " + vitaPrima + " -> " + vita);
    }
}
