  #pragma strict
    var target : Transform;
    
    function Start () {
    
    target = GameObject.FindWithTag("Player").transform;
    }
    
    function Update () 
    {
     
	transform.LookAt(transform.position + new Vector3(0,0,1), target.transform.position - transform.position);  
	}