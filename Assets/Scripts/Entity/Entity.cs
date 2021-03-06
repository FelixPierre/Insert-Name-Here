﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    #region Members

    public EntityStats baseStats;

    new string name;
    int level;

    int healthMax;
    int health;
    int manaMax;
    int mana;

    int physicAtk;
    int physicDef;
    int magicAtk;
    int magicDef;

    bool block;

    Vector3 selectionOffset = new Vector3(-0.5f, 0, 0);
    bool selected = false;

    #endregion

    #region Properties

    public string Name {
        get {
            return name;
        }
    }

    public int HealthMax {
        get {
            return healthMax;
        }
    }

    public int ManaMax {
        get {
            return manaMax;
        }
    }

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

    public int Level {
        get {
            return level;
        }
        set {
            LevelUp(value);
        }
    }

    public Vector3 Position {
        get {
            if (selected) {
                return transform.position - selectionOffset;
            }
            return transform.position;
        }
    }

    #endregion

    private void Start() {
        level = 1;
        name = baseStats.name;
        healthMax = health = baseStats.health;
        manaMax = mana = baseStats.mana;
        physicAtk = baseStats.physicalAtk;
        physicDef = baseStats.physicalDef;
        magicAtk = baseStats.magicalAtk;
        magicDef = baseStats.magicalDef;
    }

    #region Actions

    public void Attack(Entity target) {
        block = false;
        target.TakeDamage(physicAtk, 0);
    }

    public void Defense() {
        block = true;
    }

    public void Skills(/*Skill skill,*/ Entity target) {
        block = false;
        target.TakeDamage(0, magicAtk);
    }

    #endregion

    #region Public Methods

    public void Select() {
        selected = true;
        transform.position += selectionOffset;
    }

    public void Deselect() {
        selected = false;
        transform.position -= selectionOffset;
    }

    #endregion

    #region Private Methods

    void TakeDamage(int physicDamages, int magicDamages) {
        if (block) {
            return;
        }
        int damages = physicDamages - physicDef + magicDamages - magicDef;
        Health -= damages > 0 ? damages : 0;
    }

    void LevelUp(int newLevel) {
        int diff = newLevel - level;
        physicAtk += baseStats.physicalAtkGain * diff;
        physicDef += baseStats.physicalDefGain * diff;
        magicAtk += baseStats.magicalAtkGain * diff;
        magicDef += baseStats.magicalDefGain * diff;
        level = newLevel;
    }

    #endregion
}
        