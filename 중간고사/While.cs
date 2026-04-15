using UnityEngine;

public class While : MonoBehaviour
{
    /*
     * 초기값;
    while(조건){
        while 문 실행
        while 조건
    
    } 


     */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;

        while (i < 10) {
            Debug.Log(i + "번째 루프입니다");
            i++; // 증가
            // i-- 얜 감소
            transform.position = new Vector3(i,0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
