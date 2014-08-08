using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cde.district.validation
{
	public class Row : IEnumerable<KeyValuePair<string, string>>
	{
		const string Year = "ACADEMIC_YEAR";
		const string District = "DIST_NUMBER";
        const string School = "SCHOOL_NUMBER";
		const string DistrictName = "DISTRICT_NAME";
		const string SchoolLevel = "EMH_CODE";
        const string SchoolName = "SCHOOL_NAME";

        private Dictionary<string, string> data = new Dictionary<string, string>();
        public int LineNumber;

		public string Name
		{
			get { return Id + "-" + Level; }
		}

        public string Id
        {
            get 
            {
                if (Type == EDataType.District)
                {
                    return data.ContainsKey(District) ? data[District] : "Unknown District ID";
                }
                else if(this.ContainsKey(School))
                {
                    return data[School];
                }
                else if (this.ContainsKey(District))
                {
                    return data[District];
                }
                else
                {
                    return "Unknown District or School Number";
                }
            }
        }

        public string Title
        {
            get
            {
                if (this.ContainsKey(SchoolName))
                {
                    return this[SchoolName];
                }
                else
                {
                    return this[DistrictName];
                }
            }
        }
        
		public override string ToString()
		{
			return Name + " (" + LineNumber + ") " + Title;
		}

		public string Level
		{
			get { return data[SchoolLevel]; }
		}

        public bool ContainsKey(string key)
        {
            return data.ContainsKey(key);
        }

        public int Count
        {
            get { return data.Count; }
        }

        public string this[string key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return data[key];
                }
                else if (ContainsKey(DistrictName))
                {
                    throw new Exception("Key (" + key + ") not found for row: " + Name);
                }
                else
                {
                    return "Title Not Available";
                }
            }
            set { data[key] = value; }
        }

		public EDataType Type;

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
