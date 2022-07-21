using UnityEngine;

namespace DefaultNamespace
{
    public class Ball : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Vector2 _startDirection;
        [SerializeField] private Pad _pad;
        
    

        #endregion
        
        #region Public methods
        
        public void MoveWithPad()
        {
            Vector3 padPosition = _pad.transform.position;
            Vector3 currentPosition = transform.position;
            currentPosition.x = padPosition.x;
            transform.position = currentPosition;

        }

        public void StartMove()
        {
            _rb.velocity = _startDirection;

        }

        #endregion
    }
}