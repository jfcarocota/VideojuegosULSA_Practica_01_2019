using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Movement
{
    public class Movement
    {
        /// <summary>
        /// This function returns a Vector2 Axis of Horixontal and Vertical Inputs.
        /// </summary>
        public static Vector2 Axis
        {
            get
            {
                return new Vector2(Input.GetAxis("Horizontal"), 
                    Input.GetAxis("Vertical"));
            }
        }

        /// <summary>
        /// This function returns a Vector2 Axis of Horizontal and Vertical Inputs multiplied by Delta Time.
        /// </summary>
        public static Vector2 AxisDelta
        {
            get
            {
                return new Vector2(Input.GetAxis("Horizontal"),
                    Input.GetAxis("Vertical")) * Time.deltaTime;
            }
        }

        /// <summary>
        /// Moves the player in Horizontal multiplied by speed variable.
        /// </summary>
        /// <param name="t">Transform component of the player</param>
        /// <param name="speed">The move speed of the player</param>
        public static void SimpleMovement(Transform t, float speed)
        {
            t.Translate(Vector2.right * Axis.x * speed);
        }

        /// <summary>
        /// Moves the player in Horizontal multiplied by speed variable
        /// and Delta Time.
        /// </summary>
        /// <param name="t">Transform component of the player</param>
        /// <param name="speed">The move speed of the player</param>
        public static void DeltaMovement(Transform t, float speed)
        {
            t.Translate(Vector2.right * AxisDelta.x * speed);
        }
    }
}
