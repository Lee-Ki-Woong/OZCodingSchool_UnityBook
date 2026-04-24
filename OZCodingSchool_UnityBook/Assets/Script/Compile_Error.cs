using UnityEngine;

public class Compile_Error : MonoBehaviour
{
    //public 상태의 할당하지 않은 변수
    public GameObject Target2;
    
    //public 상태가 아닌 할당하지 않은 변수
    GameObject Target;
    void Start()
    {
        //배열의 범위를 벗어난 인덱스 사용 : IndexOutOfRangeException 에러
        int[] array = { 1, 2, 3 };
        print(array[10]);

        //public 상태의 할당하지 않은 변수의 값 출력 : UnassignedReferenceException 에러
        print(Target2.name);

        //public 상태가 아닌 할당하지 않은 변수의 값 출력 : NullReferenceException 에러
        print(Target.name);
    }
}
