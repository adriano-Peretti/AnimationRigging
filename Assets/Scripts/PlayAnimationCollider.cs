using UnityEngine;
using UnityEngine.Playables;

public class PlayAnimationCollider : MonoBehaviour
{
    [SerializeField] PlayableDirector director;
    [SerializeField] GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            director.Play();
        }
    }
}
