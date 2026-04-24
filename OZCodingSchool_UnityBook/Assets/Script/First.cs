using UnityEngine;

public class First : MonoBehaviour
{
    //인스펙터 창에서 관리할 수 있는 Transform 자료형의 변수
    public Transform tr;

    //자신의 Transform 컴포넌트를 담을 변수
    public Transform myTr;

    //자신의 GameObject 컴포넌트를 담을 변수
    public GameObject myG;

    //Directional Light의 Light 컴포넌트를 담을 변수
    public Light DLlight;

    //Main Camera를 검색해서 담을 변수1
    public GameObject findCamera1;

    //Main Camera를 담을 변수2
    public GameObject findCamera2;

    void Start()
    {
        //자신의 Transform 컴포넌트를 가져와 변수에 할당
        myTr = GetComponent<Transform>();
        myTr = transform;

        //자신의 GameObject 컴포넌트를 가져와 변수에 할당
        myG = gameObject;

        //Directional Light 컴포넌트를 가져와 변수에 할당
        DLlight = tr.GetComponent<Light>();

        //Main Camera를 이름으로 검색해 변수에 할당
        findCamera1 = GameObject.Find("Main Camera");

        //자식 오브젝트 중 Main Camera를 검색한 후
        //GameObject 컴포넌트를 가져와 변수에 할당
        findCamera2 = transform.Find("Main Camera").gameObject;

    }
}
