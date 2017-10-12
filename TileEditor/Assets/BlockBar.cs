using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBar : MonoBehaviour
{
    Transform player;

	void Start ()
    {
        player = transform.root;

        if(player.tag != "Player")
        {
            Debug.Log("The root transform of " + transform.name + " must have a tag of Player");
        }

        Debug.Log(player.name);

	}

	void Update () {
		
	}
}
