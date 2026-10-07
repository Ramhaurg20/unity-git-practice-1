using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroySelf", 2.0f);     //2초뒤에 'DestroySelf'을 실행해라
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
