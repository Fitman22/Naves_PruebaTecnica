using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  
  public void ChangeScene(int newScene){//scene 0:menu; scene1:Game;
    SceneManager.LoadScene(newScene);
  }
  public void Exit(){
    Application.Quit();
  }
}
