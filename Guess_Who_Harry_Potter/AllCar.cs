using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Who_Harry_Potter
{
    class AllCar
    {
        public CharacterInfo[] allchar = new CharacterInfo[24];

        public AllCar()
        {
            allchar[0] = new CharacterInfo("Harry Potter", Properties.Resources.Harry, EyeColor.green, HairColor.brown, false, true, true, Gender.boy, House.Gryffindor, false, true, false, false, true, false, true, false, false, HairLength.shorthair, true, HairType.Straight,0);
            allchar[1] = new CharacterInfo("Hermione Granger", Properties.Resources.Hermione, EyeColor.brown, HairColor.brown, false, false, true, Gender.girl, House.Gryffindor, false, true, false, false, true, false, false, false, false, HairLength.longhair, true, HairType.Curly,1);
            allchar[2] = new CharacterInfo("Ron Weasley", Properties.Resources.Ron, EyeColor.blue, HairColor.red, false, false, true, Gender.boy, House.Gryffindor, false, true, false, false, true, false, false, false, false, HairLength.shorthair, true, HairType.Straight,2);
            allchar[3] = new CharacterInfo("Ginny Weasley", Properties.Resources.Ginny, EyeColor.brown, HairColor.red, false, false, true, Gender.girl, House.Gryffindor, false, true, false, false, true, false, false, false, false, HairLength.longhair, true, HairType.Straight,3);

            allchar[4] = new CharacterInfo("Minerva McGonagall", Properties.Resources.McGonagall, EyeColor.blue, HairColor.black, true, false, true, Gender.girl, House.Gryffindor, true, false, false, true, true, false, false, false, false, HairLength.longhair, true, HairType.Wavy,4);
            allchar[5] = new CharacterInfo("Rubeus Hagrid", Properties.Resources.Hagrid, EyeColor.black, HairColor.black, false, false, true, Gender.boy, House.Gryffindor, true, false, false, false, true, true, false, false, false, HairLength.longhair, true, HairType.Curly,5);
            allchar[6] = new CharacterInfo("Sirius Black", Properties.Resources.Sirius, EyeColor.grey, HairColor.black, false, false, true, Gender.boy, House.Gryffindor, false, false, false, true, true, true, false, false, true, HairLength.longhair, true, HairType.Wavy,6);
            allchar[7] = new CharacterInfo("Albus Dumbledore", Properties.Resources.Dumbledore, EyeColor.blue, HairColor.grey, true, false, true, Gender.boy, House.Gryffindor, true, false, false, false, true, true, false, false, true, HairLength.longhair, true, HairType.Wavy,7);

            allchar[8] = new CharacterInfo("Neville Longbottom", Properties.Resources.Longbottom, EyeColor.brown, HairColor.brown, false, false, true, Gender.boy, House.Gryffindor, false, true, false, false, true, false, false, false, false, HairLength.shorthair, true, HairType.Straight,8);
            allchar[9] = new CharacterInfo("Alastor Mad - Eye Moody", Properties.Resources.MadEye, EyeColor.brown, HairColor.grey, false, false, true, Gender.boy, House.Gryffindor, true, false, false, false, false, false, false, true, true, HairLength.longhair, true, HairType.Wavy,9);
            allchar[10] = new CharacterInfo("Remus Lupin", Properties.Resources.Lupin, EyeColor.blue, HairColor.brown, false, false, true, Gender.boy, House.Gryffindor, true, false, false, true, true, false, true, false, true, HairLength.shorthair, true, HairType.Straight,10);
            allchar[11] = new CharacterInfo("Peter Pettigrew", Properties.Resources.Pettigrew, EyeColor.grey, HairColor.red, false, false, true, Gender.boy, House.Gryffindor, false, false, true, true, true, false, false, false, false, HairLength.longhair, false, HairType.Wavy,11);

            allchar[12] = new CharacterInfo("Draco Malfoy", Properties.Resources.Draco, EyeColor.grey, HairColor.blond, false, false, true, Gender.boy, House.Slytherin, false, true, true, false, true, false, false, false, false, HairLength.shorthair, false, HairType.Straight,12);
            allchar[13] = new CharacterInfo("Bellatrix Lestrange", Properties.Resources.Bellatrix, EyeColor.black, HairColor.black, false, false, true, Gender.girl, House.Slytherin, false, false, true, false, true, false, false, false, true, HairLength.longhair, false, HairType.Curly,13);
            allchar[14] = new CharacterInfo("Lucius Malfoy", Properties.Resources.Lucius, EyeColor.grey, HairColor.blond, false, false, true, Gender.boy, House.Slytherin, false, false, true, false, true, false, false, true, false, HairLength.longhair, false, HairType.Straight,14);
            allchar[15] = new CharacterInfo("Severus Snape", Properties.Resources.Snape, EyeColor.black, HairColor.black, false, false, true, Gender.boy, House.Slytherin, true, false, true, false, true, false, false, false, true, HairLength.longhair, true, HairType.Straight,15);

            allchar[16] = new CharacterInfo("Dolores Umbridge", Properties.Resources.Umbridge, EyeColor.blue, HairColor.brown, false, false, true, Gender.girl, House.Slytherin, true, false, false, false, true, false, false, false, true, HairLength.shorthair, false, HairType.Wavy,16);
            allchar[17] = new CharacterInfo("Voldemort - You Know Who", Properties.Resources.Voldemort, EyeColor.brown, HairColor.bald, false, false, false, Gender.boy, House.Slytherin, false, false, true, false, true, false, false, false, true, HairLength.shorthair, false, HairType.bald,17);
            allchar[18] = new CharacterInfo("Cedric Diggory", Properties.Resources.Cedric, EyeColor.brown, HairColor.brown, false, false, true, Gender.boy, House.Hufflepuff, false, true, false, false, true, false, false, false, true, HairLength.shorthair, false, HairType.Wavy,18);
            allchar[19] = new CharacterInfo("Nymphadora Tonks", Properties.Resources.Tonks, EyeColor.blue, HairColor.blond, false, false, true, Gender.girl, House.Hufflepuff, false, false, false, true, true, false, false, false, true, HairLength.longhair, true, HairType.Straight,19);

            allchar[20] = new CharacterInfo("Luna Lovegood", Properties.Resources.Luna, EyeColor.blue, HairColor.blond, false, false, true, Gender.girl, House.Ravenclaw, false, true, false, false, true, false, false, false, false, HairLength.longhair, true, HairType.Wavy,20);
            allchar[21] = new CharacterInfo("Cho Chang", Properties.Resources.Cho, EyeColor.brown, HairColor.black, false, false, true, Gender.girl, House.Ravenclaw, false, true, false, false, true, false, false, false, false, HairLength.longhair, true, HairType.Straight,21);
            allchar[22] = new CharacterInfo("Gilderoy Lockhart", Properties.Resources.Lockhart, EyeColor.blue, HairColor.brown, false, false, true, Gender.boy, House.Ravenclaw, true, false, false, false, true, false, false, false, false, HairLength.shorthair, false, HairType.Wavy,22);
            allchar[23] = new CharacterInfo("Sybill Trelawney", Properties.Resources.Trelawney, EyeColor.blue, HairColor.brown, false, true, true, Gender.girl, House.Ravenclaw, true, false, false, true, true, false, false, false, false, HairLength.longhair, false, HairType.Curly,23);
        }
        Random rnd = new Random();
        public CharacterInfo myRandomChar()
        {          
            int picplay;
            picplay = rnd.Next(0, 24);
            return allchar[picplay];
        }

        public Image MyPic(int i)
        {            
            return allchar[i].CharPic1;
        }

       

    }
}
