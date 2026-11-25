//using UnityEngine;

//public class Enemy1 : Enemy
//{
//    private void Start()
//    {
//        Move();
//    }
//    void Move()
//    {
//        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50);
//    }

//}
using UnityEngine;

public class Enemy1 : Enemy
{
    [Header("이동 설정")]
    public float downSpeed = 2.5f;        // 아래 방향 정속도
    public float horizontalSpeed = 2.0f;  // 좌우 이동 속도
    public float turnInterval = 1.5f;     // 방향 전환 주기(초)

    [Header("좌우 이동 제한 (월드 X 좌표)")]
    public float minX = -2.2f;
    public float maxX = 2.2f;

    private Rigidbody2D rb;
    private int horizontalDir = 1;        // -1: 왼쪽, 0: 없음, 1: 오른쪽
    private float turnTimer = 0f;

    [Header("화면 밖 삭제")]         
    public float destroyY = -6f;      

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        PickRandomHorizontalDir();
    }

    private void Update()
    {
        turnTimer += Time.deltaTime;
        if (turnTimer >= turnInterval)
        {
            turnTimer = 0f;
            PickRandomHorizontalDir();
        }
        if (transform.position.y < destroyY)     
        {                                       
            Destroy(gameObject);                 
        }                                        
    }

    private void FixedUpdate()
    {
        Move();
    }

    // 부모 Enemy의 move()를 오버라이드하려면 Enemy 쪽도 public virtual void Move()로 맞추는 것이 좋아요.
    public override void move()
    {
        Move();
    }

    private void Move()
    {
        // 좌우 경계에 닿으면 반대 방향으로 즉시 전환
        if (transform.position.x <= minX && horizontalDir < 0)
        {
            horizontalDir = 1;
        }
        else if (transform.position.x >= maxX && horizontalDir > 0)
        {
            horizontalDir = -1;
        }

        Vector2 targetVelocity = new Vector2(horizontalDir * horizontalSpeed, -downSpeed);

        if (rb != null)
        {
            rb.linearVelocity = targetVelocity;
        }
        else
        {
            transform.position += (Vector3)(targetVelocity * Time.fixedDeltaTime);
        }
    }

    private void PickRandomHorizontalDir()
    {
        // -1(좌), 0(정지/직진), 1(우) 중 랜덤 선택
        horizontalDir = Random.Range(-1, 2);
    }
}