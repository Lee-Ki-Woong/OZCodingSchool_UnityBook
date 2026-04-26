using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 총알 프리팹을 담아둘 변수
    public GameObject BulletPref;
    public GameObject Gun;

    // 총알을 발사하는 힘
    public float firePower;

    private void Start()
    {
        // 마우스 커서를 안 보이게
        Cursor.visible = false;

        // 마우스 커서가 게임 화면을 벗어나지 못하도록 잠금
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // 마우스 좌클릭을 누르는 순간
        if (Input.GetMouseButtonDown(0))
        {
            // 게임 안에 리소스 폴더에서 불러오기한 총알 프리팹의 복사본 생성
            //Instantiate(Resources.Load("Bullet"));

            // 게임 안에 총알 프리팹의 복사본 생성 ( 플레이어의 위치보다 1 앞에 )
            // 생성 후 bullet 변수에 할당
            GameObject bullet = Instantiate(BulletPref, Gun.transform.position + Gun.transform.forward, Quaternion.identity);

            // 총알 복사본이 앞으로 날아가는 순간적인 힘 발생
            bullet.GetComponent<Rigidbody>().AddForce(Gun.transform.forward * firePower, ForceMode.Impulse);

            // 화면 가운데에서 시작하는 Ray 생성
            Ray ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));

            // Ray에 맞은 물체를 담아둘 변수
            RaycastHit hit;

            // Ray를 발사하고, Ray에 맞은 물체는 hit에 저장, 맞은 물체가 있을 때만 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 맞은 물체의 이름 출력
                print(hit.transform.name);
            }
        }
    }
}
