#pragma strict

var laser : GameObject;
var fireFrequency : float;
private var lastShot : float;
var audioFile : AudioSource;

var laserType : int;
private var laserTimer : float;

function Start()
{
    audioFile = GetComponent.<AudioSource>();
}
function Update () 
{
    if(Input.GetMouseButton(0) && (Time.time > lastShot + fireFrequency))
    {
        Fire();
        laserTimer -= Time.time / 10;
        if (laserTimer < 0)
        {
            laserType = 0;
        }
        print(laserTimer);
    }
}
function Fire()
{
    lastShot = Time.time;
    
    if (laserType == 0)
    {
        Instantiate(laser, transform.position, transform.rotation);
    }
    else if (laserType == 1)
    {
        Instantiate(laser, transform.position, Quaternion.Euler(Vector3( 0, 0, -40 )));
        Instantiate(laser, transform.position, Quaternion.Euler(Vector3( 0, 0, -20 )));
        Instantiate(laser, transform.position, transform.rotation);
        Instantiate(laser, transform.position, Quaternion.Euler(Vector3( 0, 0, 20 )));
        Instantiate(laser, transform.position, Quaternion.Euler(Vector3( 0, 0, 40 )));
    }

}
function PowerUpLaser()
{
    laserType++;
    print("PowerUpLaser");
    audioFile.Play();
    laserTimer = 5;
    laserType = Mathf.Clamp(laserType, 0, 1);
}