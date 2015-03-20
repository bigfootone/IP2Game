#pragma strict

function Start () {
	
}

 var targ: GameObject;

function Update () {
    
    transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .03);
    
}