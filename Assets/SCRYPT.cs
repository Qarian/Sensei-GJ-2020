using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S = UnityEngine.SerializeField;

public class SCRYPT : MonoBehaviour
{
    [S] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         transform.position =  new Vector3( transform.position.x, transform.position.y, 0);

         if(Input.GetKeyDown(KeyCode.Mouse0))
         {
             animator.SetTrigger("trigger");
         }
    }
}
