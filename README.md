# TestHarnessLiveReload
Test Harness for Westwind.AspnetCore.LiveReload FileWatcher.

1. Build and Run the solution
2. Navigate to the directory (e.g. TestHarnessLiveReload\TestHarnessLiveReload\bin\Debug\netcoreapp3.1) that contains the TestHarnessLiveReload.exe - notice a directory called "dist" is present as a sibling of the TestHarnessLiveReload.exe
3. Now, you can perform operations on the "dist" directory" (either use a terminal / command line or perform the steps manually) :  
*Commands are in Powershell Core*
  - delete "dist" - observe folder deletion is fired  
  `del dist`
  - create "dist" - observe folder creation is fired  
  `mkdir dist`
  - add a few files (.js, .html) to "dist" - observe file additions are fired  
  `cd dist`  
`New-Item -Type File hello.js`  
`New-Item -Type File hello2.js`  
  - modify one or more files added in the above step - observe files changes are fired
  - delete "dist" - observe folder deletion is fired  
`cd ..`  
 `del dist`
  - create "dist"- observe folder creation is fired  
`mkdir dist`
  - rename "dist" to "dist2" - observe folder rename is fired  
`ren dist dist2`
  - rename "dist2" "dist" - observe folder rename is fired  
`ren dist2 dist`
  - delete "dist"- observe folder deletion is fired  
`del dist`
  - create "dist"- observe folder creation is fired  
`mkdir dist`
  - add a few files (.js, .html) to "dist"- observe file additions are fired  
  `cd dist`  
  `New-Item -Type File hello.js`  
  `New-Item -Type File hello2.js`  
  - modify one or more files added in the above step - observe files changes are fired
