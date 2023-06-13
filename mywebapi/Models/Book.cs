namespace mywebapi
{
    public class Book
    {
        List<Book> bookCollection;
        public void initCollection(){
        bookCollection=new List<Book>();
        bookCollection.Add(new Book(1,"C#","Teppo Testi","12-23-45"));
        bookCollection.Add(new Book(2,"C++","Teppo Testi","22-23-45"));
        bookCollection.Add(new Book(3,"Java","Teppo Testi","32-23-45"));
             bookCollection.Add(new Book(4,"Render","Teppo Testi","32-23-45"));
        }
        public int id_book { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }    
        public Book(int id, string n, string a, string i){
            id_book=id;
            name=n;
            author=a;
            isbn=i;
        }    
        public Book(){}
        
        public List<Book> GetAllBooks(){
            initCollection();
            return bookCollection;
        }
        public Book GetOneBook(int id){
            initCollection();
            return bookCollection[id-1];
        }
    }

}