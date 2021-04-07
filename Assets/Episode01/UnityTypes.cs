using UnityEngine;

namespace Episode01
{
    public class UnityTypes : MonoBehaviour
    {
        //Vector2 Holds 2 Floats
        private Vector2 _vector2 = new Vector2(0, 0);
    
        //Vector3 holds 3 Floats
        private Vector3 _vector3 = new Vector3(0, 0, 0);

        //Quaternion holds 4 floats! 
        private Quaternion _quaternion = new Quaternion(0, 0, 0, 0);
        
        //A Box Collider is mostly just two Vector2s, One first denotes the location of the box,
        //and one denotes the length and the width of the box.
        private BoxCollider2D _boxCollider2D = new BoxCollider2D();
        
        //A color is just 3 Floats. Red, Green, and Blue.
        private Color color;
    
        //Transform holds a bunch Vector3s, a Quaternion and even a reference to a Parent (also a Transform)
        private Transform _transform;
    }
}
