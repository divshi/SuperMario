using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
    private float XPos;
    private float YPos;
    private float ZPos;

    void Start()
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        ZPos = transform.position.z;
    }

    void OnTriggerEnter(Collider col)
    {
        GetComponent<Collider>().isTrigger = false;

        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(MoveAndResetPosition());
        }
    }

    IEnumerator MoveAndResetPosition()
    {
        transform.position = new Vector3(XPos, YPos + 0.2f, ZPos);
        yield return new WaitForSeconds(0.08f);
        transform.position = new Vector3(XPos, YPos, ZPos);
        yield return new WaitForSeconds(0.25f);
        GetComponent<Collider>().isTrigger = true;
    }
}
