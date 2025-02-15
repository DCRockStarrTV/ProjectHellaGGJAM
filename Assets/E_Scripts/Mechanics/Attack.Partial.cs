using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Attack : MonoBehaviour
{
    Movement myMovement;
    bool damageOnHit = false;

    private void FixedUpdate()
    {
        if (damageOnHit)
        {
            if (Physics.BoxCast(transform.position, new Vector3(.5f, .5f, .5f), Vector3.left, Quaternion.identity, .1f, 1 << 9))
            {
                print("Damage");
            }
        }
    }

    public void EnableDagameOnHit(bool shouldEnable = true)
    {
        damageOnHit = shouldEnable;
        myMovement = GetComponent<Movement>();  
        print("Push!!");
    }

    public void Slash(float dmg, bool buff = false)
    {
        print("Slash!!");
    }

    public void HeavySlash(float dmg, bool buff = false)
    {
        print("Heavy Slash!!");
    }

    public void Blow(float radious)
    {
        print("Blow");
    }

    public void Trhow_Thorns()
    {
        print("Thorns!!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
