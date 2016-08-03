using UnityEngine;
using System.Collections;

public class CreateCapsules : MonoBehaviour
{
    public GameObject CapsuleObject;
    public int CapsulesCount = 10;

    void Start()
    {
        Create();
    }
    //  newCapsule.GetComponent<MeshRenderer>().material.color = Color.red;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            var allCapsules = GameObject.FindGameObjectsWithTag("Capsule");
            foreach (var c in allCapsules)
                Destroy(c);

            var x = GameObject.Find("GameObject");
            Create();
        }
    }

    private void Create()
    {
        if (CapsulesCount <= 0 || CapsuleObject == null)
            return;

        var radius = 6f;

        for (int i = 0; i < CapsulesCount; i++)
        {
            var newCapsule = GameObject.Instantiate(CapsuleObject);
            
            var angle = i * (2.0f * Mathf.PI / CapsulesCount);
            var x = Mathf.Cos(angle) * radius;
            var z = Mathf.Sin(angle) * radius;
            newCapsule.transform.position = new Vector3(x, 1, z);
        }
    }
}
