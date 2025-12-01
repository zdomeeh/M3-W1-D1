using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    void Start()
    {
        // Creo la lista di personaggi
        List<Character> characters = new List<Character>();

        // Aggiungo un personaggio per tipo
        characters.Add(new Warrior("Thor", 100));
        characters.Add(new Mage("Merlin", 80));
        characters.Add(new Archer("Legolas", 70));

        // Itero sui personaggi
        foreach (Character c in characters)
        {
            // Mostro vita iniziale
            Debug.Log("Prima dell'azione | Personaggio: " + c.Nome + " | Vita: " + c.Vita);

            // Il personaggio attacca un altro personaggio casuale nella lista (diverso da sé)
            Character target = c;
            while (target == c)  // Assicuro che non si attacchi da solo
            {
                target = characters[Random.Range(0, characters.Count)];
            }

            c.Attack(target);

            // Danno casuale subito
            int dannoSubito = Random.Range(1, 21);
            c.TakeDamage(dannoSubito);

            // Mostro vita finale
            Debug.Log("Dopo l'azione | Personaggio: " + c.Nome + " | Vita: " + c.Vita);
        }
    }

    void Update()
    {
        
    }
}
