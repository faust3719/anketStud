﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anketStud
{
    class user
    {
        public string name;
        public string group;
        public string spec;
        public int groupid;
        public int specid;
        public int groupTime;

        public user(string n, string g, string s, int gid, int sid, int gTime)
        {
            name = n;
            group = g;
            spec = s;
            groupid = gid;
            specid = sid;
            groupTime = gTime;
        }

        public user(string n, int gid)
        {
            name = n;
            groupid = gid;
            
        }
    }
}
