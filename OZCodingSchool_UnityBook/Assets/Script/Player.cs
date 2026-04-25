using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        //위아래 방향키 또는 W키와 S키 중 하나라도 누르고 있다면
        if(Input.GetButton("Vertical"))
        {
            // 플레이어 캐릭터 앞으로 이동
            print("아!");
        }
    }
}
