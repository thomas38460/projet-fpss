﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clé : MonoBehaviour
{

    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
}

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Player")
        {
            Destroy(door);
            Destroy(gameObject);
        }



}
    // Update is called once per frame
    void Update()
    {
        
    }
}
