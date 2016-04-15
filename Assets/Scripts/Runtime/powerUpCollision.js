#pragma strict

function Start () 
{
    
}

function Update () {

}
function OnTriggerEnter(col : Collider)
{
    if (col.gameObject.tag == "Player")
    {
        GameObject.Find("Player").GetComponent(fireScript).PowerUpLaser();
        
        

        Destroy(gameObject);
    }
}