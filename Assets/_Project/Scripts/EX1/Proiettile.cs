using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proiettile
{
    public float velocita;
    public float gittata;

    public Proiettile(float velocita, float gittata)
    {
        this.velocita = velocita;
        this.gittata = gittata;
    }

    public virtual void Lancia()
    { 
    
    }
}
