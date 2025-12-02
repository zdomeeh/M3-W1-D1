using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Classe astratta
public abstract class CharacterAstra
{
    public string nome;
    public int vita;

    // Costruttore
    public CharacterAstra(string nome, int vita)
    {
        this.nome = nome;
        this.vita = vita;
    }

    // Metodi astratti che devono essere implementati nelle classi derivate
    public abstract void Attack(CharacterAstra target);
    public abstract void TakeDamage(int damage);
}
