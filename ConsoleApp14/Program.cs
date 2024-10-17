namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            Book book = new Book();

            book.Title = "Laws of Power";
            book.Author = "Robert Greene";
            book.Year = "1998 ";
            book.ISBN = "9780140280197";
            book.GetBookTitle();
             

            Member member = new Member();

            member.Name = "Yalda";
            member.MemberID = "1";
            member.Phone = "+989339808855";
            member.GetMemberName();


        }
    }
}
