using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestory : MonoBehaviour
{
   public AudioSource a;
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        a = gameObject.GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    bool changed = false;
        void Update()
    {
        if(SceneManager.GetActiveScene().name == "Fight_Final" && !changed)
        {
            changed = true;
            a.clip = ac;
            a.Play();

        }
        
    }
}
