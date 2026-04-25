using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        //방향키 또는 WASD 입력을 숫자로 받아서 저장
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(h, 0, v);
    }
}
