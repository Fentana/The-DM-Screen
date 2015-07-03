# Virtual DM Screen
Built for Role Playing Games (specifically D&amp;D Fifth Edition)

##What Does It Do?
This project allows you to quickly catalog and document Campaigns, Episodes, Encounters, Players and Monsters, and more. It quickly generates a Wiki based on everything you plug into it.

##What Are This Project's Design Goals?
I plan on incorporating a DM's Tookit based on my Procedural Generation Engine. You'll be able to quickly add new NPCs, locations, and even completely new campaign settings based on pseudorandom/procedural generation. This will be a work in progress for quite some time, and I will be pushing everything to my The-Dm-Screen/Experimental branch in the meantime. I will push updates into The-Dm-Screen/master as they become stable.

##How Do I Contribute?
Note: You will need Visual Studio 2013 or later!

1. Fork etkirsch/The-DM-Screen into your own repository
2. Clone your repository
3. When you open "The-DM-Screen/The DM's Screen.sln", open up your **Tools > Options** and then navigate to **Database Tools > Data Connections**. Make sure that your *SQL Server Instance Name* field is set to `(LocalDB)\MSSQLLocalDB`
4. Build the project, allowing for NuGet to grab all packages it needs
5. Restart Visual Studio 2013
6. Reopen the solution, then open your NuGet Package Manager
7. Run the `Update-Database" command, which will build and seed your new database
8. Begin Debugging
9. You're done!

If you run into issues where the NuGet Package Manager concole spits out `Cannot attach the file '\The-Dm-Screen\The DM's Screen\App_Data\DmScreenContext.mdf' as database 'DmScreenContext'.` or similar, execute the following commands:

1. `SqlLocalDB.exe stop MSSQLLocalDB`
2. `SqlLocalDB.exe delete MSSQLLocalDB`
3. `Update-Database`

##Things to consider
* Need authentication for DM, at the very least. Only one person should be able to add to the encounter feed
* Need AJAX to update the form when the DM pushes to the page
