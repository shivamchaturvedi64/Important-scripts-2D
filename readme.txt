BasicMovement2D Script....

This script allows the player to move left and right using the arrow keys or A and D keys on the keyboard,
and jump using the spacebar. The movement is implemented using the Rigidbody2D component and physics, allowing 
for realistic movement and collision detection.

Make sure to attach this script to your player object in the Unity Editor, and add a Rigidbody2D component to 
the object as well. You may also need to add a Collider2D component to the object and create a "Ground" object 
with a Collider2D component for the player to land on.


Fire2D Script.....
This script allows the player to fire a bullet using the left mouse button. The script uses the Instantiate() method to create a new instance of the bullet prefab at the position and rotation of the fire point. The script then gets a reference to the Rigidbody2D component of the bullet and adds force to it in the direction of the fire point using the AddForce() method.

Make sure to attach this script to your player object in the Unity Editor, and create a bullet prefab with a Rigidbody2D component and a Collider2D component for collision detection.


CharacterFlight2D Script.....
This script allows for random spawning of obstacles in a 2D game. The script uses the Random.Range() method to generate a random position for the obstacle within a specified range of x and y values. The script then uses the Instantiate() method to create a new instance of the obstacle prefab at the random position.

Make sure to attach this script to an empty game object in the Unity Editor, and create an obstacle prefab with a Collider2D component for collision detection. You can also adjust the spawn rate and position range values to customize the behavior of the script.
