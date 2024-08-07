using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Futterautomatenmanager.Components.Erweiterungsmethoden
{
    public static class ListExtensions
    {
        public static List<T> LastElementFirst<T>(this List<T> list)
        {
            var lastElement = list.Last();
            list.RemoveAt(list.Count -1);
            list.Insert(0, lastElement);
            return list;
        }
    }
}
