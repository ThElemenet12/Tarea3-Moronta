﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject pajarito;
    GameObject Pajarito;

    int count;
    float tamano;
    // Start is called before the first frame update
    void Start()
    {

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {   tamano = Random.Range(0.2f, 1.1f);
            Pajarito = Instantiate(pajarito, new Vector3(-14, Random.Range(2.2f, 5.2f)), Quaternion.identity);

            Pajarito.transform.localScale = new Vector3(tamano, tamano);
            count = 200;
        }
        count--;

    }
}
