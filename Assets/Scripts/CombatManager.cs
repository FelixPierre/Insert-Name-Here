using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public GameObject players;
    public GameObject enemies;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Cursor cursor;

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
        DeployPlayers();
    }

    void GenerateMonsters() {
        int mobCount = Random.Range(0, 6) + 1;
        Debug.Log("fight with " + mobCount + " monsters");
    }

    void DeployPlayers() {
        int teamSize = 4;
        float playerSpacing = 1.2f;
        for (int i = 0; i < teamSize; i++) {
            Vector2 position = new Vector2(4, (teamSize - 1) / 2f - i * playerSpacing);
            GameObject o = Instantiate(playerPrefab, players.transform);
            o.transform.localPosition = position;
            cursor.Add(o.GetComponent<Entity>());
        }
    }
}
