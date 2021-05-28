using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Guess_Who_Harry_Potter
{
    enum EyeColor //בחירה מתוך כמה צבעים ספציפיים
    {
        brown,
        blue,
        green,
        black,
        grey
    }

    enum HairColor //בחירה מתוך כמה צבעים ספציפיים
    {
        bald,
        brown,
        red,
        blond,
        black,
        grey
    }

    enum Gender
    {
        boy,
        girl
    }

    enum House //בחירה מתוך 4 הבתים בהוגוורטס
    {
        Gryffindor,
        Slytherin,
        Hufflepuff,
        Ravenclaw
    }

    enum HairLength //בחירה של אורך שיער מתוך 2 אורכים
    {
        shorthair,
        longhair
    }

    enum HairType //בחירה של סוג שיער מתוך 3 סוגים
    {
        Straight,
        Curly,
        Wavy,
        bald
    }

    class CharacterInfo
    {
        private string Name;
        private Image CharPic;
        private EyeColor Eyes; //brown ; blue ; green ;
        private HairColor Hair; //bald ; brown ; red ; blond ; black ; 
        private bool Hat;
        private bool Glasses;
        private bool Nose;
        private Gender Gender; //boy ; girl ;
        private House House; //Gryffindor ; Slytherin ; Hufflepuff ; Ravenclaw        
        private bool Professor;
        private bool Student;
        private bool DarkMark;
        private bool DeathEater;
        private bool Animagus;
        private bool TwoEyes;
        private bool Beard;
        private bool Scar;
        private bool WalkingStick;
        private bool Dead;
        private HairLength HairL; //LongHair ; ShortHair ;        
        private bool OrderOfP;
        private HairType HairT; //Straight ; Curly ; Wavy ;

        int NumInArr;
        //enum //types

        public CharacterInfo(string Name, Image CharPic, EyeColor Eyes, HairColor Hair, bool Hat, bool Glasses, bool Nose, Gender Gender, House House, bool Professor, bool Student, bool DarkMark, bool Animagus, bool TwoEyes, bool Beard, bool Scar, bool WalkingStick, bool Dead, HairLength HairL, bool OrderOfP, HairType HairT,int NumInArr)
        {
            this.NumInArr1 = NumInArr;
            this.Name = Name;
            this.CharPic1 = CharPic;
            this.Eyes = Eyes;
            this.Hair = Hair;
            this.Hat = Hat;
            this.Glasses = Glasses;
            this.Nose = Nose;
            this.Gender = Gender;
            this.House = House;
            this.Professor = Professor;
            this.Student = Student;
            this.DarkMark = DarkMark;
            this.Animagus = Animagus;
            this.TwoEyes = TwoEyes;
            this.Beard = Beard;
            this.Scar = Scar;
            this.WalkingStick = WalkingStick;
            this.Dead = Dead;
            this.HairL = HairL;
            this.OrderOfP = OrderOfP;
            this.HairT = HairT;
        }

        public override string ToString()
        {
            return "Character Name: " + Name + "\nEye Color: " + Eyes + "\nHair Color: " + Hair + "\nHat: " + Hat + "\nGlasses: " + Glasses + "\nNose: " + Nose + "\nGender: " + Gender + "\nHouse: " + House + "\nProfessor: " + Professor + "\nStudent: " + Student + "\nDark-Mark: " + DarkMark + "\nAnimagus: " + Animagus + "\nTwo Eyes: " + TwoEyes + "\nBeard: " + Beard + "\nScar: " + Scar + "\nWalking Stick: " + WalkingStick + "\nDead: " + Dead + "\nHair Length: " + HairL + "\nOrder of the Phoenix: " + OrderOfP + "\nHair Type: " + HairT;
        }

        public Image CharPic1 { get => CharPic; set => CharPic = value; }
        public int NumInArr1 { get => NumInArr; set => NumInArr = value; }

    }
}
