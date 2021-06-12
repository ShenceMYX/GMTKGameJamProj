using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ns
{
    /// <summary>
    /// 
    /// </summary>
    public class AABBCollision
    {
        public static bool CollisionDetect(Rect recA, Rect recB)
        {
            return (recA.right > recB.left && recB.right > recA.left && recA.bottom > recB.top && recB.bottom > recA.top);
        }

        //recA's right colliding with recB's left
        public static bool RightCollisionDetect(Rect recA, Rect recB)
        {
            return (recA.right > recB.left && recA.left < recB.left //A on right of B
                    && recA.top < recB.bottom && recA.bottom > recB.top);

        }

        //recA's bottom colliding with recB's top
        public static bool DownCollisionDetect(Rect recA, Rect recB)
        {
            return (recA.bottom > recB.top && recA.top < recB.top //A on bottom of B
                    && recA.left < recB.right && recA.right > recB.left);
        }
    }

}