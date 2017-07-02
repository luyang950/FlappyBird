using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockGenerator : MonoBehaviour {
    public GameObject rocks;

    // Use this for initialization
    void Start() {
        InvokeRepeating("GenerateRocks", 1f, 1f);
    }

    void GenerateRocks()
    {
        Instantiate(rocks);
    }
}
