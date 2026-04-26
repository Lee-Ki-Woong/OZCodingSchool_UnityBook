using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed; // 이동 속도
    public float JumpPower; // 점프하는 힘

    private Rigidbody m_rb; // 플레이어의 Rigidbody 컴포넌트

    private int m_jumpCount;// 점프한 횟수

    private void Start()
    {
        // 플레이어의 Rigidbody 컴포넌트를 가져와서 저장
        m_rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // 방향키 또는 WASD 입력을 숫자로 받아서 저장
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // x축에는 h의 값을, z축에는 v의 값을 넣은 변수 생성
        Vector3 dir = new Vector3(h, 0, v);

        // 모든 방향의 속도가 동일하도록 정규화
        dir.Normalize();

        // 이동할 방향에 원하는 속도 곱하기 (모든 기기에서 동일한 속도)
        transform.position += dir * MoveSpeed * Time.deltaTime;

        // <Space> 키를 누른 순간, 점프한 횟수가 2회 미만이라면
        if (Input.GetKeyDown(KeyCode.Space) && m_jumpCount < 2)
        {
            // 위로 순간적인 힘 발생
            m_rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);

            //점프할 때마다 점프 횟수 증가
            m_jumpCount++;
        }
    }

    //어떤 물체와 충돌을 시작한 순간에 호출
    private void OnCollisionEnter(Collision collision)
    {

        // 충돌한 물체의 태그가 "Ground"라면
        if(collision.gameObject.tag == "Ground")
        {
            // 점프 횟수 초기화
            m_jumpCount = 0;
        }
    }
}
