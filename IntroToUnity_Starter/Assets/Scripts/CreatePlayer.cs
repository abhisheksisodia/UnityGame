using UnityEngine;
using System.Collections;

public class CreatePlayer : MonoBehaviour
{

    public GameObject PlayerObject;

    // Use this for initialization
    void Start ()
    {
        Create();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            var playerCapsule = GameObject.FindGameObjectWithTag("Player");
            Destroy(playerCapsule);

            var x = GameObject.Find("GameObject");
            Create();
        }
    }

    private void Create()
    {
       var newPlayer = GameObject.Instantiate(PlayerObject);
       newPlayer.transform.position = new Vector3(0, 3, 0);
    }
}
