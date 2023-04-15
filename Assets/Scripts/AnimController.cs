using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator animat;
    // Start is called before the first frame update
    void Start()
    {
        animat = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 3){
            animat.SetTrigger("Active");
        }
    }
}
