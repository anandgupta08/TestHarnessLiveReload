# TestHarnessLiveReload
Test Harness for Westwind.AspnetCore.LiveReload FileWatcher.

1. Build and Run the solution
2. Navigate to the directory (e.g. TestHarnessLiveReload\TestHarnessLiveReload\bin\Debug\netcoreapp3.1) that contains the TestHarnessLiveReload.exe - notice a directory called "dist" is present as a sibling of the TestHarnessLiveReload.exe
3. Now, you can perform operations on the "dist" directory" (either use a terminal / command line or perform the steps manually) :
  - delete "dist" - observe folder deletion is fired
  - create "dist" - observe folder creation is fired
  - add a few files (.js, .html) to "dist" - observe file additions are fired
  - modify one or more files added in the above step - observe files changes are fired
  - delete "dist" - observe folder deletion is fired
  - create "dist"- observe folder creation is fired
  - rename "dist" to "dist2" - observe folder rename is fired
  - rename "dist2" "dist" - observe folder rename is fired
  - delete "dist"- observe folder deletion is fired
  - create "dist"- observe folder creation is fired
  - add a few files (.js, .html) to "dist"- observe file additions are fired
  - modify one or more files added in the above step - observe files changes are fired
