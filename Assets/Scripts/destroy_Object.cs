using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_Object : MonoBehaviour
{

    Renderer rend;

    [SerializeField] private Material myMaterial;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pinball")
        {
            rend.material.SetColor("Color", Color.red);
        }

        if (collision.gameObject.tag == "Pinball")
        {
            Destroy(collision.gameObject);
        }

     
       
    }




}
