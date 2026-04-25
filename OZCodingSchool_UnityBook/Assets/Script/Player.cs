using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_moveSpeed; //이동 속도

    void Update()
    {
        //방향키 또는 WASD 입력을 숫자로 받아서 저장
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // x축에는 h의 값을, z축에는 v의 값을 넣은 변수 생성
        Vector3 dir = new Vector3(h, 0, v);

        //모든 방향의 속도가 동일하도록 정규화
        dir.Normalize();

        //이동할 방향에 원하는 속도 곱하기
        //transform.position += dir * m_moveSpeed;

        // x축에는 h의 값을, z축에는 v의 값을 계속 더하기
        //transform.position += new Vector3(h, 0, v) * m_moveSpeed;

        // 이동할 방향에 원하는 속도 곱하기 (모든 기기에서 동일한 속도)
        transform.position += dir * m_moveSpeed * Time.deltaTime;
    }
}
