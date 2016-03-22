using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour
{
  void Start ()
  {
    rb = GetComponent<Rigidbody>();
  }
  void Update ()
  {
    Debug.log ("Flying")
    if (input.GetKeyDown ("f"))
    {
      rb.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
  }
}
