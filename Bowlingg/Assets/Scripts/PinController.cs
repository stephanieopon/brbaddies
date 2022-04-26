using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    public GameObject pin;
    private Vector3 pinLoc;
    public AudioClip pinSound;
    // Start is called before the first frame update
    void Start()
    {
        pin = GameObject.Find("Pin");
        pinLoc = pin.transform.position;
        GetComponent<AudioSource>().clip = pinSound;
    }

    // Update is called once per frame
    void Update()
    {
        pinLoc = pin.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bowling Ball")
        {
            AudioSource.PlayClipAtPoint(pinSound, pinLoc);
        }
    }
}
