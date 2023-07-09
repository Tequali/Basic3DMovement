using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateUI : MonoBehaviour
{
    public Rigidbody rb;
    public TMP_Text text;
    public float speed;
    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Round(rb.velocity.magnitude);
        text.text="Speed: " + speed;
    }
    
}
