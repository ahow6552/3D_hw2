using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Enemy_Con : MonoBehaviour
{
    GameObject player;
    public GameObject Normal;
    public GameObject Special;
    public GameObject Boss;
    bool StageSwitch1 = false;
    bool StageSwitch2 = false;
    public GameObject FinishGame;

    int Player_Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Instantiate(Normal, transform.position, Quaternion.identity);
        Player_Score = player.GetComponent<Player>().curScore;
    }

    // Update is called once per frame
    void Update()
    {
        Player_Score = player.GetComponent<Player>().curScore;
        if (Player_Score >= 1000)
        {
            if (StageSwitch1 == false)
            {
                Instantiate(Special, transform.position, Quaternion.identity);
                GameObject.Find("MidEnemyManager(Clone)").GetComponent<SpecialSpawnerManager>().curCoolDown+=3;

                StageSwitch1 = true;
            }
        }

        if (Player_Score >= 3000) 
        { 
            if(StageSwitch2 == false)
            {
                GameObject.Find("SpecialManager(Clone)").GetComponent<SpecialSpawnerManager>().Pause();
                GameObject.Find("MidEnemyManager(Clone)").GetComponent<SpecialSpawnerManager>().Pause();
                Instantiate(Boss, transform.position, Quaternion.identity);
                StageSwitch2 = true;
            }
        }

        if (StageSwitch2 == true && GameObject.Find("Boss(Clone)") == null && Player_Score >= 4500)
        {
            FinishGame.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
