using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_moveSpeed; //이동 속도

    void Update()
    {
        //방향키 또는 WASD 입력을 숫자로 받아서 저장
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // x축에는 h의 값을, z축에는 v의 값을 계속 더하기
        transform.position += new Vector3(h, 0, v) * m_moveSpeed;
    }
}
