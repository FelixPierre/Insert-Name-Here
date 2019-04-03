using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTrigger : MonoBehaviour
{
    [Range(0,1)]
    public float fightThreshold;

    private bool combat = false;
    private float sleepTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Trigger());
    }
    
    void FixedUpdate()
    {
        // if player is moving, he may enter in combat
        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && Time.timeScale > 0) {
            //if (Random.value < fightThreshold) {
            //    Debug.Log("Tibilibibilibibilibi... vous entrez en combat");
            //}
        }
        //sleepTime = 1f / (Input.GetAxis("Sprint") > 0 ? 2 : 1);
        combat = false;
    }

    IEnumerator Trigger() {
        //Debug.Log("trigger called");
        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && Time.timeScale > 0) {
            if (Random.value < fightThreshold) {
                Debug.Log("Tibilibibilibibilibi... vous entrez en combat");
                combat = true;
            }
        }
        sleepTime = 1f / (Input.GetAxis("Sprint") > 0 ? 2 : 1);
        yield return new WaitForSeconds(sleepTime);
        if (!combat) {
            StartCoroutine(Trigger());
        }
    }
}
