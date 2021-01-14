using System;
namespace IK.DesignPatterns.IKPracticeProblems.FileSystem
{

    abstract class File{
        int fieldId { get; set; }
        string name { get; set; }
        string type { get; set; }
        byte content { get; set; }

        public abstract void Accept(FileVisitor fv);
    }


    class WordFile : File
    {
        public override void Accept(FileVisitor fv)
        {
            fv.visitWord(this);
        }
    }


    class PictureFile : File
    {
        public override void Accept(FileVisitor fv)
        {
            fv.visitPicture(this);
        }
    }

    abstract class FileVisitor
    {
        public abstract void visitWord(WordFile f);
        public abstract void visitPicture(PictureFile f);
    }


    class PrintFileVisitor : FileVisitor
    {
        public override void visitPicture(PictureFile f)
        {
            Console.WriteLine("Open picture viewer and print picture");
        }

        public override void visitWord(WordFile f)
        {
            Console.WriteLine("Open word and print word document");
        }
    }

    public class FileSystem
    {
        File[] files = new File[] { new PictureFile(), new WordFile() };

        FileVisitor v = new PrintFileVisitor();

        public void TestFileSystem()
        {
           
         
                foreach (var f in files)
                {
                    f.Accept(v);
                }
            
        }
    }
}
