//There are 3 errors in this script

namespace Camera
{
	#region usings
	using UnityEngine;
	using Blobby = UnityEngine.Vector3;
    
	#endregion
	public class CameraLerper : MonoBehaviour
    {
        private float i = 10f;
        private float k = 10f;

        public GameObject b;

        // Update is called every other frame
        void Update()
        {
            if (b != null)
            {
                //Moves camera
                this.transform.position = Blobby.Lerp(this.transform.position, new Blobby(b.transform.position.x, i, b.transform.position.z), Time.deltaTime * k);
            }
        }
    }
}