Export Kit - Lightning Storm CC
Xamarin Forms Update (May 27, 2020):

  1. Open your "Page 1 - Android Large.csproj" 
     to start a new Visual Studio project
     with Xamrin Forms support.

  2. Add your required Assemblies to
     support Android, iOS and Windows.

 
  --   [[[ OR ]]]   --
 

  1. Copy your "Pages" folder in your "Page 1 - Android Large"
     export directory (this folder).

  2. Locate your Visual Studio Projects folder.  

     Default Locations
     -----------------
     WIN: %userprofile%\Projects
     MAC: ~\Projects

  3. Create a new Visual Studio Solution with 
     the name "Page 1 - Android Large" and ensure you are using 
     "Multiplatform - Blank Forms App" as
     the template.

  4. Paste the "Pages" folder into your new
     Solution's folder { /Projects/Page 1 - Android Large/Page 1 - Android Large }.

  5. Go back to your export folder (this folder) and copy
     your "Assets.xcassets" folder.

  6. Go back to your new Visual Studio Solution's folder
     and paste and *merge* your "Assets.xcassets" folder into
     { /Projects/Page 1 - Android Large/Page 1 - Android Large.iOS }.

  7. Go back to your export folder and repeat the steps
     for Android with your "res/drawable" folder and for
     Windows with your "Assets" folder.

  8. Open the "_csprojImageAsset_.txt" file and copy the
     contents.

  9. Go back to your Solution's folder and open your
     { /Projects/Page 1 - Android Large/Page 1 - Android Large.iOS/Page 1 - Android Large.iOS.csproj } file.

  10. Find the line

     <InterfaceDefinition Include="Resources\LaunchScreen.storyboard" />

     and paste the contents directly below that line.

  11. Done!