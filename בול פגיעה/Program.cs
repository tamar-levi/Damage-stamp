using System;

namespace בול_פגיעה
{
    class Program
    {
        static void Menue()
            
        {
            int x, top = 6;
            do
            {
               
                do
                {
                 Console.WriteLine("enter 1 to choose level, 2 to start the game , 3 to exit");
                 x = int.Parse(Console.ReadLine());
                } while (x < 1 || x > 3);

                switch (x)
                {
                    case 1:
                        top = Level();
                        break;
                    case 2: Game(top);
                        break;
                }

            } while (x != 3);
        }
        static int Level()
        {
            int x, top = 0;
            do
            {
                Console.WriteLine("enter level 1-3");
                x = int.Parse(Console.ReadLine());
            } while (x < 1 || x > 3);
            switch (x)
            {
                case 1: top = 6;
                    break;
                case 2: top = 8;
                    break;
                case 3:top = 10;
                    break;
            }
            return top;
        }
        static void Game(int top)
        { int[] RandArr = new int[top+1];
            int[] ArrGame = new int[4];
            int num , cnt2=0 ,trying=0;
            int bol = 0, pgiya = 0;
            int[] t = new int[4];
            Random rand = new Random();
            //מגריל מערך של התפלגות מונים
            for(int i = 1; i<=4; i++)
            {
                do
                {
                    num = rand.Next(1, top + 1);
                } while (RandArr[num] == 1);
                RandArr[num] = 1;
            }
            //הכנסה למערך המשחק
              for( int i = 1; i < RandArr.Length; i++)
            {
                if (RandArr[i] == 1)
                {
                    ArrGame[cnt2]= i;
                    cnt2++;
                }
            }
            do
            {
               
                Get(t,top);
                bol = Boolim(ArrGame, t);
                pgiya = Pgiaha(ArrGame, t);
                trying++;
                for(int i = 0; i < bol; i++)
                {
                    Console.Write("!\t");

                }
                for(int i = 0; i < pgiya; i++)
                {
                    Console.Write("?\t");
                }
                Console.WriteLine();
            } while (bol!=4 && trying<10);
            if (bol == 4)
            {
                Console.WriteLine("excalent you winer");
            }
            else
            {
                Console.WriteLine("what a pity try again");
            }

        }
        static void Get(int [] t, int top)
        {
            int x;
            bool flag = true;
            for(int i = 0; i < t.Length; i++)
            {
                do
                {
                    Console.WriteLine("enter num 1-" + top);
                    x = int.Parse(Console.ReadLine());
                    for(int j=0; j<i; j++)
                    {
                        if (t[j] ==x)
                        {
                            flag = false;
                        }
                    }
                   
                } while (x < 1 || x > top||flag==false);
                t[i] = x;
            }
           
        }
        
        static int Boolim (int[] ArrGame, int[] t)
        {
            int count = 0;
            for(int i = 0; i < 4; i++)
            {
                if (ArrGame[i] == t[i])
                {
                    count++;
                }
            }
            return count;

        }
        static int Pgiaha(int[] ArrGame, int[] t)
        {
            int count1 = 0;
            for(int i = 0; i < 4; i++)
            {
                if (t[i] != ArrGame[i])
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (t[i] == ArrGame[j])
                        {
                            count1++;
                        }
                    }
                    
                }    
                
            }
            return count1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Gam's rools:\n\n 1-you need to guess the 4 nums that the computer choos,acording the places \n\n" +
               " 2-if you seccied to guess the number in the same place you will see -!\n,else if you seccied to guess the number but " +
               "not in the same place,ou will see-?\n\n 3-the game limited to 10 trying.\n");
            Menue(); 
        }
    }
}
