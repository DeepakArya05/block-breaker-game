using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{
   [Range(0.1f,10f)] [SerializeField] float GameSpeed = 1f;
    [SerializeField] int CurrentScore = 0;
    [SerializeField] int PointPerBlockDestroy = 10;
    [SerializeField] TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        ScoreText.text = CurrentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = GameSpeed;
    }
    
    public void AddToScore()
    {
        CurrentScore = CurrentScore + PointPerBlockDestroy;
        ScoreText.text = CurrentScore.ToString();
    }
    public void GameReset()
    {
        Destroy(gameObject);
    }
    

}
