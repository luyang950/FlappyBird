using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public Vector2 initPosition = new Vector2(-17, 0);

    // Use this for initialization
    void Start () {
        player.transform.position = initPosition;
        Instantiate(player);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
