using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float Health = 0f;
    public float MaxHealth = 0f;
    private bool canDie = false;
    private bool isDead = false;
    public float AttackDamage = 0f;
    public float AttackSpeed = 1.4f;
    [SerializeField]
    private GameObject AttackSpawn = null;
    [SerializeField]
    private GameObject BulletPrefab = null;
    private float AttackTimeRemaining = 0f;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        isDead = canDie = false;
    }

    void Update()
    {
        if (canDie && !isDead && Health <= 0)
            Die();
        if (Input.GetKeyDown(KeyCode.Mouse0) && AttackTimeRemaining <= 0)
        {
            Debug.Log("pew pew");
            Instantiate(BulletPrefab, AttackSpawn.transform.position, Quaternion.identity);
        }

    }
    void Die()
    {
        isDead = true;
    }

}
