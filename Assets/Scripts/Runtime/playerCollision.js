#pragma strict

var explosion : GameObject;

function OnTriggerEnter(col : Collider)
{
    if (col.gameObject.tag == "EnemyLaser")
    {
        if(explosion)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}