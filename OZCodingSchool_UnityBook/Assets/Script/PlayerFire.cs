using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 총알 프리팹을 담아둘 변수
    public GameObject BulletPref;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 좌클릭을 누르는 순간
        if(Input.GetMouseButton(0))
        {
            // 게임 안에 리소스 폴더에서 불러오기한 총알 프리팹의 복사본 생성
            Instantiate(Resources.Load("Bullet"));
        }
    }
}
