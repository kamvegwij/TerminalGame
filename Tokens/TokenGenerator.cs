using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace How_Many_Of_Us.Challenges.Tokens
{
    public class GeneratedToken
    {
        public int randomisation;
        public float magnitude;
        public string tokenName; // Alpha - Ghost - Dark Arts

        WorldPosition currPos;
        public struct WorldPosition
        {
            public float X, Y, Z;
            public WorldPosition(float xPos, float yPos, float zPos)
            {
                X=xPos;
                Y=yPos;
                Z=zPos;
            }
        }
        public WorldPosition TokenPosition()
        {
            return currPos;
        }

        public GeneratedToken(float xPos, float yPos, float zPos, string name)
        {
            this.currPos = new WorldPosition(xPos, yPos, zPos);
            this.tokenName = name;
        }

        public string GetTokenPosition() 
        { 
            return (currPos.X.ToString() + ',' + currPos.Y.ToString() + ',' + currPos.Z.ToString()); 
        }
    }

}
