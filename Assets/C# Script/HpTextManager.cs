using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class HpTextManager : MonoBehaviour
{
    public Player player;
    int Hp;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = this.GetComponent<Text>();
        Hp = player.hp;
        _text.text = "Hp: " + Hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Hp = player.hp;
        _text.text = "Hp: " + Hp.ToString();
    }
}