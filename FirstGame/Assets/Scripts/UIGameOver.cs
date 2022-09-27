using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public AudioSource gameoverSound;
    private TextMeshProUGUI textGameOver;

    // Start is called before the first frame update
    void Start()
    {
        textGameOver = GetComponent<TextMeshProUGUI>();
        textGameOver.enabled = false;
        gameManager.instance.gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.instance.gameOver == true && textGameOver.enabled == false)
        {
            textGameOver.enabled = true;
            gameoverSound.Play();
        }
    }
}
