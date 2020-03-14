using System;
using Menu;

public class main {
    public static void Main(string[] argv) {
        ConsoleMenu menu = new ConsoleMenu("Menu");

        menu.AddItem<Button>(new Button("Start"));

        menu.Show();
    }
}