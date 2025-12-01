using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
   public int numeroFrecceSimultanee;

   public Freccia(float velocita, float gittata, int numeroFrecceSimultanee)
         : base(velocita, gittata)
    {
         this.numeroFrecceSimultanee = numeroFrecceSimultanee;
    }

    public override void Lancia()
    {
        Debug.Log("FRECCIA LANCIATA!");
        Debug.Log("Sono state scoccate " + numeroFrecceSimultanee + " frecce simultanee.");
        Debug.Log("Velocità: " + velocita + " | Gittata: " + gittata);
    }
}
