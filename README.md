Universal Component lab
===========

Part 1 - Two usercontrols
-----------
1. Extract MainPage.xaml contents into a usercontrol in both Win and Wp8.1 with the same name.
2. Remove MainPage.xaml from the platform projects and add a MainPage.xaml in the shared project.
3. Add the usercontrol to the new MainPage and run.
4. Add a partial ItemVM in the Windows project and add a new RelayCommand bound to a new button in the xaml.
5. Play around with and do some changes.

Part 2 - Shared usercontrol
-----------
1. Add a new Usercontrol to the shared project.
2. Copy the xaml from the other controls and set the grid to collapsed.
3. Add a #if to check if Phone or Desktop and set one grid to visible.
4. Try to create the layout in code behind.
5. Play around with and do some changes.