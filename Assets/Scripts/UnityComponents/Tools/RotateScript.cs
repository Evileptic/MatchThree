using UnityEngine;

namespace MatchThree
{
    public class RotateScript : MonoBehaviour
    {
        public bool X, Y, Z;
        public bool ReverseX, ReverseY, ReverseZ;
        public Space RotateSpace;
        public float Speed;

        void Update()
        {
            float x = X ? (ReverseX ? Speed : -Speed) * Time.deltaTime : 0;
            float y = Y ? (ReverseY ? Speed : -Speed) * Time.deltaTime : 0;
            float z = Z ? (ReverseZ ? Speed : -Speed) * Time.deltaTime : 0;
            transform.Rotate(x, y, z, RotateSpace);
        }
    }
}
