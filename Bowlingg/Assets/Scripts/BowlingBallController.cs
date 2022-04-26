using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    public GameObject ball;
    private Vector3 ballLoc;
    public AudioClip ballSound;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Bowling Ball");
        ballLoc = ball.transform.position;
        GetComponent<AudioSource>().clip = ballSound;
    }

    // Update is called once per frame
    void Update()
    {
        ballLoc = ball.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ground")
        {
            AudioSource.PlayClipAtPoint(ballSound, ballLoc);
        }
    }
}
