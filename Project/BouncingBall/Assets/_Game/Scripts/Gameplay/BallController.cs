using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public TextMeshProUGUI TextField;
    public GameObject GameOverPanel;
    public Animator Animator;
    
    public float HorizontalForceMin;
    public float HorizontalForceMax;

    private int points;

    private void Start()
    {
        points = 0;
        TextField.text = points.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        var random = Random.Range(HorizontalForceMin, HorizontalForceMax);

        Rigidbody.AddForce(new Vector3(random, 0f, 0f), ForceMode.Impulse);

        if (other.collider.CompareTag("Player"))
        {
            points++;
            TextField.text = points.ToString();
            
            Animator.SetTrigger("Bounce");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            GameOverPanel.SetActive(true);
        }
    }
}
