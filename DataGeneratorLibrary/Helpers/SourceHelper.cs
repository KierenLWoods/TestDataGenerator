using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Helpers
{
    public static class SourceHelper
    {
    public static IList AutoCast(this IList list)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (list.Count == 0) throw new InvalidOperationException(
                  "Cannot AutoCast an empty list");
            Type type = list[0].GetType();
            IList result = (IList)Activator.CreateInstance(typeof(List<>)
                  .MakeGenericType(type), list.Count);
            foreach (object obj in list) result.Add(obj);
            return result;
        }
    }
}
