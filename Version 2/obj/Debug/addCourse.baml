   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   (    "StudentAttendanceTracker.addCourse   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  	addCourse��5   	    � 
ResizeMode$ NoResize=�6   $	��550��61   $	��730��6>   .��5	      � ���	#FF741D1E$��0,0,2,1q�6"   .+�5
   
   � $��-8,161,0,267q�6   .+�5      �� ���#EFEFF1$��Right=�6'   $��92��6C   $	��Top=�6O   $	��730��6g   �� 5      -   5         ��Name$ image1��5      $
��Left=�6$   $��90��6?   $��	110,2,0,0q�6K   $	��Top=�6^   $	��498��6v   $��Resources/step1.jpg��6�   $
��Fill=�6�    J� Opacity$
 0.95Q�6�   5      �� 5   
   -   5         ��Name$ label��5      $��Step 1: Add Courses��6   $��Center=�6=   $��304,91,92,378q�6Z   $��Center=�6q   $��Italic$�6�   $��24(�6�   ���#FFFEFD$
��Bold"�6�   $	��326��6�   $��51��6�   �� 5   
   -   5         ��Name$ addCourseCRN��5      $��Center=�6(   $��30��6E   $��304,357,168,133q�6Q    �� TextWrapping$
 Wrap=�6j   $��Center=�6~   $	��250��6�   �� 5   
   -   5        $ label2��5      $
��CRN:��6    $��Center=�6/   $��206,351,458,135q�6L   $��Center=�6e   $��18(�6�   ���#FFFEFD$��34��6�   $
��Bold"�6�   $��58��6�   �� 5   
   -   5         ��Name$ addCourseSubmit��5      $��Submit��6*   $��Center=�6;   $��302,468,319,22q�6X   $��Center=�6p   $	��101��6�   $��30��6�   
�������$	 0.9Q�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ 
courseName��5      $��Center=�6&   $��30��6C   $��304,405,168,85q�6O   $
 Wrap=�6g   $��Center=�6{   $	��250��6�   �� 5   
   -   5        $ label3��5      $��Course Name:��6    $��Center=�67   $��125,399,462,87q�6T   $��Center=�6l   $��18.667(�6�   ���#FFFEFD$��34��6�   $	��135��6�   $
��Bold"�6�   �� 5   
   -   5        $ image��5      $
��Left=�6   $	��194��6:   $��0,0,0,0q�6G   $	��Top=�6X   $	��206��6p   $��Resources/conc.png��6|   $
��Fill=�6�   $
 0.95Q�6�   �� 5   
   -	   5        $ errormessage��5      $�� ��6&   $��Center=�61   $��186,293,168,195q�6N   $��Center=�6g   $	��368��6�   $��22(�6�   $��32��6�   $
��Bold"�6�   ���#FFFEFD J� RenderTransformOrigin$ 0.465,0.326&�6�   5      5      