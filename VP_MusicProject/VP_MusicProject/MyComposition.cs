using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using System.Threading;
using System.Drawing;

namespace VP_MusicProject
{
    [Serializable]
    public class MyComposition
    {
        private List<MyNote> notes; // the list of added notes (the composition itself)
        private int position; // current position where next note will be added
        private int tempo;  // beats per minute
        private int totalDuration; // in milliseconds
        private int beatLength; // in milliseconds
        
        public MyComposition()
        {
            notes = new List<MyNote>();
            position = 0;
            totalDuration = 0;
        }

        public List<MyNote> getListNotes()
        {
            return notes;
        }

        public MyComposition(int initialTempo)
        {
            notes = new List<MyNote>();
            position = 0;
            tempo = initialTempo;
            totalDuration = 0;
            beatLength = 60000 / initialTempo;
        }

        //set new tempo
        public void setTempo(int t)
        {
            tempo = t;
            beatLength = 60000 / tempo;
        }


        // adds a new note to the end of the composition
        public void addNote(MyNote note)
        {
            notes.Add(note);
        }
        
        // remove the last note of the composition
        public void removeLast()
        {
            notes.RemoveAt(notes.Count - 1);
        }

        // schedules the notes and plays the composition
        public void play(OutputDevice outputDevice)
        {
            new Thread(() =>
            {
                Clock clock = new Clock(tempo);
                foreach (MyNote n in notes)
                {
                    totalDuration += n.myDurationInBeats * beatLength;
                    clock.Schedule(n.noteStart(outputDevice, position));
                    position += n.myDurationInBeats;
                    clock.Schedule(n.noteEnd(outputDevice, position));

                }
                clock.Start();
                Thread.Sleep(totalDuration + 1000); // 1 additional second
                clock.Stop();


            }).Start();

        }

        public static void play(List<MyNote> lista,int t, OutputDevice outputDevice)
        {
            MyComposition newComp = new MyComposition(t);
            foreach(MyNote n in lista)
            {
                newComp.addNote(n);
            }
           
            int positionStatic = 0;
            int totalDurationStatic = 0;
            int beatLengthStatic = 60000 / t;


            Clock clock = new Clock(t);
            foreach (MyNote n in lista)
            {
                totalDurationStatic += n.myDurationInBeats * beatLengthStatic;
                clock.Schedule(n.noteStart(outputDevice, positionStatic));
                positionStatic += n.myDurationInBeats;
                clock.Schedule(n.noteEnd(outputDevice, positionStatic));

            }
            clock.Start();
            Thread.Sleep(totalDurationStatic + 1000); // 1 additional second
            clock.Stop();
        }

        public void removeLastSixAt(int toRemove)
        {
            if(notes.Count <= 6)
            {
                notes.RemoveAt(toRemove);
            }
            else
            {
                notes.RemoveAt(notes.Count - 7 + toRemove);
            }


        }

        public void removeAt(int i)
        {
            notes.RemoveAt(i);
        }

        public int getLength()
        {
            return notes.Count;
        }


        public List<MyNote> getLastSix()
        {
            int compositionLength = notes.Count;
            List<MyNote> lastSix = Enumerable.Reverse(notes).Take(6).Reverse().ToList();
            //List<MyNote> lastSix = notes.GetRange(compositionLength - 7, compositionLength - 1);
            return lastSix;
        }

        public List<MyNote> getLastN(int n)
        {
            int compositionLength = notes.Count;
            List<MyNote> lastN = notes.GetRange(0, n);
            return lastN;
        }



        public void Draw(Graphics g, Pen pnr)
        {
            for (int i = 1; i < notes.Count; i++)
            {
                g.DrawLine(pnr, (i - 1) * 5, 75 - (float) Math.Pow(notes.ElementAt(i - 1).myPitch - 47, 1.22),
                i * 5, 75 - (float)Math.Pow(notes.ElementAt(i).myPitch - 47, 1.22) );
            }
        }

        public int getTotalDuration()
        {
            int localTotalDuration = 0;
            foreach (MyNote n in notes)
            {
                localTotalDuration += n.myDurationInBeats * beatLength;
            }
            return localTotalDuration;
        }

    }
}
