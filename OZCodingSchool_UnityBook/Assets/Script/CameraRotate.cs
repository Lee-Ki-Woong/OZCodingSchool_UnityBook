using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float RotateSpeed; // 회전 속도

    //eulerAngles.x 의 값을 담아둘 변수
    float tempX = 0;

    // Update is called once per frame
    void Update()
    {
        // 마우스의 위아래 움직임 입력을 숫자로 받아서 저장
        float mouseMoveY = Input.GetAxis("Mouse Y");

        //마우스가 움직인 만큼 X축 회전
        tempX -= mouseMoveY * RotateSpeed * Time.deltaTime;

        //음수를 포함한 x의 각도를 -30º~ 30º로 제한
        tempX = Mathf.Clamp(tempX, -30, 15);

        //제한된 값을 eulerAngles.x에 적용 (y축과 z축은 고정되지 않고 현재 각도대로)
        transform.localRotation = Quaternion.Euler(tempX, transform.localRotation.eulerAngles.y, 0);
    }
}
