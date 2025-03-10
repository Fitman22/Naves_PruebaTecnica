using TMPro;
using UnityEngine;

public class OptionsGame : MonoBehaviour
{
 public static OptionsGame instance;
[SerializeField] GameObject pauseMenu,loseMenu;
    void Awake()
    {
        instance=this;
        pauseMenu.SetActive(false);
        loseMenu.SetActive(false);
        Time.timeScale=1;
    }
    public void pause(bool IsPause)
    {
        pauseMenu.SetActive(IsPause);
        Time.timeScale = IsPause ? 0f:1f;
    }
    public void Lose(){
        Invoke("loseActive",2f);
    }
    void loseActive()
    {
          loseMenu.SetActive(true);
        ScoreController.instance.SaveScore();
        pause(true);
    }
}
