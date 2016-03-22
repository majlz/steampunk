using UnityEngine;
using System.Collections;

public class HoverPad : MonoBehaviour
{
  void onTriggerEnter (Collider other)
  {
    Debug.log ("Do when inside")
  }
  
  void onTriggerStay (Collider other)
  {
    Debug.log ("Do when stay inside")
  }

void onTriggerExit (Collider other)
  {
    Debug.log ("Do when exit")
  }
}
