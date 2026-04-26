using UnityEngine;

public class Gun : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
