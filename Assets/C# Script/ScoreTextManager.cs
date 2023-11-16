using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class ScoreTextManager : MonoBehaviour
{
    public Player player;
    int score;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = this.GetComponent<Text>();
        score = player.curScore;
        _text.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = player.curScore;
        _text.text = "Score: " + score.ToString();
    }
}
