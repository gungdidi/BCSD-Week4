using UnityEngine;

public class MoveB7 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
   
    // Update is called once per frame
    void Update()
    {
        //1. MoveTowards
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 2f); 

        //2. SmoothDamp
        Vector3 velo = Vector3.zero;
        //Vector3 velo = Vector3.up * 50;

        transform.position =
            Vector3.SmoothDamp(transform.position, 
            target, 
            ref velo, 
            1f);
        

        //3. Lerp : 선형 보간, SmoothDamp보다 감속시간이 김, 값이 적을수록 느림
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        */

        //4. Slerp : 구면 선형 보간, Lerp보다 감속시간이 김, 값이 적을수록 느림
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);

    }
}
