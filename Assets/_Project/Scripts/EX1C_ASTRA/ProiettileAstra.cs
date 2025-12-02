using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProiettileAstra // Classe astratta
{
    public float velocita; // velocità del proiettile

    public ProiettileAstra(float velocita) // Costruttore base per inizializzare la velocità
    {
        this.velocita = velocita;
    }

    public abstract void Lancia(); // Metodo astratto dove le classi derivate devono implementarlo

}
