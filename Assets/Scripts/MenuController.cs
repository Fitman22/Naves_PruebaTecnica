using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  [SerializeField] GameObject menuControls;
  public void ChangeScene(int newScene){//scene 0:menu; scene1:Game;
    SceneManager.LoadScene(newScene);
  }
  public void Exit(){
    Application.Quit();
  }
  public void OpenControls(bool state){
      menuControls.SetActive(state);
  }
}
