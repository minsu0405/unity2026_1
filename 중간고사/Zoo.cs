using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //제시 객체 생성 이름 소리 값 부여
        Animal Jessi = new Animal();
        Jessi.name = "제시";
        Jessi.sound = "야용";


        //톰 객체 생성 이름 소리 값 부여
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "망망";

        //동물의 PlaySound()함수 실행
        Jessi.PlaySound();
        tom.PlaySound();

    }

 
}
