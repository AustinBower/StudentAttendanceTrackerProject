   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   )    #StudentAttendanceTracker.homeScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$
  Home��5   	   $��471.277��6   $��1231.064��6'    � WindowState$ 	Maximized=�68   .��5	      � ���	#FF741D1E$��
0,31,0,-31q�6"   .+�5
   
   �� -   5         ��Name$ addStudentButton��5
      $��Add Student��6+   $��Center=�6A   $��851,114,271,0q�6^   $	��Top=�6u   $	��101��6�   6�   �� 5   
   -   5        $ logOutButton��5      $��Log Out��6'   $��Center=�69   $��851,215,271,0q�6V   $	��Top=�6m   $	��101��6�    �� IsCancel . 6�   �� 5   
   -   5        $ addCoursesButton��5      $��Add Courses��6+   $��Center=�6A   $��852,75,271,0q�6^   $	��Top=�6t   $	��100��6�   6�   �� 5   
   -   5         ��Name$ Course_comboBox��5      $
��Left=�6,   $��
149,75,0,0q�6G   $	��Top=�6[   $	��178��6s   6   �� 5   
   -   5        $ checkButton��5      $��Get Course Lists��6&   $
��Left=�6A   $��
391,75,0,0q�6\   $	��Top=�6p   $	��135��6�    J� RenderTransformOrigin$ -0.053,0.15&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5         AutoGenerateColumns . $
��Left=�6@   $��149,136,0,0q�6[   $	��Top=�6p   $	��149��6�   $	��377��6�   6�   �� 5   
   -   5        $ LoadTableButton��5      $��Check Attendance��6*   $
��Left=�6E   $��149,313,0,0q�6`   $	��Top=�6u   $	��128��6�   6�   5      5      