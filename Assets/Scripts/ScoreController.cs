using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ScoreController : MonoBehaviour
{
    [SerializeField] int Score;
    [SerializeField] List<TextMeshProUGUI> ScoreTx,BestScore;
    public static ScoreController instance;
    

    void Awake()
    {
        instance=this;
        addScore(0);
        if(!PlayerPrefs.HasKey("Score"))  PlayerPrefs.SetInt("Score",Score);
        SaveScore();
    }
    public void addScore(int amount){
        Score+=amount;
        foreach(TextMeshProUGUI tx in ScoreTx){
            tx.text="Score:"+Score.ToString();
        }
       
    }
    public int getBestScore(){
        return PlayerPrefs.GetInt("Score");
    }

    public void SaveScore(){

        if(Score>getBestScore()){
        PlayerPrefs.SetInt("Score",Score);
        PlayerPrefs.Save();  
        }
           foreach(TextMeshProUGUI tx in BestScore){
            tx.text="Best Score:"+getBestScore().ToString();
        }
    }
}
