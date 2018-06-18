using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_MusicProject
{
    public static class Instructions
    {
        public static String toString()
        {
            return "When starting a new game the user can immediately start composing. \n " +
                "The default setting of the game shows 6 buttons with note names and duration" +
                " written on them. By clicking on each button the user can hear the" +
                " represented note. Then if the user likes one of the notes he can add that note" +
                " to his melody by selecting the accompanying radiobutton (below each button) " +
                "and clicking on the button Add Note. After each note added, there are new 6 " +
                "notes generated and displayed on the form, and the previously added note is " +
                "vissible in the Composition History Panel. If the user does not " +
                "like the notes, he can generate 6 new notes by clicking on Generate New Notes." +
                " By selecting the radioButtons Generate Higher Notes or Generate lower Notes, " +
                "from that point on, the generated notes will accordingly be one octave higer or" +
                " lower than the standard octave. \n\n" +
                "After inserting notes in the melody the user can listen to the whole melody by clicking the prominent " +
                "Play button on the upper right of the Form. There are three options for the tempo in which the composition will be played: " +
                "Slow, Medium and Fast. These can be selected by the user on the upper left of the application window." +
                "The composition history panel allows the user to listen to every previously inserted note and decide if" +
                " he wants to delete it or leave it in the composition. He does so by selecting the corresponding radioButton " +
                "and pressing the Delete Selected Note button on the right side of the panel.";
        }
    }
}
