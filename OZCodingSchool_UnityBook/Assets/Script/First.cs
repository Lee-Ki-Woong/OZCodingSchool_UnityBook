using UnityEngine;

public class First : MonoBehaviour
{
    //인스펙터 창에서 관리할 수 있는 Transform 자료형의 변수
    public Transform tr;

    //자신의 Transform 컴포넌트를 담을 변수
    public Transform myTr;

    //Directional Light의 Light 컴포넌트를 담을 변수
    public Light DLlight;

    void Start()
    {
        //자신의 Transform 컴포넌트를 가져와 변수에 할당
        myTr = GetComponent<Transform>();

        //Directional Light 컴포넌트를 가져와 변수에 할당
        DLlight = GetComponent<Light>();
    }
}
