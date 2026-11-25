using UnityEngine;

class Knight: ISword, IShield
{
    public string Damage { get; set; }
    public string DefensivePower { get; set; }
    public void Attack() 
    {
    }
    public void Defend() 
    {
    }
}
interface ISword
{ 
    public string Damage { get; set; } 
    public void Attack(); 
}
interface IShield
{
    public string DefensivePower { get; set; }
    public void Defend();
}

public class 실습6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
