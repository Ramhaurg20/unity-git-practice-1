using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;    //public 외부 공용, private 비공개
    public GameObject Bulletprefab;  // 권한 타입 변수이름
    public float BulletSpeed = 100f;   // f == 타입

    //int[] scores = new int[5];

    void Start()
    {
        //for (int i = 1; i <= scores.Length; i++) 
        //    scores[i-1] = i*10;                         //for 문

        //Debug.Log(scores[0]); 
        //Debug.Log(scores[1]); 
        //Debug.Log(scores[2]); 
        //Debug.Log(scores[3]); 
        //Debug.Log(scores[4]);
        
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;
        /* transform.position = Vector3.one; */ // (1,1,1)의 좌표
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(Bulletprefab);     //class --> 객체를 만드는 애  instantiate --> (그걸)실체화 시키는 애
            Bullet.transform.position = transform.position;    //뒤에 트랜스폼.포지션 == 플레이어의 위치
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);     //너무 어려우니 AI한테 물어보기!

        }



        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.Translate(0, speed, 0);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    this.transform.Translate(0, -speed, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(-speed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(speed, 0, 0);
        //}
    }
}
