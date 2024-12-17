
Subject a = new Subject(new List<NamedZnak>() {
    new NamedZnak("orange", Znak.Xx),
    new NamedZnak("circle", Znak.Xx),
});

Subject b = new Subject(new List<NamedZnak>() {
    new NamedZnak("orange", Znak.Xx),
    new NamedZnak("circle", Znak.Xx),
});

Subject[] children = GetChildren(a, b);
PrintSubjects(children);
Console.WriteLine();

var unique = GetUnique(children);
foreach (var u in unique)
{
    Console.WriteLine(u.ToString());
}




List<ItemWithCount<Subject>> GetUnique(Subject[] subjects)
{
    var unique = new List<ItemWithCount<Subject>>();
    foreach (Subject subject in subjects)
    {
        var element = unique.Find(x => x.Item == subject);
        if (element != null)
        {
            element.Count++;
        }
        else
        {
            unique.Add(new ItemWithCount<Subject>(1, subject));
        }
    }
    return unique;
}

void PrintSubjects(Subject[] subjects)
{
    foreach (var item in subjects)
    {
        Console.WriteLine(item);
    }
}

Subject[] GetChildren(Subject a, Subject b)
{
    List<List<NamedZnak>> newZnaks = new();

    for (int i = 0; i < a.Znaky.Count; i++)
    {
        NamedZnak znakA = a.Znaky[i];
        NamedZnak znakB = b.Znaky[i];

        var currentZnaks = new List<NamedZnak>();

        for (int j = 0; j < znakA.Znak.Alels.Length; j++)
        {
            Alela alela1 = znakA.Znak.Alels[j];

            for (int k = 0; k < znakB.Znak.Alels.Length; k++)
            {
                Alela alela2 = znakB.Znak.Alels[k];

                NamedZnak newZnak = new NamedZnak(znakA.Name,
                    new Znak(alela1, alela2));
                currentZnaks.Add(newZnak);
            }
        }

        newZnaks.Add(currentZnaks);
    }

    List<Subject> children = new List<Subject>();

    var first = newZnaks[0];
    var second = newZnaks[1];

    foreach (var znak1 in first)
    {
        foreach (var znak2 in second)
        {
            children.Add(new Subject(
                new List<NamedZnak> {
                    znak1, znak2
                }));
        }
    }

    return children.ToArray();
}

class ItemWithCount<T>
{
    public int Count { get; set; }
    public T Item { get; set; }

    public ItemWithCount(int count, T item)
    {
        Count = count;
        Item = item;
    }

    public override string ToString()
    {
        return $"{Item} - x{Count}";
    }
}

class Subject
{
    public List<NamedZnak> Znaky;

    public Subject(List<NamedZnak> znaky)
    {
        Znaky = znaky;
    }

    public override string ToString()
    {
        return string.Join(',', Znaky);
    }
    public static bool operator ==(Subject a, Subject b)
    {
        for (int i = 0; i < a.Znaky.Count; i++)
        {
            var znak = a.Znaky[i];
            var znak2 = b.Znaky[i];

            if (znak != znak2)
                return false;
        }

        return true;
    }

    public static bool operator !=(Subject a, Subject b)
    { return !(a == b); }
}

class NamedZnak
{
    public string Name { get; set; }
    public Znak Znak { get; set; }

    public NamedZnak(string name, Znak znak)
    {
        Name = name;
        Znak = znak;
    }

    public override string ToString()
    {
        return $"{{{Name} - {Znak}}}";
    }

    public static bool operator ==(NamedZnak a, NamedZnak b)
    {
        return a.Name == b.Name && a.Znak == b.Znak;
    }

    public static bool operator !=(NamedZnak a, NamedZnak b)
    { return !(a == b); }
}

enum Alela
{
    X,
    x,
}

class Znak
{
    public Alela[] Alels;

    public Znak(Alela first, Alela second)
    {
        Alels = new Alela[] { first, second };
    }

    public override string ToString()
    {
        return string.Join(',', Alels.Select(a => a.ToString()));
    }

    public static Znak XX => new Znak(Alela.X, Alela.X);
    public static Znak Xx => new Znak(Alela.X, Alela.x);
    public static Znak xX => new Znak(Alela.x, Alela.X);
    public static Znak xx => new Znak(Alela.x, Alela.x);


    public static bool operator ==(Znak a, Znak b)
    {
        var first1 = a.Alels[0];
        var first2 = a.Alels[1];

        var second1 = b.Alels[0];
        var second2 = b.Alels[1];

        if (first1 == second2 && first2 == second1)
        {
            return true;
        }

        if (first1 == second1 && first2 == second2)
        {
            return true;
        }

        return false;
    }

    public static bool operator !=(Znak a, Znak b)
    { return !(a == b); }
}
