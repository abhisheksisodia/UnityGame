using UnityEngine;

public class PlayerCollector : MonoBehaviour
{ 
    public GameObject ExplodeCapsule = null;
    public GameObject ExplodePlayer;
    public GameObject PlayerObject = null;

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
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            Destroy(player);

            var newCapsule = GameObject.Instantiate(PlayerObject);
        }
    }
}
