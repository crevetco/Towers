using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{
    
    public class CameraController : MonoBehaviour
    {
        //private bool doMovement = true;

        public float panSpeed = 30f;
        public float panBorderThockness = 10f;
        public float scrollSpeed = 5f;
        public float minY = 10f;
        public float maxY = 80f;

        private Vector3 startPos;


        private void Awake()
        {
            startPos = transform.position;
        }
        void Update()
        {
            if(GameManager.GameIsOver)
            {
                this.enabled = false;
                return;
            }
            if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThockness)
            {
                transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            }
            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThockness)
            {
                transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
            }
            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThockness)
            {
                transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
            }
            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThockness)
            {
                transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
            }
            if (Input.GetKey("f"))
            {
                transform.position = startPos;
            }

            float scroll = Input.GetAxis("Mouse ScrollWheel");

            Vector3 pos = transform.position;

            pos.y -= scroll * 1000 *scrollSpeed * Time.deltaTime;
            pos.y = Mathf.Clamp(pos.y, minY, maxY);


            transform.position = pos;
        }
    }
}