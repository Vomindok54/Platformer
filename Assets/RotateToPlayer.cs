using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    GameObject plr;

    private void Start()
    {
        plr = GameObject.FindGameObjectWithTag("Player");       // In player prefab make sure the player has the "Player" tag
    }

    private void Update()
    {
        if(plr.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
    }
}