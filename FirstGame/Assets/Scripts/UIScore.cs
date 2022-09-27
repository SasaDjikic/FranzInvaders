using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    private TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        textScore = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + gameManager.instance.score.ToString();
    }
}
