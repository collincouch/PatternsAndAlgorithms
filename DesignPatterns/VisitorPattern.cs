using System;
namespace IK.DesignPatterns
{
    //Imagin when you have a lot of different
    //files:  word docs, pictures, spread sheets, etc.
    //There are a number of diffent operations
    //that you would do on each file type.

    //The visitor pattern allows you to easly
    //add new operations when new file types
    //are discovered

     abstract class FileVisitor
    {
        public abstract void visitWord(WordFile f);
        public abstract void visitPicture(PictureFile f);
    }

    abstract class File
    {
        public abstract void visit(FileVisitor fv);
    }

    class WordFile : File
    {
        public override void visit(FileVisitor fv)
        {
            fv.visitWord(this);
        }
    }

     class PictureFile : File
    {
        public override void visit(FileVisitor fv)
        {
            fv.visitPicture(this);
        }
    }


    /// <summary>
    /// This class is where we can easly add new operations
    /// for each file type as those file types are added.
    /// </summary>
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

    public class VisitorPattern
    {
        File[] files = new File[] { new PictureFile(), new WordFile() };

        FileVisitor v = new PrintFileVisitor();

        public void Test()
        {
            foreach (var f in files)
            {
                f.visit(v);
            }
        }
    }
}
