using System;
using Menu;

public class main {
    public static void Main(string[] argv) {
        ConsoleMenu MainMenu     = new ConsoleMenu("Menu");
        ConsoleMenu SettingsMenu = new ConsoleMenu("Settings");

        MainMenu.AddItem(new Button(" START   "));
        MainMenu.AddItem(new Button(" Options "));
        MainMenu.AddItem(new Button(" EXIT    "));

        SettingsMenu.AddItem(new Button(" Back         "));
        SettingsMenu.AddItem(new Switcher(" Sounds ", true));
        SettingsMenu.AddItem(new Switcher(" Music  ", true));


        
        while(true) {

            int MenuLog = MainMenu.Show();

            if(MenuLog == 0) {
                Console.WriteLine("Starting");
                break;
            }
            else if(MenuLog == 1) {
                int SettingsLog = SettingsMenu.Show();

                if(SettingsLog == 0) {
                    continue;
                }
            }
            else if(MenuLog == 2) {
                Console.WriteLine("good bye...");
                break;
            }
            
        }

        Console.WriteLine(SettingsMenu.GetData()[1]);

        Console.WriteLine(SettingsMenu.GetData()[2]);
        
    }
}