using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        print(v);
    }
}
