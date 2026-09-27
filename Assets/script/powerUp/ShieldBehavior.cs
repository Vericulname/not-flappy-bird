using System.Collections;
using UnityEngine;

public class ShieldBehavior : Item
{

    public float duration;



    protected override void OnCollect(GameObject player)
    {
        player.GetComponent<playerScript>().isShieldActive = true;
    }
}
