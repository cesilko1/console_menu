using System;
using Menu;

public class main {
    public static void Main(string[] argv) {
        ConsoleMenu menu = new ConsoleMenu("Menu");

        menu.AddItem(new Button(" START "));
        menu.AddItem(new Switcher(" Sounds ", false));
        menu.AddItem(new Switcher(" Music  ", true));
        menu.AddItem(new Button(" EXIT "));

        menu.Show();
    }
}