//There are 3 errors in this script
namespace Camera
{
    using UnityEngine;
    public class CameraAssigner : MonoBehaviour
    {
        [SerializeField]
        private CameraLerper cameraPrefab;
        private CameraLerper currentCamera;

        // Start is called before the first frame update
        void Start()
        {
            //Assigned camera
            if (cameraPrefab != null)
            {
                if (currentCamera == null)
                {
                    currentCamera = Instantiate(cameraPrefab);
                }
            }
              
            //Spawns camera in
            else 
            { 
                currentCamera = FindObjectOfType<CameraLerper>(); 
            }
            //Assigns camera
            if(currentCamera != null)
            {
                currentCamera.b = this.gameObject;
            }
        }
    }
}