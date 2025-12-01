using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public int maxRimbalzi;

    public PallaMagica(float velocita, float gittata, int maxRimbalzi)
        : base(velocita, gittata)
    {
        this.maxRimbalzi = maxRimbalzi;
    }

    public override void Lancia()
    {
        int rimbalzi = Random.Range(0, maxRimbalzi + 1);

        Debug.Log("PALLA MAGICA LANCIATA!");
        Debug.Log("Ha rimbalzato " + rimbalzi + " volte.");
        Debug.Log("Velocità: " + velocita + " | Altezza massima (gittata): " + gittata);
    }
}
