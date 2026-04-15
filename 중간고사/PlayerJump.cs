using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // 점프 힘 설정
    public float jumpFoce = 5.0f;
    private Rigidbody rb;
    private bool IsGround;//땅에 닿아있는 체크
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //오브젝트에 있는 Rigidbody 컴포넌트 가져오가
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스바를 누르고 땅에 닿아 있을 때 점프
        if(Input.GetButtonDown("Jump") && IsGround)
        {
            //위쪽 방향으로 힘을 즉시 가함
            rb.AddForce(Vector3.up*jumpFoce, ForceMode.Impulse);
            IsGround = false; // 점프 후 공중 상태
        }
    }
    // 땅에 닿았는지 체크 (바닥 오브젝트 태그가 맞닿아 있는지)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGround = true;
        }
       
    }
}
