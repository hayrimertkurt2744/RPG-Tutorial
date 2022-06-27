using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon 
{
    PokemonBase _base;
    int level;

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base=pBase;
        level = pLevel;

    }
    //Stats based on the current level
    public int Attack
    {   //Stats based on the current level
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5; }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 10; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5; }
    }
    public int SpDefence
    {
        get { return Mathf.FloorToInt((_base.SpDefence * level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }
}
