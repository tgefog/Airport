using System.Linq;
/*
SamsungA50, MotorolaG5, IphoneSE
Add - Iphone10
Remove - IphoneSE
End

HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiomiNote:Iphone5
End
 */
namespace Exam_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" - ");
                switch (arguments[0])
                {
                    case "Add":
                        phones = AddPhone(phones, arguments[1]);
                        break;
                    case "Remove":
                        phones = RemovePhone(phones, arguments[1]);
                        break;
                    case "Bonus phone":
                        string[] bonusPhone = arguments[1].Split(":");
                        phones = BonusPhone(phones, bonusPhone[0], bonusPhone[1]);
                        break;
                    case "Last":
                        phones = LastPhone(phones, arguments[1]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", phones));
        }

        static List<string> AddPhone(List<string> phones, string phone)
        {
            if (!phones.Contains(phone))
            {
                phones.Add(phone);
            }

            return phones;
        }
        private static List<string> RemovePhone(List<string> phones, string phone)
        {
            if (phones.Contains(phone))
            {
                phones.Remove(phone);
            }

            return phones;
        }
        private static List<string> BonusPhone(List<string> phones, string oldPhone, string newPhone)
        {
            int oldPhoneIndex = phones.IndexOf(oldPhone);
            if (oldPhoneIndex >= 0)
            {
                if (oldPhoneIndex >= phones.Count)
                {
                    AddPhone(phones, newPhone);
                }
                else
                {
                    phones.Insert(oldPhoneIndex + 1, newPhone);
                }
            }

            return phones;
        }
        private static List<string> LastPhone(List<string> phones, string phone)
        {
            int index = phones.IndexOf(phone);
            if (index >= 0)
            {
                string renewedItem = phones[index];
                phones.RemoveAt(index);
                AddPhone(phones, renewedItem);
            }

            return phones;
        }
    }
}