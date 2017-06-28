using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var noteList = new List<string>
            {
              "C",
              "C#",
              "D",
              "D#",
              "E",
              "F",
              "F#",
              "G",
              "G#",
              "A", 
              "A#",
              "B" 
            };

            var frequencyList = new List<double>
            {
               261.63,
               277.18,
               293.66,
               311.13,
               329.63,
               349.23,
               369.99,
               392.00,
               415.30,
               440.00,
               466.16,
               493.88
            };

            var inputFrequencies = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var allNotes = FindAllNotes(inputFrequencies, frequencyList, noteList);
            var sharpNote = FindSharpNote(allNotes);
            var naturalNote = FindNaturalNotes(allNotes);
            var sharpNoteSum = NoteSum(noteList, frequencyList,sharpNote);
            var naturalNoteSum = NoteSum(noteList, frequencyList,naturalNote);

            Console.WriteLine($"Notes: {string.Join(" ", allNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalNote)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpNote)}");
            Console.WriteLine($"Naturals sum: {string.Join(" ", naturalNoteSum)}");
            Console.WriteLine($"Sharps sum: {string.Join(" ", sharpNoteSum)}");

        }

        static double NoteSum(List<string> noteList, List<double> frequencyList, List<string> notes)
        {
            var sum = 0.0d;

            foreach (var note in notes)
            {
                for (int cnt = 0; cnt < noteList.Count; cnt++)
                {
                    var currentNote = noteList[cnt];

                    if (currentNote == note)
                    {
                        sum += frequencyList[cnt];
                    }
                }
            }
            return sum;

        }

        static List<string> FindNaturalNotes(List<string> allNotes)
        {
            var naturalNote = new List<string>();

            for (int cnt = 0; cnt < allNotes.Count; cnt++)
            {
                var currentNote = allNotes[cnt];

                if (currentNote.Length < 2)
                {
                    naturalNote.Add(currentNote);
                }
            }

            return naturalNote;

        }

        static List<string> FindSharpNote(List<string> allNotes)
        {
            var sharpNote = new List<string>();

            for (int cnt = 0; cnt < allNotes.Count; cnt++)
            {
                var currentNote = allNotes[cnt];

                if (currentNote.Length >= 2)
                {
                    sharpNote.Add(allNotes[cnt]);
                }
            }

            return sharpNote;
        }

        static List<string> FindAllNotes(List<double> inputFrequencies,
                                         List<double> frequencyList,
                                         List<string> noteList)
        {
            var allNote = new List<string>();

            foreach (var inputFrequency in inputFrequencies)
            {
                for (int cnt = 0; cnt < frequencyList.Count; cnt++)
                {
                    var currentFrequency = frequencyList[cnt];

                    if (inputFrequency == currentFrequency)
                    {
                        allNote.Add(noteList[cnt]);
                    }
                }
            }
            return allNote;

        }
    }
}
