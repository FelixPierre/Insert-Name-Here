using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            // leave scene
        }
    }

    void Load() {
        GenerateMonsters();
        // Set players at their places
    }

    void GenerateMonsters() {
        int mobCount = Random.Range(0, 6) + 1;
        Debug.Log("fight with " + mobCount + " monsters");
    }
}
