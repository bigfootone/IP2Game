#pragma strict


 var targ: GameObject;
 targ = GameObject.FindWithTag("Player");
 
function Start () {
transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .5);

}


    
function Update () {

}