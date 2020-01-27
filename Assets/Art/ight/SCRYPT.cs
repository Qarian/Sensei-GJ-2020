using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S = UnityEngine.SerializeField;
using System.Diagnostics;
using UnityEngine.SceneManagement;


public class SCRYPT : MonoBehaviour
{
    [S] Animator animator = default;
    [S] Animator cameraAnimator = default;

    [S] BoxCollider2D bc2 = default;

    AudioSource a;

    public int enemiestogo = 2;
    private void Start() {
        bc2= gameObject.GetComponent<BoxCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        cameraAnimator = Camera.main.gameObject.GetComponent<Animator>();
        a = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if(enemiestogo<=0)
        {
            StartCoroutine(wait());
        }
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         transform.position =  new Vector3( transform.position.x, transform.position.y, 0);

         if(Input.GetKeyDown(KeyCode.Mouse0))
         {
             animator.SetTrigger("trigger");
             a.Play();
             bc2.enabled = true;
         }

    }
    
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.tag == "Enemy")
        {
            Destroy(other.gameObject);
            bc2.enabled = false;
            enemiestogo --;
        }
        if(other.transform.tag == "Adam")
        {
            if(enemiestogo<=1)
            {
            cameraAnimator.SetTrigger("trigger");
             gameObject.GetComponent<SpriteRenderer>().enabled = false;

            }
            // deb = path;
            // Process p = new Process();
            // ProcessStartInfo startInfo = new ProcessStartInfo(path+"/notmyfaultc.exe");
            // startInfo.Verb = "crash 0x01";
            // p.StartInfo = startInfo;
            // p.Start();
            //  string path = Application.streamingAssetsPath;
            // System.Diagnostics.Process.Start(path+ "/notmyfaultc.exe", " crash 0x01");
            //System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
            //Destroy(gameObject);
        }
    }

    public void CrashWin()
    {
        string path = Application.streamingAssetsPath;
        Process.Start(path+ "/notmyfaultc.exe", " crash 0x01");
    }
    public void hit()
    {
        bc2.enabled = false;
    }

    string deb;

    private void OnGUI() {
        GUI.Label(new Rect(0,0,100,1000),deb);
    }

}
