using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManagerAstra : MonoBehaviour
{
    void Start()
    {
        // Lista di personaggi
        List<CharacterAstra> personaggi = new List<CharacterAstra>();

        personaggi.Add(new WarriorAstra("Thor", 100));
        personaggi.Add(new MageAstra("Merlino", 80));
        personaggi.Add(new ArcherAstra("Legolas", 90));

        // Ciclo per ogni personaggio
        foreach (CharacterAstra c in personaggi)
        {
            // Prima dell’attacco
            Debug.Log("PRIMA DELL'ATTACCO: " + c.nome + " | Vita: " + c.vita);

            // Attacca se ci sono almeno 2 personaggi
            if (personaggi.Count > 1)
            {
                CharacterAstra bersaglio = personaggi[Random.Range(0, personaggi.Count)];

                // Evito che uno attacchi se stesso
                while (bersaglio == c)
                {
                    bersaglio = personaggi[Random.Range(0, personaggi.Count)];
                }

                c.Attack(bersaglio);
            }

            // Dopo attacco
            Debug.Log("DOPO L'ATTACCO: " + c.nome + " | Vita: " + c.vita);

            // Ora subisce un danno random
            int dannoRandom = Random.Range(1, 21);

            Debug.Log("PRIMA DEL DANNO: " + c.nome + " | Vita: " + c.vita);
            c.TakeDamage(dannoRandom);
            Debug.Log("DOPO IL DANNO: " + c.nome + " | Vita: " + c.vita);
        }
    }

    void Update()
    {
        
    }
}
