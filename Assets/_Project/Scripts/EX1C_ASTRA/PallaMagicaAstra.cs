using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagicaAstra : ProiettileAstra
{
    public int maxRimbalzi;

    public PallaMagicaAstra(float velocita, int maxRimbalzi) : base(velocita)
    {
        this.maxRimbalzi = maxRimbalzi;
    }

    public override void Lancia()
    {
        int rimbalzi = Random.Range(0, maxRimbalzi + 1);
        Debug.Log("PALLA MAGICA LANCIATA! Rimbalzi: " + rimbalzi + " | Velocità: " + velocita);
    }
}
