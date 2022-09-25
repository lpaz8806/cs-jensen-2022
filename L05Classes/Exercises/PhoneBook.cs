using System.Drawing;

namespace L05Classes;
/// <summary>
/// You can implement a PhoneBook that can hold
/// up to 10 name-phoneNumber pairs
///
/// Operations to support:
/// - Count: Retrieves how many numbers are stored
/// - Add(string name, string phoneNumber)
///     Adds the specified name-phoneNumber pair to the phonebook.
/// - Remove(string name): removes the pair which name is "name"
/// - Print(): 
///     Displays in the console all the name-number pairs 
///     stored in the phone book. One pair per line.
///
/// Notice that the specification is very "open". You can
/// decide how to handle the edge cases. For example,
/// what happens when the phonebook is full and you try to
/// add another pair. What happens when you try to add a pair
/// that which name already exists. What happens when you
/// try to delete a pair which name does not exist and so on.
///
/// There is no "correct" answer. It is all up to you to decide
/// how YOUR phonebook will work :)
///
/// Have Fun!
/// </summary>
public class PhoneBook
{
    private const int MaxEntries = 10;
    private NamePhonePair[] _entries = new NamePhonePair[MaxEntries];
    
    public int Count { get; private set; }

    public void Add(string name, string phone)
    {
        if (Count >= MaxEntries)
            throw new InvalidOperationException("Phonebook is full");

        _entries[Count] = new NamePhonePair(name, phone);
        Count++;
    }
    
    public void Remove(string name)
    {
        int i = FindIndexOfEntryWithName(name);
        
        if(i < 0) return;
        
        _entries[i] = _entries[Count - 1];
        Count--;
    }
    
    public void Print()
    {
        for (int i = 0; i < Count; i++)
            Console.WriteLine(_entries[i]);
    }


    private int FindIndexOfEntryWithName(string name)
    {
        for (int i = 0; i < Count; i++)
            if (_entries[i].Name == name)
                return i;

        return -1;
    }

    /*
        A simple "box" to hold names and phones together.
        Notice that this struct is private, and therefore,
        an implementation detail. You could've done the
        same thing with 2 arrays or any other idea
    */
    private struct NamePhonePair
    {
        public string Name;
        public string Phone;

        public NamePhonePair(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        // We can simplify the Print functionality by
        // specifying here how a name-phone pair should
        // be stringified (converted to string)
        public override string ToString() => $"{Name} - {Phone}";
    }
}
