/*using UnityEngine;

public class 실습4 : MonoBehaviour
{

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

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}*/



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
//    return age;
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