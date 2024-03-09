using UnityEngine;
using System.Collections;


public class PipeController : MonoBehaviour
{
    public GameObject PipeEntry;
    public int StoodOn;

    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject MainPlayer;

    void Start()
    {
        SecondCam.SetActive(true);
        MainCam.SetActive(false);
        MainPlayer.transform.position = new Vector3(11, -17, 0.5f);
    }

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("GoDown"))
        {
            if (StoodOn == 1)
            {
                //GameObject.Find("FPSController").GetComponent("FirstPersonController").enabled=false;
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeEntry.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2);
        PipeEntry.GetComponent<Animator>().enabled = false;
        //GameObject.Find("FPSController").GetComponent("FirstPersonController").enabled=true;
    }
}
