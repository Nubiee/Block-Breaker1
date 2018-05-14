using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private LevelManager levelmanager;
    public Sprite[] hitSprites;
    private int timesHit;
    void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            HandleHits();
        }

    }
    void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }



    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
    void SimulateWin()
    {
        levelmanager.LoadNextLevel();
    }

    // Use this for initialization
    void Start () {
        timesHit = 0;
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
