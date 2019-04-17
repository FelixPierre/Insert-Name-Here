using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EntityStats", menuName = "EntityStats")]
public class EntityStats : ScriptableObject
{
    public new string name;
    public string description;

    public int health;
    public int mana;

    public int physicalAtk;
    public int physicalDef;
    public int magicalAtk;
    public int magicalDef;

    public int physicalAtkGain;
    public int physicalDefGain;
    public int magicalAtkGain;
    public int magicalDefGain;
}
