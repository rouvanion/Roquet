using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRocket : MonoBehaviour
{
    public Rigidbody carRigideBody;
    [SerializeField] public float ForceFoward = 2000;
    [SerializeField] public float ForcePosition = 100;
    // Use this for initialization
    void Start()
    {
        carRigideBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ManageJumpInput();
        manageHorizontalInput();
    }

    private void ManageJumpInput()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            carRigideBody.AddRelativeForce(new Vector3(0, ForceFoward, 0));
        }
        else if (Input.GetAxis("Jump") < 0)
        {
            carRigideBody.AddRelativeForce(new Vector3(0, -ForceFoward, 0));
        }

    }
    private void manageHorizontalInput()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            carRigideBody.AddForceAtPosition(new Vector3(0, 0, ForcePosition),new Vector3());
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            carRigideBody.AddForceAtPosition(new Vector3(0, 0, -ForcePosition),new Vector3());
        }

    }
}