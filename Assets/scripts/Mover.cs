using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float moveSpeed= 40f;
     // Start is called before the first frame update
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Enjoy the game");
        Debug.Log("Rate the game");
    }

    void MovePlayer()
    {
        float  xvalue =Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float  zvalue =Input.GetAxis("Vertical")*Time.deltaTime *moveSpeed;
        transform.Translate(xvalue,0,zvalue);
    }

}
