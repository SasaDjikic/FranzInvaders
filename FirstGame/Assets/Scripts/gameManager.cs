using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public int score;
    public bool gameOver;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
}
