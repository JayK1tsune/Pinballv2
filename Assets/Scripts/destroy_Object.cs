using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_Object : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pinball")
        {
            Destroy(collision.gameObject);
        }
    }

}
