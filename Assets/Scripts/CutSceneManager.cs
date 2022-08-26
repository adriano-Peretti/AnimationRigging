using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    public Transform finalPosition;



    public void SetPlayerPosition(Transform playerTransform)
    {



        playerTransform.position = finalPosition.position;
        playerTransform.rotation = finalPosition.rotation;
    }
}
