using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;
        transform.position = Vector3.one;  // (1,1,1)ÀÇ ÁÂÇ¥

        Input.GetKey(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
