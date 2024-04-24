using System;
using How_Many_Of_Us.Challenges.Tokens;
using static How_Many_Of_Us.Challenges.Tokens.GeneratedToken;

namespace How_Many_Of_Us.Managers
{
    public abstract class MathManager
    {
        //set math and physics rules:
        public static GeneratedToken.WorldPosition GetCrossProduct(GeneratedToken.WorldPosition obj1, GeneratedToken.WorldPosition obj2)
        {
            //(a,b,c)X(e,f,g) = (bg-cf, ce -ag, af-be)
            float x = (obj1.Y * obj2.Z) - (obj1.Z * obj2.Y);
            float y = (obj1.Z * obj2.X) - (obj1.X * obj2.Z);
            float z = (obj1.X * obj2.Y) - (obj1.Y * obj2.X);
            return new GeneratedToken.WorldPosition(x,y,z);
        }
        public static float GetDotProduct(GeneratedToken.WorldPosition obj1, GeneratedToken.WorldPosition obj2)
        {
            float x = obj1.X * obj2.X;
            float y = obj1.Y * obj2.Y;
            float z = obj1.Z * obj2.Z;
            return (x+y+z);
        }

        public float GetMagnitude(GeneratedToken.WorldPosition obj1, GeneratedToken.WorldPosition obj2)
        {
            float magnitude = 0f;
            return magnitude;
        }
    }
}
