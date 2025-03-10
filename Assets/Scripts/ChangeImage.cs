
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField] Sprite image1,image2;
    public bool isActive=true;
    public SoundController sound;
    void Start()
    {
         if(PlayerPrefs.HasKey("Sound")){
            int valueSound=PlayerPrefs.GetInt("Sound");
            if(valueSound==0)isActive=true;
            else isActive=false;
            GetComponent<Image>().sprite= isActive ? image1 : image2;
         }
    }
    public void changeImage(){
        isActive=!isActive;
        sound.SoundCheck(isActive);
        GetComponent<Image>().sprite= isActive ? image1 : image2;
        if(isActive)  PlayerPrefs.SetInt("Sound",0);
        else   PlayerPrefs.SetInt("Sound",1);
    }
}
