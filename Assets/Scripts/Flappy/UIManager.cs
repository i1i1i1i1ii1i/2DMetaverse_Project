using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI exitText;

    public void Start()
    {
        if (restartText == null)
        {
            Debug.LogError("재시작 텍스트가 빔");
        }

        if (scoreText == null)
        {
            Debug.LogError("점수 텍스트가 빔");
            return;
        }

        restartText.gameObject.SetActive(false);
        exitText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
        exitText.gameObject.SetActive(true);

    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

}
