using System.Reflection;

namespace VeronikaKursova.Services;

public static class ReflectiveEnumerator
{
    public static IEnumerable<T?> GetEnumerableOfType<T>(params object[] constructorArgs)
        where T : class
        => Assembly
            .GetAssembly(typeof(T))
            ?.GetTypes()
            .Where(myType =>
                myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)))
            .Select(type => (T)Activator.CreateInstance(type, constructorArgs)!)!
            .ToList()!;
}