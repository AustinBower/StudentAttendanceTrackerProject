   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   )    #StudentAttendanceTracker.addStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  Add Student��5   	    � 
ResizeMode$ NoResize=�6   $	��550��63   $	��730��6@   .��5	      � ���	#FF741D1E.+�5
   
   �� -   5         ��Name$ image��5
      $
��Left=�6   $	��194��6:   $��0,0,0,0q�6G   $	��Top=�6X   $	��206��6p   $��Resources/conc.png��6|   $
��Fill=�6�    J� Opacity$
 0.95Q�6�   � 5   
   $��-6,157,0,260q�6   .+�5      �� ���#EFEFF1$��Right=�6'   $	��104��6C   $	��Top=�6P   $	��730��6h   �� 5      -   5        $ image1��5      $
��Left=�6$   $��90��6?   $��	108,6,0,0q�6K   $	��Top=�6^   $	��498��6v   $��Resources/step2.jpg��6�   $
��Fill=�6�   $
 0.95Q�6�   5      �� 5   
   -   5         ��Name$ label��5      $��Step 2: Add Students��6   $��Center=�6>   $��331,65,139,402q�6[   $��Center=�6s   $��Italic$�6�   $��24(�6�   ���#FFFEFD$
��Bold"�6�   $	��254��6�   $��54��6�   �� 5   
   -   5         ��Name$ 	studentID��5      $��Center=�6%   $��30��6B   $��312,322,162,169q�6N    �� TextWrapping$
 Wrap=�6g   $��Center=�6{   $	��250��6�   �� 5   
   -   5        $ studentName��5      $��Center=�6'   $��30��6D   $��312,378,162,113q�6P   $
 Wrap=�6i   $��Center=�6}   $	��250��6�   �� 5   
   -   5        $ label1��5      $��Student ID:��6    $��Center=�66   $��197,315,418,169q�6S   $��Center=�6l   $��18(�6�   ���#FFFEFD$
��Bold"�6�   $	��109��6�   $��37��6�   �� 5   
   -   5        $ label2��5      $��Student Name:��6    $��Center=�68   $��167,372,414,112q�6U   $��Center=�6n   $��18(�6�   ���#FFFEFD$
��Bold"�6�   $��37��6�   $	��143��6�   �� 5   
   -   5         ��Name$ addStudentSubmit��5      $��Submit��6+   $��Center=�6<   $��303,483,328,14q�6Y   $��Center=�6q   $��93��6�   $��24��6�   
�������$	 0.9Q�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 White��6#   $ 1Q�61   5      5      �� 5   
   -	   5        $ label3��5      $
��CRN:��6    $
��Left=�6/   $��252,433,0,0q�6J   $	��Top=�6_   $��18(�6w   $
��Bold"�6�   ���#FFFEFD6�   �� 5   
   -
   5         ��Name$ CRNcomboBox��5      $
��Left=�6(   $��312,433,0,0q�6C   $	��Top=�6X   $	��250��6p   6|   �� 5   
   -   5        $ errormessage��5      $�� ��6&   $��Center=�61   $��195,275,161,214q�6N   $��Center=�6g   $	��368��6�   $��22(�6�   $��32��6�   $
��Bold"�6�   ���#FFFEFD J� RenderTransformOrigin$ 0.465,0.326&�6�   5      5       