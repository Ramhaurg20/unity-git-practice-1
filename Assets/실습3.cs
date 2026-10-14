using UnityEngine;

public class 실습3 : MonoBehaviour
{
    
    void Start()  //최초 한 번 실행되는 
    {
        int j = 1;
        while (true)
        {
            if (j > 5)
            {
                break;
            }
            Debug.Log(j);
            j++;
        }
        //    int k = 1;
        //`   while (k <= 10) 
        //    {
        //        if (k % 2 == 0) 
        //        { 
        //            k++; 
        //            continue; 
        //        } 
        //        Debug.Log(k);
        //        k++;
        //    }
    }

    
    void Update()  //매초 실행되는
    {
        
    }
}
