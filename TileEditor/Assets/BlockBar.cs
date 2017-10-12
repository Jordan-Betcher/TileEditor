using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBar : MonoBehaviour
{
    Transform player;
    Tile[] tiles;

	void Start ()
    {
        tiles = new Tile[0];
        player = transform.root;

        if(player.tag != "Player")
        {
            Debug.Log("The root transform of " + transform.name + " must have a tag of Player");
        }

        Debug.Log(player.name);

	}

    private void FixedUpdate()
    {
        tiles = this.GetComponentsInChildren<Tile>();
    }

    void Update ()
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                setPlayerSelect(tiles[i]);
                break;
            }
        }
	}

    private void setPlayerSelect(Tile selected)
    {

    }
}
