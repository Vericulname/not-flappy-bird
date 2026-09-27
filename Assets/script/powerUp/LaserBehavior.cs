using UnityEngine;

public class LaserBehavior : Item
{
    public float chargeTime;

    protected override void OnCollect(GameObject player)
    {
        player.GetComponent<playerScript>().isLaserActive = true;
    }
}
