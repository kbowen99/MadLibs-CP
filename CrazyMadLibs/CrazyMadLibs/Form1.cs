using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyMadLibs
{
   //no comment
    public partial class frmCrazyMadLib : Form
    {
        // create variables for global use
        string FirstName ;
        string Adjective1 ;
        string Adjective2 ;
        string PastTenseVerb ;
        string Adjective3 ;
        string Adjective4 ;
        string Plural_Noun ;
        string LargeAnimal ;
        string SmallAniaml ;
        string PluralNoun2 ;
        string number ;
        string bigNumber ;
        string pluralNouns3 ;
        public frmCrazyMadLib()
        {
            InitializeComponent();
            //init
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //update global vars with textboxes
            FirstName = txt_firstName.Text;
            Adjective1 = txt_Adjective1.Text;
            Adjective2 = txt_adjective2.Text;
            PastTenseVerb = txt_PastTenseVerb.Text;
            Adjective3 = txt_Adjective3.Text;
            Adjective4 = txt_Adjective4.Text;
            Plural_Noun = txt_pluralN.Text;
            LargeAnimal = txt_largeAnimal.Text;
            SmallAniaml = txt_SmallAnimal.Text;
            PluralNoun2 = txt_PluralNoun2.Text;
            number = txt_number.Text;
            bigNumber = txt_bigNumber.Text;
            pluralNouns3 = txt_PluralNoun3.Text;



            
            
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btn_MadLibGen_Click(object sender, EventArgs e)
        {
            //create sentence
            string Sentence = "I, the " + Adjective1 + " and " + Adjective2 + " " + FirstName + " Has " + PastTenseVerb + " " + FirstName + "'s " + Adjective3 + " sister and Plans to steal her " + Adjective4 + " " + Plural_Noun + "! What are a " + LargeAnimal + " and backpacking " + SmallAniaml + " to do? Before you can help " + FirstName + "'s Sister, You'll have to collect the " + PluralNoun2 + " that opens up the " + number + " worlds connected to " + FirstName + "'s Lair there are " + bigNumber + " " + pluralNouns3 + " in the game, along with other things for you to find....";
            //display sentence
            MessageBox.Show(Sentence, "Mad Lib");
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btn_madLib2_Click(object sender, EventArgs e)
        {
            //create sentence 2
            string sentence2 = "Today I went to the zoo. I saw a " + Adjective1 + " " + LargeAnimal + " Jumping up and down. He " + PastTenseVerb + " through the large tunnel that led to its " + Adjective2 + " " +  Plural_Noun + " I got some peanuts and fed them to the " + Adjective3 + " " + SmallAniaml + ". I went to get a " + Adjective4 + " Scoup of ice cream. When I got home I " + PastTenseVerb + " my mother for taking me to the zoo";
            // display sentence 2
            MessageBox.Show(sentence2, "Mad Lib");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
