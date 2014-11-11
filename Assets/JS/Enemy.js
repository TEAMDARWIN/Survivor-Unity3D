// The target marker.
var target: Transform;

// Angular speed in radians per sec.
var speed: float;

function Update () {
	var targetDir = target.position - transform.position;
	
    // The step size is equal to speed times frame time.
    var step = speed * Time.deltaTime;
    
    var newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0);
    Debug.DrawRay(transform.position, newDir, Color.red);
    // Move our position a step closer to the target.
    transform.rotation = Quaternion.LookRotation(newDir);
}