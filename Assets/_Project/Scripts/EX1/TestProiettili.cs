using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProiettili : MonoBehaviour
{
    void Start()
    {
        List<Proiettile> proiettili = new List<Proiettile>();

        // Creo 2 frecce e 2 palle magiche
        proiettili.Add(new Freccia(50f, 75f, 3));
        proiettili.Add(new Freccia(30f, 40f, 1));

        proiettili.Add(new PallaMagica(20f, 10f, 5));
        proiettili.Add(new PallaMagica(40f, 25f, 2));

        // Lancio tutti i proiettili
        foreach (Proiettile p in proiettili)
        {
            p.Lancia();
        }
    }

    void Update()
    {
        
    }
}
