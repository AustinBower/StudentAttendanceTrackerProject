   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   .    (StudentAttendanceTracker.editAttendances   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  editAttendances��5   	    � 
ResizeMode$ NoResize=�6!   $	��550��67   $	��730��6D   .��5	      � ���#A7060C$��0,-3,2,3q�6    .+�5
   
   �� -   5         ��Name$ image��5
      $
��Left=�6   $	��135��6:   $��0,0,0,0q�6G   $	��Top=�6X   $	��730��6p   $ ��Resources/Concord Logo.jpg��6|   $
��Fill=�6�    J� Opacity$
 0.95Q�6�   �� 5   
   ���#2B2B2B$
��Left=�6#   $��56��6>   $	��Top=�6J   $	��724��6b   $	 0.8Q�6n    J� RenderTransformOrigin$ 0.5,0.5&�6|   $��
-2,149,0,0q�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 1.569Q�6$   �� 5      T� 5       T� X$ 0.973Q�6)   5      5      �� 5   
   -   5         ��Name$ editAttendance��5      $��Edit Attendances��6(   $
��Left=�6C   $��123,151,0,0q�6^   $	��Top=�6s   $��27(�6�   $��Italic$�6�   $
��Bold"�6�   ���#FFFEFD6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
25,219,0,0q�6@   $	��Top=�6T   $	��279��6l   $	��363��6y   �� 5   
   -   5        $ ID��5      $��Student ID:��6   $
��Left=�62   $��415,232,0,0q�6M   $	��Top=�6b   $��79��6z   ���#FFFEFD6�   �� 5   
   -   5        $ Attendances��5      $��Attendances:��6%   $
��Left=�6<   $��417,279,0,0q�6W   $	��Top=�6l   $��79��6�   ���#FFFEFD6�   �� 5   
   -   5        $ AttendanceDate��5      $��Attendance Date:��6(   $
��Left=�6C   $��417,328,0,0q�6^   $	��Top=�6s   $	��109��6�   ���#FFFEFD6�   �� 5   
   -   5        $ AttendanceTime��5      $��Attendance Time:��6(   $
��Left=�6C   $��417,385,0,0q�6^   $	��Top=�6s   $	��109��6�   ���#FFFEFD6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 dateAttendance��5      $
��Left=�6-   $��530,330,0,0q�6H   $	��Top=�6]   $	��158��6u   �� 5   
   -	   5        
 ��Name$
 txtID��5      $
��Left=�6!   $��23��6<   $��530,232,0,0q�6H    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��158��6�   �� 5   
   -
   5        $
 txtAttendances��5      $
��Left=�6*   $��23��6E   $��530,282,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��158��6�   �� 5   
   -   5        $
 txtTime��5      $
��Left=�6#   $��23��6>   $��531,385,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��157��6�   �� 5   
   -   5         ��Name$ btnView��5      $
��View��6"   $
��Left=�61   $��415,447,0,0q�6L   $	��Top=�6a   $��75��6y   ���#FFFEFD��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5#      $ White��6#   $ 1Q�61   5$      5&      �� 5'   
   -   5        $ 	btnUpdate��5'      $��Update��6$   $
��Left=�65   $��521,447,0,0q�6P   $	��Top=�6e   $��75��6}   ���#FFFEFD��5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $ Black��6#   $ 0Q�61   � 5+      $ White��6#   $ 1Q�61   5,      5.      �� 5/   
   -   5        $ 	btnDelete��5/      $��Delete��6$   $
��Left=�65   $��627,447,0,0q�6P   $	��Top=�6e   $��75��6}   ���#FFFEFD��50      �� 51      $ 0.5,1&�6&   $ 0.5,0&�67   .��52      � $ Black��6#   $ 0Q�61   � 53      $ White��6#   $ 1Q�61   54      56      57      58      