using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using System.Threading;

namespace VP_MusicProject
{
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
            Clock clock = new Clock(tempo);
            foreach(MyNote n in notes)
            {
                totalDuration += n.myDurationInBeats * beatLength;
                clock.Schedule(n.noteStart(outputDevice,position));
                position += n.myDurationInBeats;
                clock.Schedule(n.noteEnd(outputDevice, position));

            }
            clock.Start();
            Thread.Sleep(totalDuration + 1000); // 1 additional second
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

        public int getLength()
        {
            return notes.Count;
        }


        public List<MyNote> getLastSix()
        {
            int compositionLength = notes.Count;
            List<MyNote> lastSix = notes.GetRange(compositionLength - 7, compositionLength - 1);
            return lastSix;
        }

        



    }
}
