using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int score;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Hit")
        {
            return;
        }
        score++;
        Debug.Log("You've bumped into a thing this times : "+score);
    }
}
