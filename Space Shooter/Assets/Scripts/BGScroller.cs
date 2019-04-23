﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    private GameController gameControllerObj;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        gameControllerObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
       float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;

        if(gameControllerObj.winCondition == true)
        {
            if(scrollSpeed >= -10)
            {
                scrollSpeed -= Time.deltaTime;
            }
        }
    }
}
