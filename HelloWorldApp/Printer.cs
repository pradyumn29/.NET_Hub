namespace Printing{
    public class Printer{
        public void PrintObjects(params object [] objects){
          foreach(object obj in objects){
            Console.WriteLine(obj);
          }
        }
    }
}