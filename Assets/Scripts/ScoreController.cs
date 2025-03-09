using TMPro;
using UnityEngine;
public class ScoreController : MonoBehaviour
{
    [SerializeField] int Score;
    [SerializeField] TextMeshProUGUI ScoreTx;
    public static ScoreController instance;
    

    void Awake()
    {
        instance=this;
        addScore(0);
    }
    public void addScore(int amount){
        Score+=amount;
        ScoreTx.text="Score:"+Score.ToString();
    }

}
