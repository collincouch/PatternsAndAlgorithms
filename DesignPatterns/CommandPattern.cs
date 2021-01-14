using System;
using System.Collections.Generic;
/// <summary>
/// Use when you need to decouple the execution of a piece of code
/// from the object it's executed on
///
/// Command object that encapsulates the code in your method
///
/// Benefit is that you can defer execution  or remember what you
/// executed or support undo operaitons
/// </summary>
namespace IK.DesignPatterns
{
    class Document
    {
        public string text="";
    }

    abstract class DocumentCommand
    {
        public Document document;
        public DocumentCommand(Document document)
        {
            this.document = document;
        }
        public abstract void execute();
        public abstract DocumentCommand createUndo();
    }

    class AddCharCommand : DocumentCommand
    {
        char c;
        public AddCharCommand(Document document, char c)
            : base(document)
        {
            this.c = c;
        }

        public override DocumentCommand createUndo()
        {
            return new DeleteCharCommand(document);
        }

        public override void execute()
        {
            document.text += c;
        }

    }

    class DeleteCharCommand : DocumentCommand
    {

        public DeleteCharCommand(Document document)
            : base(document)
        {

        }

        public override DocumentCommand createUndo()
        {
            return null;
        }

        public override void execute()
        {
            document.text = document.text.Substring(0, 1);
        }
    }
    public class CommandPattern
    {
        public void TestCommandPattern()
        {
            Document d = new Document();
            List<DocumentCommand> dc = new List<DocumentCommand>();

            dc.Add(new AddCharCommand(d, 'H'));
            dc.Add(new AddCharCommand(d, 'I'));

            foreach(var x in dc)
            {
                x.execute();
            }

            Console.WriteLine(d.text);

        }
    }
}
