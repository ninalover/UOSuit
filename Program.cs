// UO Endless suit calculator
// (C) 2017 Martin Østergaard / martin.ms404@gmail.com
// Released under GPL V2 or later.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UO_Endless_Suit_Calculator
{
    class Program
    {
        static private List<int> XCoords = new List<int>();
        static string dummy = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
        //static private char[] Leggings = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00".ToCharArray();
        static private char[] Leggings = dummy.ToCharArray();
        static private char[] Tunic    = dummy.ToCharArray();
        static private char[] HeadGear = dummy.ToCharArray();
        static private char[] Gorget   = dummy.ToCharArray();
        static private char[] Sleeves  = dummy.ToCharArray();
        static private char[] Gloves   = dummy.ToCharArray();
        static private char[] Ring     = dummy.ToCharArray();
        static private char[] Braclet  = dummy.ToCharArray();
        static private char[] Apron    = dummy.ToCharArray();
        static private char[] Talisman = dummy.ToCharArray();
        static private char[] Cloak    = dummy.ToCharArray();
        static private char[] Robe     = dummy.ToCharArray();
        static private char[] Sash     = dummy.ToCharArray();
        static private char[] Shield   = dummy.ToCharArray();




        static private void SaveAll() // F5 pressed save all
        {
            int cx, cy;
            string fname;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.SetCursorPosition(0, 23);
            System.Console.Write("Save All: ");
            fname = System.Console.ReadLine();
            System.Console.SetCursorPosition(0, 23);
            if (File.Exists(fname) || fname == "")
            {
                System.Console.SetCursorPosition(0, 23);
                System.Console.WriteLine("File already exists Or blank input !!! Press a key to continue");
                System.Console.ReadKey();
                System.Console.SetCursorPosition(0, 23);
                System.Console.Write("                                                               ");
                System.Console.SetCursorPosition(cx, cy);
                return;
            }

            FileInfo fi = new FileInfo(fname);
            //            using (TextWriter txtWriter = new StreamWriter(fi.Open(FileMode.CreateNew)))
            TextWriter txtWriter = new StreamWriter(fi.Open(FileMode.CreateNew));

            txtWriter.WriteLine("HeadGear");
            txtWriter.WriteLine("{0}", string.Join("", HeadGear));

            txtWriter.WriteLine("Gorget");
            txtWriter.WriteLine("{0}", string.Join("", Gorget));

            txtWriter.WriteLine("Tunic");
            txtWriter.WriteLine("{0}", string.Join("", Tunic));

            txtWriter.WriteLine("Sleeves");
            txtWriter.WriteLine("{0}", string.Join("", Sleeves));

            txtWriter.WriteLine("Gloves");
            txtWriter.WriteLine("{0}", string.Join("", Gloves));

            txtWriter.WriteLine("Leggings");
            txtWriter.WriteLine("{0}", string.Join("", Leggings));

            txtWriter.WriteLine("Ring");
            txtWriter.WriteLine("{0}", string.Join("", Ring));

            txtWriter.WriteLine("Braclet");
            txtWriter.WriteLine("{0}", string.Join("", Braclet));

            txtWriter.WriteLine("Apron");
            txtWriter.WriteLine("{0}", string.Join("", Apron));

            txtWriter.WriteLine("Talisman");
            txtWriter.WriteLine("{0}", string.Join("", Talisman));

            txtWriter.WriteLine("Robe");
            txtWriter.WriteLine("{0}", string.Join("", Robe));

            txtWriter.WriteLine("Cloak");
            txtWriter.WriteLine("{0}", string.Join("", Cloak));

            txtWriter.WriteLine("Sash");
            txtWriter.WriteLine("{0}", string.Join("", Sash));

            txtWriter.WriteLine("Shield");
            txtWriter.WriteLine("{0}", string.Join("", Shield));


            txtWriter.Close();
            System.Console.SetCursorPosition(0, 23);
            System.Console.Write("                                                               ");
            System.Console.SetCursorPosition(cx, cy);
        }

        static void Help()         // F1 Pressed
        {
            int cx, cy;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.SetCursorPosition(0, 17);
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.WriteLine("                                                                            ");
            System.Console.SetCursorPosition(0, 17);
            System.Console.WriteLine("F1 Help : F2 Load Part/Entire Suit");
            System.Console.WriteLine("F5 Save all : F4 save item part at cursor location");
            System.Console.WriteLine("F3 Calculate the suit and show result.");
            System.Console.WriteLine("Use Cursor keys/pageUP/pageDOWN/HOME/END to navigate");
            System.Console.WriteLine("UO Endless suit calculator is free to use/ Released under GPL");
            System.Console.WriteLine("(C) 2017 Martin Østergaard / martin.ms404@gmail.com");



            System.Console.SetCursorPosition(cx, cy);

        }



        static private void Save() // F4 pressed save armor part.
        {
            int cx, cy;
            string fname;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.SetCursorPosition(0, 23);
            System.Console.Write("Save File: ");
            fname=System.Console.ReadLine();
            System.Console.SetCursorPosition(0, 23);

            System.Console.WriteLine("{0}", fname);
            //            System.Console.Write("                                                                               ");

            if (File.Exists(fname) || fname == "") {
                System.Console.SetCursorPosition(0, 23);
                System.Console.WriteLine("File already exists or blank input !!! Press a key to continue");
                System.Console.ReadKey();
                System.Console.SetCursorPosition(0, 23);
                System.Console.Write("                                                               ");
                System.Console.SetCursorPosition(cx, cy);
                return;
            }

            FileInfo fi = new FileInfo(fname);
            //            using (TextWriter txtWriter = new StreamWriter(fi.Open(FileMode.CreateNew)))
            TextWriter txtWriter = new StreamWriter(fi.Open(FileMode.CreateNew));

            switch (cy)
            {
                case 2:
                    {
                        txtWriter.WriteLine("HeadGear");
                        txtWriter.WriteLine("{0}", string.Join("", HeadGear));
                        break;
                    }
                case 3:
                    {
                        txtWriter.WriteLine("Gorget");
                        txtWriter.WriteLine("{0}", string.Join("", Gorget));
                        break;
                    }
                case 4:
                    {
                        txtWriter.WriteLine("Tunic");
                        txtWriter.WriteLine("{0}", string.Join("", Tunic));

                        break;
                    }
                case 5:
                    {
                        txtWriter.WriteLine("Sleeves");
                        txtWriter.WriteLine("{0}", string.Join("", Sleeves));
                        break;
                    }
                case 6:
                    {
                        txtWriter.WriteLine("Gloves");
                        txtWriter.WriteLine("{0}", string.Join("", Gloves));
                        break;
                    }
                case 7:
                    {
                        txtWriter.WriteLine("Leggings");
                        txtWriter.WriteLine("{0}", string.Join("", Leggings));
                        break;
                    }
                case 8:
                    {
                        txtWriter.WriteLine("Ring");
                        txtWriter.WriteLine("{0}", string.Join("", Ring));
                        break;
                    }
                case 9:
                    {
                        txtWriter.WriteLine("Braclet");
                        txtWriter.WriteLine("{0}", string.Join("", Braclet));

                        break;
                    }
                case 10:
                    {
                        txtWriter.WriteLine("Apron");
                        txtWriter.WriteLine("{0}", string.Join("", Apron));
                        break;
                    }
                case 11:
                    {
                        txtWriter.WriteLine("Talisman");
                        txtWriter.WriteLine("{0}", string.Join("", Talisman));
                        break;
                    }
                case 12:
                    {
                        txtWriter.WriteLine("Robe");
                        txtWriter.WriteLine("{0}", string.Join("", Robe));
                        break;
                    }
                case 13:
                    {
                        txtWriter.WriteLine("Cloak");
                        txtWriter.WriteLine("{0}", string.Join("", HeadGear));
                        break;
                    }
                case 14:
                    {
                        txtWriter.WriteLine("Sash");
                        txtWriter.WriteLine("{0}", string.Join("", Sash));
                        break;
                    }
                case 15:
                    {
                        txtWriter.WriteLine("Shield");
                        txtWriter.WriteLine("{0}", string.Join("", Shield));
                        break;
                    }

            }
            txtWriter.Close();
            System.Console.SetCursorPosition(0, 23);
            System.Console.Write("                                                               ");
            System.Console.SetCursorPosition(cx, cy);
        }


        static private void Load () // F2 Pressed 
        {
            int c=0,cx, cy;
            string fname;
            string[] ftext;
            fname = "";
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.SetCursorPosition(0,23);
            System.Console.Write("Load File: ");
            fname = System.Console.ReadLine();
            System.Console.SetCursorPosition(0, 23);
            System.Console.Write("                                                                               ");

            System.Console.SetCursorPosition(cx, cy);

            if (fname == "")
                return; // show error in future

            try
            {
                ftext = System.IO.File.ReadAllLines(fname);

            }
            catch (IOException e)
            {
                //                System.Console.WriteLine ("Exception :: {0}", e.GetType().Name);
                System.Console.SetCursorPosition(0, 23);
                System.Console.WriteLine("{0} Press a key to continue", e.GetType().Name);
                System.Console.ReadKey();
                System.Console.SetCursorPosition(0, 23);
                System.Console.Write("                                                               ");
                System.Console.SetCursorPosition(cx, cy);
                return;
            }

            // Got file in ftext[]




            for (c = 0; c < ftext.Length; c += 2) // step 2
            {
                PopulateItem(ftext[c], ftext[c + 1]);
                //System.Console.WriteLine("Oink {0}", ftext[c]);
                //System.Console.WriteLine("Oink {0}", ftext[c+1]);
            }
            // System.Console.SetCursorPosition(cx, cy);
            Draw();
        }

        static private void PopulateItem(string itemName, string itemValue) {
            int c;
            char[] tmp = null;
            char[] tmp1;
            tmp1 = itemValue.ToCharArray();
            if (itemValue == "" || itemName == "")
                return; // invalid params..
            // tmp = Leggings;

            if (itemName == "Leggings") { tmp = Leggings; }
            if (itemName == "Tunic") { tmp = Tunic; }
            if (itemName == "HeadGear") { tmp = HeadGear; }
            if (itemName == "Gorget") { tmp = Gorget; }
            if (itemName == "Sleeves") { tmp = Sleeves; }
            if (itemName == "Gloves") { tmp = Gloves; }
            if (itemName == "Ring") { tmp = Ring; }
            if (itemName == "Braclet") { tmp = Braclet; }
            if (itemName == "Apron") { tmp = Apron; }
            if (itemName == "Talisman") { tmp = Talisman; }
            if (itemName == "Cloak") { tmp = Cloak; }
            if (itemName == "Robe") { tmp = Robe; }
            if (itemName == "Sash") { tmp = Sash; }
            if (itemName == "Shield") { tmp = Shield; }



            if (tmp == null)
                return; // Not a valid tag
            if (tmp.Length != tmp1.Length) // mismatch
                return;


            // copy tmp1 to tmp;
            for (c = 0; c < tmp1.Length; c++) {
                tmp[c] = tmp1[c];

            }

        }


        static void Calc() // called when F3 is pressed.
        {
            int cx, cy;
            string s;
            string[] ts;
            int[] res= { 00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 ,00 };
            int c;

            s = "";
            s = string.Join("", Leggings);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Tunic);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", HeadGear);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++) {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Gorget);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Sleeves);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Gloves);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Ring);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Braclet);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Apron);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Talisman);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Cloak);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Robe);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }
            s = "";
            s = string.Join("", Sash);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }

            s = "";
            s = string.Join("", Shield);
            ts = s.Split(' ');
            for (c = 0; c < ts.Length; c++)
            {
                res[c] += Convert.ToInt16(ts[c]);

            }






            // Display Calculated Values.
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.SetCursorPosition(0, 17);
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.WriteLine("                                                                              ");
            System.Console.SetCursorPosition(0, 17);
            System.Console.WriteLine("Physical {0} : Fire {1} : Cold {2} : Poison {3} : Energy {4}", (int)res[0], (int)res[1], (int)res[2], (int)res[3], (int)res[4]);
            System.Console.WriteLine("HPI {0} : SI  {1} : MI {2} : DEX {3} : STR {4} : INT {5}", (int)res[5], (int)res[6], (int)res[7], (int)res[16], (int)res[17], (int)res[18]);
            System.Console.WriteLine("LMC {0} : LRC {1} : CF {2} : FC  {3} : FCR {4}", (int)res[8], (int)res[9], (int)res[10], (int)res[11], (int)res[12]);
            System.Console.WriteLine("HCI {0} : DCI {1} : DI {2} : SDI {3}", (int)res[19], (int)res[20], (int)res[21], (int)res[22]);

            //HP5 SI6 MI7 lm8 rc9 cf10 fc11 fr12 
            //MR13 SR14 HR15 dx16 st17 in18 HC19 DC20 DI21 EP22


            System.Console.SetCursorPosition(cx, cy);

            //            s = string.Join("", Leggings);
            //            ts = s.Split(' ');
            //            System.Console.WriteLine("Oink {0} Oink",ts[0]);

        }



        static void Draw()
        {
            int cx, cy;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;

            System.Console.SetCursorPosition(0, 1);
            System.Console.WriteLine("           ph fi co po en HP SI MI lm rc cf fc fr MR SR HR dx st in HC DC DI SD");
            System.Console.WriteLine("HeadGear : {0}", string.Join("", HeadGear));
            System.Console.WriteLine("Gorget   : {0}", string.Join("", Gorget));
            System.Console.WriteLine("Tunic    : {0}", string.Join("", Tunic));
            System.Console.WriteLine("Sleeves  : {0}", string.Join("", Sleeves));
            System.Console.WriteLine("Gloves   : {0}", string.Join("", Gloves));
            System.Console.WriteLine("Leggings : {0}", string.Join("", Leggings));
            System.Console.WriteLine("Ring     : {0}", string.Join("", Ring));
            System.Console.WriteLine("Braclet  : {0}", string.Join("", Braclet));
            System.Console.WriteLine("Apron    : {0}", string.Join("", Apron));
            System.Console.WriteLine("Talisman : {0}", string.Join("", Talisman));
            System.Console.WriteLine("Cloak    : {0}", string.Join("", Cloak));
            System.Console.WriteLine("Robe     : {0}", string.Join("", Robe));
            System.Console.WriteLine("Sash     : {0}", string.Join("", Sash));
            System.Console.WriteLine("Shield   : {0}", string.Join("", Shield));
            System.Console.SetCursorPosition(cx, cy); // restore old cursor position
        }

        static void WriteX(char c) {
            int cx, cy;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            System.Console.Write("{0}", c);
            switch (cy) {
                case 2 :
                    {
                        HeadGear[cx - 11] = c;
                        break;
                    }
                case 3:
                    {
                        Gorget[cx - 11] = c;
                        break;
                    }
                case 4:
                    {
                        Tunic[cx - 11] = c;
                        break;
                    }
                case 5:
                    {
                        Sleeves[cx - 11] = c;
                        break;
                    }
                case 6:
                    {
                        Gloves[cx - 11] = c;
                        break;
                    }
                case 7:
                    {
                        Leggings[cx - 11] = c;
                        break;
                    }
                case 8:
                    {
                        Ring[cx - 11] = c;
                        break;
                    }
                case 9:
                    {
                        Braclet[cx - 11] = c;
                        break;
                    }
                case 10:
                    {
                        Apron[cx - 11] = c;
                        break;
                    }
                case 11:
                    {
                        Talisman[cx - 11] = c;
                        break;
                    }
                case 12:
                    {
                        Cloak[cx - 11] = c;
                        break;
                    }
                case 13:
                    {
                        Robe[cx - 11] = c;
                        break;
                    }
                case 14:
                    {
                        Sash[cx - 11] = c;
                        break;
                    }
                case 15:
                    {
                        Shield[cx - 11] = c;
                        break;
                    }

            }

            MoveX();
        }
        
        static void MoveX() {
            int cx, cy;
            cx = System.Console.CursorLeft;
            cy = System.Console.CursorTop;
            if (XCoords.Contains(cx))
            { // illegal coord ?
                
                System.Console.SetCursorPosition(cx + 1, cy); // step one
            }
            cx = System.Console.CursorLeft;
            if (cx > 78) // check out of screen value
            {
                System.Console.SetCursorPosition(78, cy);

            }
        }


        static void Main(string[] args)
        {
            //List<int> XCoords = new List<int>();
            int cx, cy,c;
            ConsoleKeyInfo K;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //System.Console.CursorSize = 80;
            System.Console.Title = "UO Endless Suit Calculator V1.1b (C) 2017 Martin Christian Østergaard";

            Draw();
            System.Console.SetCursorPosition(11, 2);

            cx = 10;
            for (c=0;c<22;c++) // Calc illegal X coords.
            {
                XCoords.Add(cx+=3);
            }
            // Big key read loop
            while (true) {
                
                cx = System.Console.CursorLeft;
                cy = System.Console.CursorTop;
                K = System.Console.ReadKey(true);
                if (K.Key == ConsoleKey.RightArrow)
                {
                    System.Console.SetCursorPosition(cx + 1, cy);
                    MoveX();
                    continue; // goto 1
                }

                if (K.Key == ConsoleKey.LeftArrow)
                {
                    System.Console.SetCursorPosition(cx - 1, cy);
                    cx = System.Console.CursorLeft;
                    if (XCoords.Contains(cx)) // illegal pos ?
                    {
                        System.Console.SetCursorPosition(cx - 1, cy);
                        cx = System.Console.CursorLeft;
                    }
                    if (cx <11)
                        System.Console.SetCursorPosition(11, cy);
                    continue;

                }

                if (K.Key == ConsoleKey.UpArrow) // Y movements galore.
                {
                    System.Console.SetCursorPosition(cx, cy-1);
                    cy = System.Console.CursorTop;
                    if (cy<2)
                        System.Console.SetCursorPosition(cx, 2);
                    continue;
                }
                if (K.Key == ConsoleKey.DownArrow)
                {
                    System.Console.SetCursorPosition(cx, cy+1);
                    cy = System.Console.CursorTop;
                    if (cy > 15)
                        System.Console.SetCursorPosition(cx, 15);
                    continue;
                }
                if (K.Key == ConsoleKey.Home)
                {
                    System.Console.SetCursorPosition(11, cy);
                    continue;
                }
                if (K.Key == ConsoleKey.End)
                {
                    System.Console.SetCursorPosition(78, cy);
                    continue;
                }

                if (K.Key == ConsoleKey.PageUp)
                {
                    System.Console.SetCursorPosition(cx, 2);
                    continue;
                }

                if (K.Key == ConsoleKey.PageDown)
                {
                    System.Console.SetCursorPosition(cx, 13);
                    continue;
                }
                if (K.Key == ConsoleKey.F1) // Help
                {
                    Help();
                    continue;
                }



                if (K.Key == ConsoleKey.F2) // Load
                {
                    Load();
                    continue;
                }
                if (K.Key == ConsoleKey.F4) // save itam part
                {
                    Save();
                    continue;

                }
                if (K.Key == ConsoleKey.F5) // save all
                {
                    SaveAll();
                    continue;
                }
                if (K.Key == ConsoleKey.F3) // do calcs ?
                {
                    Calc();
                    continue;
                }

                if (Convert.ToInt16(K.Key) >= 48 && Convert.ToInt16(K.Key) < 58) // A number.
                {
                    WriteX((char)Convert.ToInt16(K.Key));
                }
            }
        }
    }
}
