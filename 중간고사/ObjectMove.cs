using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    /*
    유니티6에서 오브젝트를 이동싵키는 대표적인 방법
    1. Transform.Translate()
    현재 위치를 기준으로 벡터값만큼 이동하려고 할때

    2. Transform.position
    오브젝트의 좌표를 직접 계산하여 설정하려고 할때

    */ 
    // 이동 속도
    public float speed = 5.0f;
    /*
    private float speed = 5.0f;

    [Serialized]
    private float speed = 5.0f;
    */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        //입력과 받기(키보드 화살표 또는 WASD)
        float h = Input.GetAxis("Horizontal"); //좌우
        float v = Input.GetAxis("Vertical"); //위 아래

        //현재 위치에서 이동할 만큼 더해줌
         Vector3 move = new Vector3(h, 0, v) * speed * Time.deltaTime;
         transform.position += move;
         /*이동 방향 계산
         Vector3 direction = new Vector3(h, v, 0); //2D 또는 3d 상하좌우
         Vector3 direction = new Vector3(h, 0, v);
        */
    }
}
