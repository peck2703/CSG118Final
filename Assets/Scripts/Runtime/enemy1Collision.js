#pragma strict
var explosion : GameObject;

function Start () {

}

function Update () {

}
function OnTriggerEnter( col : Collider)
{
    if (col.gameObject.tag == "Laser")
    {
        Instantiate(explosion, transform.position, transform.rotation);

        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}