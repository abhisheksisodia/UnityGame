using UnityEngine;
using System.Collections;

public class CreateDangerousCap : MonoBehaviour
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
    }

    private void Create()
    {
        if (CapsulesCount <= 0 || CapsuleObject == null)
            return;

        var radius = 6f;

        for (int i = 0; i < CapsulesCount; i++)
        {
            var newCapsule = GameObject.Instantiate(CapsuleObject);
            newCapsule.GetComponent<Renderer>().material.color = Color.red;

            var x = Random.Range(-8.0f, 8.0f);
            var z = Random.Range(-8.0f, 8.0f);
            newCapsule.transform.position = new Vector3(x, 1, z);
        }
    }
}