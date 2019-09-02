using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Transform player;
    public Text highScore;
    void Start ()
    {
       highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    void Update()
    {
        if ((int) player.position.z > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", (int) player.position.z);
            highScore.text = player.position.z.ToString("0");
        }
    } 
}
