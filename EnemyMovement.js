#pragma strict

function Start () {
	
}

 var targ: GameObject;
 targ = GameObject.FindWithTag("Player");

function Update () {
    
   
    transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .03);
    
}