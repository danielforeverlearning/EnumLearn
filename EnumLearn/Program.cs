using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLearn
{
    class Program
    {
        public enum MenuChoices
        {
            QUIT = 0,
            Account_Insert = 1,
            Account_Delete = 2,
            Account_InsertQUICK = 3,
            Account_UpdateQUICK = 4,
            AdminUser_InsertQUICK = 5,
            AdminUser_Delete = 6,
            AdminUser_UpdateQUICK = 7,
            AdminUser_UpdatePwd = 8,
            AdminUser_Login = 9,
            END = 10
        };

        static void Main(string[] args)
        {
            
            MenuChoices mychoiceenum = MenuChoices.END;
            int theend = (int)mychoiceenum;
            for (int ii = 0; ii < theend; ii++ )
            {
                MenuChoices tempchoice = (MenuChoices)ii;
                Console.WriteLine("{0}: {1}", ii, tempchoice);
            }
            Console.WriteLine("Enter choice:");
            int mychoice = 0;
            int.TryParse(Console.ReadLine(), out mychoice);

            mychoiceenum = (MenuChoices)MenuChoices.ToObject(typeof(MenuChoices), mychoice);
            Console.WriteLine("{0}", mychoiceenum);

            //right-click-->insert Snippet-->Visual C#-->switch-->type in name of enum variable-->press return-->BINGO
            switch (mychoiceenum)
            {
                case MenuChoices.QUIT:
                    break;
                case MenuChoices.Account_Insert:
                    break;
                case MenuChoices.Account_Delete:
                    break;
                case MenuChoices.Account_InsertQUICK:
                    break;
                case MenuChoices.Account_UpdateQUICK:
                    break;
                case MenuChoices.AdminUser_InsertQUICK:
                    break;
                case MenuChoices.AdminUser_Delete:
                    break;
                case MenuChoices.AdminUser_UpdateQUICK:
                    break;
                case MenuChoices.AdminUser_UpdatePwd:
                    break;
                case MenuChoices.AdminUser_Login:
                    break;
                case MenuChoices.END:
                    break;
                default:
                    break;
            }
        }
    }
}
