using UnityEngine;

public class PlayerCollector : MonoBehaviour
{ 
    public GameObject ExplodeCapsule = null;
    public GameObject ExplodePlayer;

    private void OnTriggerEnter(Collider other)
    {
        var capsule = other.gameObject;
        if (capsule.CompareTag("Capsule"))
        {
            if (ExplodeCapsule != null)
            {
                var explodeCapsule = Instantiate(ExplodeCapsule);
                explodeCapsule.transform.position = new Vector3(capsule.transform.position.x, capsule.transform.position.y - 1, capsule.transform.position.z);

                Destroy(explodeCapsule, 2);
            }

            Destroy(capsule);
        }
        if (capsule.CompareTag("Cube"))
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            if (ExplodePlayer != null)
            {
                var explodePlayer = Instantiate(ExplodePlayer);
                explodePlayer.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);

                Destroy(explodePlayer, 2);
            }
            Destroy(player);
        }
    }
}
