using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// De olika korttyperna som anv�nds i spelet
/// </summary>
public enum CardType {
    Spell, 
    Weapon, 
    Minion
}

/// <summary>
/// Klassen som anv�nds f�r att skapa nya kort. Variabler kan �ndras manuellt i Editor tack vare ScriptableObject
/// </summary>
[CreateAssetMenu(menuName = "Card")]
public class Card : ScriptableObject
{
    public int health;
    public int attack;

    [Range(0, 10)]
    public int mana;

    public string name;
    public string description;

    public CardType cardType;
    public Sprite image;

}
