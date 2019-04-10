using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    #region Members

    public EntityStats baseStats;

    new string name;
    int level;

    int healthMax;
    int health;
    int manaMax;
    int mana;

    int physicalAtk;
    int physicalDef;
    int magicalAtk;
    int magicalDef;

    bool block;

    #endregion

    #region Properties

    public int Health {
        get {
            return health;
        }
        set {
            health = value;
            if (health < 0) {
                health = 0;
            }
            if (health > healthMax) {
                health = healthMax;
            }
        }
    }

    public int Mana {
        get {
            return mana;
        }
        set {
            mana = value;
            if (mana < 0) {
                mana = 0;
            }
            if (mana > manaMax) {
                mana = manaMax;
            }
        }
    }

    #endregion

    private void Start() {
        level = 1;
        name = baseStats.name;
        healthMax = health = baseStats.health;
        manaMax = mana = baseStats.mana;
        physicalAtk = baseStats.physicalAtk;
        physicalDef = baseStats.physicalDef;
        magicalAtk = baseStats.magicalAtk;
        magicalDef = baseStats.magicalDef;
    }

    #region Actions

    public void Attack(Entity target) {
        block = false;
        target.TakeDamage(physicalAtk, 0);
    }

    public void Defense() {
        block = true;
    }

    public void Skills(/*Skill skill,*/ Entity target) {
        block = false;
        target.TakeDamage(0, magicalAtk);
    }

    #endregion

    #region Private Methods

    void TakeDamage(int physicDamages, int magicDamages) {
        if (block) {
            return;
        }
        int damages = physicDamages - physicalDef + magicDamages - magicalDef;
        Health -= damages > 0 ? damages : 0;
    }

    #endregion
}
        