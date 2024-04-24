using System;

namespace How_Many_Of_Us.Hacker
{
    public class Hackers
    {

        private int age;
        private float access;
        private string name;
        private string avatar;

        public Hackers(int defage, float defaccess, string defname, string defavatar)
        {
            age = defage;
            name = defname;
            access = defaccess;
            avatar = defavatar;
        }

        public int Age { get { return age; } set { age = value; } }
        public float Access { get { return access; } set { access = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Avatar { get { return avatar; } set { avatar = value; } }
    }
}
