using UnityEngine;

public class 실습4 : MonoBehaviour
{
    void Start()
    {
        Human Paul = new Human("paul", 3, 90);
        Baby baby = Paul as Baby;

        if (baby == null)
        {
            Debug.Log("형변환 실패");
        }

        else
        {
            Debug.Log("형변환 성공");
        }


        Adult maria = Adult("Alice", 26, 165.5f);

        maria.Age = 1;
        maria.SetBaseAge(2);

        Debug.Log(maria.Age);
        Debug.Log(maria.GetBaseAge());


        //Adult Jhon = new Adult("Jhon", 28, 173);
        //Baby Lisa = new Baby("Lisa", 3, 95);

        //Debug.Log(Jhon.age);
        //Lisa.Sleep();
    }
}

class Human
{
    public string name;
    public int age;
    public float height;
    protected string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return name; }
        set { name = value; }
    }
    public float Height
    {
        get { return height; }
        set { name = value; }
    }
    public int GetAge()
    {
        return age;
    }
    public void SetAge(int _age)
    {
        age = _age;
    }

    public Human()
    {

    }
    public Human(string _name, int _age, float _height)
    {
        name = _name;
        age = _age;
        height = _height;
    }
    public void Eat()
    {
        Debug.Log("eat");
    }
    public virtual void Walk()
    {
        Debug.Log("Walk");
    }
}

public class Adult : Human
{
    public Adult(string _name, int _age, float _height)
        : base(_name, _age, _height)
    {
        Age = _age;
    }

    public void PrintAddress()
    {
        Debug.Log(address);
    }

    public int Age;
    public void SetBaseAge(int age)
    {
        base.age = age;
    }

    public int GetBaseAge()
    {
        return base.age;
    }

}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}



//public class 실습4 : MonoBehaviour
//{
//    void Start()
//    {
//        Human Alice = new Human("Alice", 23, 160);

//        Debug.Log(Alice.name);
//        Debug.Log(Alice.age);
//        Debug.Log(Alice.height);

//    }

//    void Update()
//    {

//    }
//}

//public int Age
//{
//    get
//    {
//        return age;
//    }
//    set
//    {
//        Debug.Log(value);
//        age = value;
//    }
//}
//Human Alice = new Human("Alice", 213, 160);
//Alice.Age = 15;
//Debug.Log(Alice.Age);