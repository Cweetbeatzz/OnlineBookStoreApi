STEP 1 -----------------------> Clone from Github
STEP 2 -----------------------> Open the Project
STEP 3 -----------------------> Make sure you have sql server database in your system
STEP 4 -----------------------> In the opened project right click on the project solution to build and install necessary plugins
STEP 5 -----------------------> on the menu bar follow Tools -> Command Line -> click developer powershell
STEP 6 -----------------------> on the opened terminal (dotnet tool install --global dotnet-ef) copy and paste what is in the bracket and press enter
STEP 7 -----------------------> on completion of step 6 paste this also and press enter (dotnet ef migrations add initial)
STEP 8 -----------------------> step 7 i have written static some demo data so it dumps it into your database for testing
STEP 9 -----------------------> on completion of step 8 paste this also and enter (dotnet ef database update)
STEP 10 -----------------------> Mafter step 9 you are all set to test with dummy data
STEP 11 -----------------------> press the play button at the menu bar the one with a dropdown my the side also select IIS Express if it is not selected before pressing play
STEP 12 -----------------------> right after press play your browser should some up there are three endpoints the requirments
STEP 13 -----------------------> test them all works fine
STEP 14 -----------------------> to delete there are 10 demo data i created you can delete the last two filling 9,10
STEP 15 -----------------------> getting revenue filling in the date using this format ---> startdate = 2024-03-01 & endate = 2024-05-10

THANKS...









