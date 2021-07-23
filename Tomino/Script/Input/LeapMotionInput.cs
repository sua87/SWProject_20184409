// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Leap;
// using Tomino;

// public class leapMotionInput : IPlayerInput
// {
//     Controller controller;
//     List<float> mo = new List<float>();
//     public GameObject cube;
//     float HandPalmPitch;
//     int num = 0;

//     public PlayerAction? GetPlayerAction()
//     {
//         if (controller.IsConnected)
//         { 
//             Frame frame = controller.Frame(); //The latest frame
//             Frame previous = controller.Frame(1); //The previous frame
//             for (int h = 0; h < frame.Hands.Count; h++)
//             {
//                 Hand leapHand = frame.Hands[0];
//                 Hand previous_leapHand = previous.Hands[0];
//                 Vector handOrigin = leapHand.PalmPosition;
//                 Vector previoushandOrigin = previous_leapHand.PalmPosition;
//                 HandPalmPitch = leapHand.PalmNormal.Pitch;
//                 if (System.Math.Abs(handOrigin.x - previoushandOrigin.x) > 5 && System.Math.Abs(leapHand.PalmVelocity.x) > 30)
//                 {
//                     Debug.Log("휘두름");
//                     mo.Add(1);
//                     int lastcount = mo.Count;
//                     if(mo[lastcount-2] != mo[lastcount-1])
//                     {
//                         action[1];
//                     }
//                 }
//                 else
//                 {
//                     mo.Add(0);
//                 }
//             }
//         }

//         if (Input.GetKeyUp(pressedKey))
//         {
//             Cancel();
//         }
//         else
//         {
//             return GetActionForRepeatedKey();
//         }

//         return null;
//     }

//     public void Cancel()
//     {

//     }

//     void Start()
//     {
//         mo.Clear();
//         controller = new Controller();
//     }

//     public void Update()
//     {
//         if (controller.IsConnected)
//         { 
//             Frame frame = controller.Frame(); //The latest frame
//             Frame previous = controller.Frame(1); //The previous frame
//             for (int h = 0; h < frame.Hands.Count; h++)
//             {
//                 Hand leapHand = frame.Hands[0];
//                 Hand previous_leapHand = previous.Hands[0];
//                 Vector handOrigin = leapHand.PalmPosition;
//                 Vector previoushandOrigin = previous_leapHand.PalmPosition;
//                 HandPalmPitch = leapHand.PalmNormal.Pitch;
//                 if (System.Math.Abs(handOrigin.x - previoushandOrigin.x) > 5 && System.Math.Abs(leapHand.PalmVelocity.x) > 30)
//                 {
//                     Debug.Log("휘두름");
//                     mo.Add(1);
//                     int lastcount = mo.Count;
//                     if(mo[lastcount-2] != mo[lastcount-1])
//                     {
//                         action[1];
//                     }
//                 }
//                 else
//                 {
//                     mo.Add(0);
//                 }
//             }
//         }
//     }

//     public void PrintActivateMessage()
//     {
//         print("A");
//     }

//     public void PrintDeactivateMessage()
//     {
//         if(HandPalmPitch > 1.4f)
//         {
//             Color[] co = new Color[3];
//             co[0] = Color.red;
//             co[1] = Color.blue;
//             co[2] = Color.green;
//             cube.GetComponent<MeshRenderer>().material.color = co[num % 3];
//             num++;
//         }

//     }
// }