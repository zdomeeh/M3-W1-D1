using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecciaAstra : ProiettileAstra // Classe derivata: Freccia
{
    public int numeroFrecceSimultanee;

    public FrecciaAstra(float velocita, int numeroFrecceSimultanee) : base(velocita)
    {
        this.numeroFrecceSimultanee = numeroFrecceSimultanee;
    }

    // Implementazione obbligatoria del metodo astratto
    public override void Lancia()
    {
        Debug.Log("FRECCIA LANCIATA! Numero frecce: " + numeroFrecceSimultanee + " | Velocità: " + velocita);
    }
}
