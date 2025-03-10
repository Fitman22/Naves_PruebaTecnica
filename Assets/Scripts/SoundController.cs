using UnityEngine;

public class SoundController : MonoBehaviour
{
    void Awake()
    {
        if(!PlayerPrefs.HasKey("Sound")){
            PlayerPrefs.SetInt("Sound",0);
         }
         else{
            int valueSound=PlayerPrefs.GetInt("Sound");
            if(valueSound==0) SoundCheck(true);
            else SoundCheck(false);
         }
        
    }
    public void SoundCheck(bool isActive){
            AudioListener.volume = isActive ? 1f:0f;
        
    }
}
