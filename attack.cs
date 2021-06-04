using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    int hp = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Enter)
    {
        if(Enter.gameObject.tag == "enemy")
        {
            hp = hp - 1;
            if(hp!=0)
            {
                print("Ударил врага");
            }else{
                print("Враг убит");
            }
        }
    }
}
