using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = (transform.right * (CharacterMovement.Instance.m_FacingRight ? 1 : -1)) * 20f;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
