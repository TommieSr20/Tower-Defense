using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CharacterBase

{
    public float speed;
    public float xSpeed;
    public float ySpeed;

    public GameObject thisObject;
    public float xDir = 0f;
    public float yDir = 0f;


    public GameManager manager;


    public float reverseTime;
    public float reverseInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(xSpeed, ySpeed);
        speed = Random.Range(
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
