﻿namespace VeronikaKursova.Model;
using VeronikaKursova.Model.EatablePresents;
using VeronikaKursova.Model.InediblePresents;

public class Child
{
    public enum HumanGender
    {
        Male = 0,
        Woman = 1
    }

    public string Name { get; init; }
    public int Age { get; init; }
    public string Gender { get; init; }
    public int GoodActionCount { get; init; }
    public int BadActionCount { get; init; }

    private readonly Present? Present;
    public Present? PresentType
    {
        get => Present;
        init =>
            Present = BadActionCount > GoodActionCount
                ? new Rizka()
                : value;
    }


    //public override string ToString()
    //{
    //    return $"Name : {Name}\n\rAge : {Age}\n\rGender : {Gender}\n\r" +
    //           $"Good Action Count : {GoodActionCount}\n\rBad Action Count : {BadActionCount}\n\r" +
    //           $"Present : {Present?.ToString() ?? "no present"}\n\r";
    //}

    public Child(string Name, int Age, string Gender, int GoodActionCount, int BadActionCount, Present PresentType )
    {
        this.Name = Name;
        this.Age = Age;
        this.Gender = Gender;
        this.GoodActionCount = GoodActionCount;
        this.BadActionCount = BadActionCount;
        this.PresentType = PresentType;
    }

    public static List<Child> CreateChildrens()
    {
       List<Child> Childrens = new List<Child>();
        var children = new List<Child>();
        Child Veronika = new Child("Veronika", 8, "1", 0, 10, new Candy()); // створення дитини з конструктором
        Child Bogdan = new Child("Bogdan", 10, "0", 100, 20, new ToyCar());
        Childrens.Add(Veronika);
        Childrens.Add(Bogdan);
        return Childrens;
    }
}