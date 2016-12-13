﻿using System;
using System.Collections.Generic;

namespace CKAN.Versioning
{
    public class KspVersionCriteria
    {
        private List<KspVersion> versions = new List<KspVersion> ();

        public KspVersionCriteria (KspVersion v)
        {
            this.versions.Add (v);
        }

        public KspVersionCriteria(KspVersion v, List<KspVersion> compatibleVersions)
        {
            if(v != null) { 
                this.versions.Add(v);
            }
            this.versions.AddRange(compatibleVersions);
        }

        public List<KspVersion> Versions {
            get {
                return versions;
            }
        }

        public override String ToString()
        {
            return "[Versions: " + versions.ToString() + "]";
        }
    }
}
