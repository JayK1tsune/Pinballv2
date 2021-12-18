using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int bumperScore;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pinball")
        {
            ScoreKeep.Score += bumperScore;
        }
    }
}
