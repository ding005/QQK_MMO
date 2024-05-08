using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pudding
{
    public static class CheckBoundIsInCamera 
    {

        public static bool Check(this Bounds bounds, Camera camera)
        {
            System.Func<Vector4, int> computeQutCode = (pos) =>
            {
                int _code = 0;
                if (pos.x < -pos.w) _code |= 1;
                if (pos.x > pos.w) _code |= 2;
                
                if (pos.y < -pos.w) _code |= 4;
                if (pos.y > pos.w) _code |= 8;
                
                if (pos.z < -pos.w) _code |= 16;
                if (pos.z > pos.w) _code |= 32;
                return _code;
            };
            Vector4 worldPos = Vector4.one;
            int code = 63;
            for (int i = -1; i <=1; i+= 2)
            {
                for (int j = -1; j <=1; j+= 2)
                {
                    for (int k = -1; k <=1; k+= 2)
                    {
                        worldPos.x = bounds.center.x + i * bounds.center.x;
                        worldPos.y = bounds.center.y + j * bounds.center.y;
                        worldPos.z = bounds.center.z + k * bounds.center.z;

                        code &= computeQutCode(camera.projectionMatrix * camera.worldToCameraMatrix * worldPos);
                    }
                }
            }
            return code == 0;
        }
    }
}