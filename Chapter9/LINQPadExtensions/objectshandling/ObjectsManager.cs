using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQPad.objectshandling
{
    public static class ObjectsManager
    {
        public static Dictionary<string, object> Properties(this object mySelf)
        {
            return ReadProperties(mySelf).Where(property => property.CanRead).ToDictionary(property => property.Name, property => property.GetValue(mySelf));
        }

        public static PropertyInfo[] ReadProperties(this object mySelf)
        {
            return mySelf.GetType().GetProperties();
        }

    }
}
