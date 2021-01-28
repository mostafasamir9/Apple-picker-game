using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text score;
    public Text Highscore;
    public GameObject gg;
    string s = " ";
    public int points = 0;
    static int hs = 1000;
    private void Awake()
    {

        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            hs = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", hs);
    }
     void Start()
    {
        score.text = "ds";
        Highscore.text = hs.ToString();
    }

     void Update()
    {
        if (Basket.point)
        {
            points += 100;

            s = points.ToString();
            score.text = s;
            Basket.point = false;

            PlayerPrefs.SetInt("ApplePickerScore", points);

        }

        if (points > hs )
        {
            hs = points;
            Highscore.text = hs.ToString();
        }
        
        if (hs > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", hs);
        }
    }

    public void IncreasePoints()
    {
        points += 100;
        s = points.ToString();
        score.text = s;

    }

}
