var lookSpeed : float = 5.0;
var verticalRotation : float = 0.0;
var horizontalRotation : float = 0.0;
var verticalRange : float = 60.0;

function Start () {
	Cursor.visible = false;
}

function Update () {
	horizontalRotation = Input.GetAxis("Mouse X") * lookSpeed;
	transform.Rotate(0, horizontalRotation, 0);

	verticalRotation -= Input.GetAxis("Mouse Y")  * lookSpeed;
	verticalRotation = Mathf.Clamp(verticalRotation, -verticalRange, verticalRange);
	
	Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
}