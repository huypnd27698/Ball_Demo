using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    // Start is called before the first frame update

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

    }

    public string key_score = "score_save";

    public int level = 0;

    public string key_score_format = "score_save_";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("Save");
            Save(level, score);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Debug.Log("Load");
            Load(level);
        }
    }



    public void Save(int level, int score)
    {

        Debug.Log("Save level " + level + " " + score);
        PlayerPrefs.SetInt(key_score_format + level.ToString(), score);
        PlayerPrefs.Save();
    }

    public void Load(int level)
    {
        int scoreLoaded = PlayerPrefs.GetInt(key_score_format + level.ToString());
        score = scoreLoaded;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Load level score: " + level + " " + scoreLoaded);
        
    }
}
