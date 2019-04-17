using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : Entity
{
    public void Object() {
        this.Health += 20;
    }

    public void RunAway() {
        Debug.Log("Vous tentez de fuir, mais le code n'est pas implémenté");
    }
}
