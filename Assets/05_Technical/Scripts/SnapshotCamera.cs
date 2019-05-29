using UnityEngine;
 using System.Collections;

    public class SnapshotCamera : MonoBehaviour {

        public Camera snapCam;

       public int resWidth = 256;
       public int resHeight = 256;

        void Awake()
        {
    
        }

        public void CallTakeSnapshot()
        {
            snapCam = GetComponent<Camera>();
            snapCam.targetTexture = new RenderTexture( resWidth, resHeight, 24 );
            RenderTexture.active = snapCam.targetTexture;
            snapCam.Render();
            Debug.Log("Call taking Snapshot");
            snapCam.gameObject.SetActive(true);
            Texture2D snapshot = new Texture2D(resWidth, resHeight);
            snapshot.ReadPixels(new Rect(0, 0, snapCam.targetTexture.width, snapCam.targetTexture.height), 0, 0);
                            byte[] bytes = snapshot.EncodeToPNG();
                string fileName = SnapshotName();
                System.IO.File.WriteAllBytes(fileName, bytes);
            snapshot.Apply();
        }

        string SnapshotName()
        {
            return string.Format("{0}/Snapshots/snap_{1}x{2}_{3}.png",
            Application.dataPath,
            resWidth,
            resHeight,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));

        }
    }