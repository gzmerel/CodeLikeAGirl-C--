namespace BookClub
{
public class Member
    {
        public string firstName;
        public string lastName;
        public void PrintMember()
        {
            Console.WriteLine($"{firstName} {lastName}'s favourite book is:{favouriteBook} ");
            Console.WriteLine($"Books on {firstName}'s reading list");
        }
        public string favouriteBook;
        public List<Book> readingList;
    }
}
