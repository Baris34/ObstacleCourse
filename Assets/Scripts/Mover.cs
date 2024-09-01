using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    void Start()
    {
        PrintInformation();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInformation()
    {
        Debug.Log("Hello,this is a game!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
