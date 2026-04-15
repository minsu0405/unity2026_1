using UnityEngine;

public class Animal : MonoBehaviour
{
    //변수 
    public string name;
    public string sound;


   //함수
   public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }

}
