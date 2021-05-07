using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rbPlayer;
    GameObject focalPoint;
    Renderer pRenderer;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        pRenderer = GetComponent<Renderer>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float magnitude = forwardInput * speed * Time.deltaTime;
        rbPlayer.AddForce(focalPoint.transform.forward * forwardInput * speed * Time.deltaTime, ForceMode.Impulse);

        if (forwardInput > 0)
            pRenderer.material.color = new Color(1.0f - forwardInput, 1, 1.0f - forwardInput);

        else
            pRenderer.material.color = new Color(1.0f + forwardInput, 1, 1.0f + forwardInput);

    }
}
