using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
    public static int Score = 0;
  
    void OnGUI()
    {
        GUI.Box(new Rect(300, 100, 100, 100), Score.ToString());
    }
}

