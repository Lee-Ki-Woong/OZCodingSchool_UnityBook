using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float RotateSpeed; // 회전 속도

    // Update is called once per frame
    void Update()
    {
        // 마우스의 위아래 움직임 입력을 숫자로 받아서 저장
        float mouseMoveY = Input.GetAxis("Mouse Y");

        //마우스가 움직인 만큼 X축 회전
        transform.Rotate(-mouseMoveY * RotateSpeed * Time.deltaTime, 0, 0);

        // x축의 각도 출력
        print(transform.eulerAngles.x);
    }
}
