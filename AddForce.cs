using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour
{
  public float hoverForce = 12f;
  
  void Start ()
  {
    rb = GetComponent<Rigidbody>();
  }
  void Update ()
  {
    Debug.log ("Flying")
    if (input.GetKeyDown(KeyCode.F))
    {
      rb.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
  }
}
