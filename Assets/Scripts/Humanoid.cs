using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fungerar som huvudklass f�r spelaren och fienden. En klass f�r "personer"
/// </summary>
public class Humanoid : MonoBehaviour
{

    public List<GameObject> cardObjects = new List<GameObject>();
    public List<GameObject> mercenaries = new List<GameObject>();

    public int health;
    public int attack;
    public int armor;
    public int heroPowerMana;

    /// <summary>
    /// Konstruktor f�r Humanoid
    /// </summary>
    public Humanoid()
    {

    }

    /// <summary>
    /// Metod d�r spelaren eller fienden attackerar motsatta sidan
    /// </summary>
    /// <param name="index1">Index p� den som skadar (positivt f�r mercenaries, negativt f�r hero)</param>
    /// <param name="index2">Index p� den som blir skadad (positivt f�r mercenaries, negativt f�r hero)</param>
    public virtual void Attack(int index1, int index2) { }

    /// <summary>
    /// Metod som drar ett nytt kort till handen
    /// </summary>
    public virtual void DrawCard() { }

    /// <summary>
    /// Metod f�r att anv�nda ens "Hero Power"
    /// </summary>
    /// <param name="heroPowerName">Namnet p� f�rm�gan</param>
    public virtual void UseHeroPower(string heroPowerName)
    {

    }

    /// <summary>
    /// Metod f�r att skada n�gon utan att sj�lv bli skadad
    /// </summary>
    /// <param name="index">Index f�r den mercenary (eller hero) som ska bli skadad</param>
    /// <param name="dmg">Antal Health som f�rloras</param>
    public virtual void DealDamage(int index, int dmg) { }

}
