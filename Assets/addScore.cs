using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class addScore : MonoBehaviour
{
    public int scoreValue = 10;
    public AudioClip scoreSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreManagement.Score++;
    }

    public void AddScorePoints(int points)
    {
        ScoreManagement.Score += points;
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AddScorePoints(scoreValue);
            //Destroy(this.gameObject);
           SoundManager.instance.PlaySound(scoreSound);

        }
    }
}
