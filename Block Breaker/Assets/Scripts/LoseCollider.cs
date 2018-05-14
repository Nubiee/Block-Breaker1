using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    
    private LevelManager levelmanager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        print("Trigger");
        levelmanager.LoadLevel("Lose Screen");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
        levelmanager.LoadLevel("Win");
    }


}
