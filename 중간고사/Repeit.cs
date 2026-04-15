using System.Collections;
using UnityEngine;

public class Repeit : MonoBehaviour
{
    /*
    반복문 : for문 while문 switch문
    for 문
    -형식
    for (초기값;조건;갱신){
        //for 문 블록
        //조건이 참일 동안 이곳에 있는 코드를 실행
        }
        -초기값 : 주로 순번( Index)이 될 변수를 선언하고 초기값을 정의
        조건 : 어떤 조건에서 처리를 계속 반복할 지 정의
        갱신 : 한 회의 처리가 끝나면 순번을 어떻게 갱신할지 정의

     */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < 10; i++)
        {
            Debug.Log("i의 인덱스 값 : " + i);
            transform.position = new Vector3(i, 0, 0);
            //코루틴 추가
            StartCoroutine(PauseAndMove());
        }
    }
    IEnumerator PauseAndMove()
    {
        Debug.Log("멈춤");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("다시 시작");
    }
}
