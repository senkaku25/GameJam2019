﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = Vector3.Slerp(transform.position,
                new Vector3(player.transform.position.x - 10, player.transform.position.y + 10, player.transform.position.z - 10),
                2f * Time.deltaTime);
        }
    }
}
