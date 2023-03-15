namespace SDP
{
  public abstract class WriteStrategy
  {
    public abstract void Write();
  }
  
  public class WritewithPen: WriteStrategy
  {
    public override void Write()
    {
      Console.WriteLine("Writing with a Pen!");
    }
  }
  
  public class WritewithPencil: WriteStrategy
  {
    public override void Write()
    {
      Console.WriteLine("Writing with a Pencil!");
    }
  }
  
  public class WriteonPaper
  {
    private WriteStrategy _writeStrategy;
    public void SetWriteStrategy(WriteStrategy writeStrategy)
    {
      this._writeStrategy = writeStrategy;
    }
    public void StartWriting()
    {
      this._writeStrategy.Write();
      Console.WriteLine("blah blah..");
    }
  }
  public class Program
  {
    public static void main()
    {
      int age = -1;
      Console.WriteLine("Age?");
      int age = int.parse(Console.ReadLine());
      if(age >= 9)
      {
        writeStrategy.SetWriteStrategy(new WritewithPen());
      }
      else
      {
        writeStrategy.SetWriteStrategy(new WritewithPencil());
      }
      WriteonPaper writeonPaper = new WriteonPaper(writeStrategy);
      writeonPaper.StartWriting();
    }
  }
}
