using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager라는 유니티 도구를 사용하기 위함

public class StartSceneManager : MonoBehaviour
{
    //Start 버튼을 클릭하면 호출
    public void OnClickStart()
    {
        //GameScene 라는 이름의 씬 불러오기 (씬 전환)
        SceneManager.LoadScene("GameScene");
    }
}
