using System.Reflection;
using VeronikaKursova.Model;

namespace VeronikaKursova.Services;

public interface IChildCreator
{
    Child CreateChildrean();
}
public class ChildCreator : IChildCreator
{

    public Child CreateChildrean()
    {
        Child child = new();
        foreach (var fieldInfo in ReflectiveEnumerator.GetFields(typeof(Child)))
        {
            try
            {
                Console.Write($@"Enter {GetFieldName(fieldInfo)} : ");

                if (fieldInfo.FieldType == typeof(Present))
                {
                    InitPresent(child, fieldInfo);
                    continue;
                }

                var filedInfoToSet = Console.ReadLine();
                fieldInfo.SetValue(child, Convert.ChangeType(filedInfoToSet, fieldInfo.FieldType));
            }
            catch
            {
                // ignored
            }
        }

        Console.WriteLine();
        return child;
    }
    private void InitPresent(Child child, FieldInfo fieldInfo)
    {
        if (child.BadActionCount > child.GoodActionCount)
        {
            Console.WriteLine(@"Rizka to you!!!!");
            fieldInfo.SetValue(child, new Rizka());
            return;
        }

        Console.Write(@"Choose type 
 0 - Eatable , 1 - NonEatable: ");
        var chooseType = Convert.ToInt32(Console.ReadLine());

        var presents = (IReadOnlyList<Present>)
            (chooseType == 0
                ? ReflectiveEnumerator.GetEnumerableOfType<Eateble>().ToList()!
                : ReflectiveEnumerator.GetEnumerableOfType<Inedible>().ToList()!);

        PrintList(presents);

        Console.Write(@"Choose Present : ");
        var presentId = Convert.ToInt32(Console.ReadLine()) - 1;

        fieldInfo.SetValue(child, presents[presentId]);
    }
    private void PrintList<T>(IReadOnlyList<T> presents)
    {
        for (var i = 0; i < presents.Count; i++)
        {
            Console.WriteLine($@"{i + 1} . {presents[i]?.GetType()}");
        }
    }
    private string GetFieldName(MemberInfo fieldInfo)
    {
        try
        {
            var startSubstring = fieldInfo.Name.IndexOf('<') + 1;
            var endSubstring = fieldInfo.Name.IndexOf('>') - 1;
            return fieldInfo.Name.AsSpan(startSubstring, endSubstring).ToString();
        }
        catch
        {
            return fieldInfo.Name;
        }
    }

}