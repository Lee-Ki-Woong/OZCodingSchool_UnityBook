using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        //마우스 좌클릭을 누르는 순간
        if (Input.GetMouseButtonDown(0))
        {
            // "안녕" 이라는 문자열 출력
            print("안녕");
        }

        if(Input.GetKey(KeyCode.W))
        {
            //플레이어 캐릭터 앞으로 이동
        }
    }
}
