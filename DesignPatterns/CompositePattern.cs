using System;
using System.Collections.Generic;
/// <summary>
/// Use when you have a hierarchy of objects
/// Commonly used when programming a deeply nested Windows menu
/// </summary>
namespace IK.DesignPatterns
{
    public abstract class MenuComponent
    {
        public string text;

        public MenuComponent(string text)
        {
            this.text = text;
        }
    }

    public class MenuItem : MenuComponent
    {
        public MenuItem(string text) : base(text) {
        }
    }

    public class Menu : MenuComponent
    {
        public List<MenuComponent> components = new List<MenuComponent>();
        public Menu(string text) : base(text)
        {

        }
    }
    public class CompositePattern
    {
        public void TestCompositePattern()
        {
            Menu file = new Menu("File");
            file.components.Add(new MenuItem("Open"));
            file.components.Add(new MenuItem("Save"));
            file.components.Add(new MenuItem("Exit"));

            Menu recentFiles = new Menu("Recent");
            file.components.Add(recentFiles);

            //Menu edit = new Menu("edit");


        }
    }
}
