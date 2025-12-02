using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProiettiliAstra : MonoBehaviour
{
   
    void Start()
    {
        List<ProiettileAstra> proiettili = new List<ProiettileAstra>();

        // Creo istanze delle classi derivate
        proiettili.Add(new FrecciaAstra(50f, 3));
        proiettili.Add(new FrecciaAstra(30f, 1));
        proiettili.Add(new PallaMagicaAstra(20f, 5));
        proiettili.Add(new PallaMagicaAstra(40f, 2));

        // Usando il polimorfismo, chiamo Lancia() su ogni proiettile.
        // L'esecuzione invoca l'override corretto in base al tipo reale dell'oggetto.
        foreach (ProiettileAstra p in proiettili)
        {
            p.Lancia();
        }
    }

   
    void Update()
    {
        
    }
}
