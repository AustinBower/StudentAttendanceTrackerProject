   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   (    "StudentAttendanceTracker.SwipeCard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  Student Login��5   
    � 
ResizeMode$ NoResize=�6    $	��550��66   $	��730��6C    � WindowStartupLocation$ CenterScreen=�6P   $��Center=�6u   .��5
      � ���#A7060C.+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��135��6:   $��0,0,0,0q�6G   $	��Top=�6X   $	��730��6p   $ ��Resources/Concord Logo.jpg��6|   $
��Fill=�6�    J� Opacity$
 0.95Q�6�   �� 5   
   ���#2B2B2B$��Right=�6#   $	��231��6?   $	��Top=�6L   $	��730��6d   $��
-6,169,0,0q�6p   $	 0.6Q�6�   �� 5   
   -   5         ��Name$ go_back_button��5      $��Go Back��5      $��Center=�5      $��308,447,336,51q�5      $��Center=�5      $
��Bold"�5      
�������$��80��5      $��23��5   .   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   	 � Offset$	 0Q�61   � 5      $ White��6#   $	 1Q�61   5      5      �� 5   
   -   5        
 ��Name$
 student_instruction_block��5      $��Center=�5      $��116,265,86,207q�5      $
��Wrap=�5       ���#FFFEFD$��Copperplate Gothic Bold)�5"      $"��Please swipe student ID card��5#      $��Center=�5$       J� RenderTransformOrigin$ 0.408,-3.375&�5%      $��49��5&      $	��522��5'      $��30(�5(      �� 5*   
   -   5         ��Name$ student_ID_input_box��5*      $��Center=�5+      $��23��5,      $��276,338,292,160q�5-       �� TextWrapping$
 Wrap=�5.      $��Center=�5/      $	��156��50      $�� ��51      $ 0.492,0.478&�52       � Cursor$ IBeam��54       �� 	MaxLength$ 18��55      $	 0.5Q�6$   �� 56   
   -   5         ��Name$ Course��56      $��Select Course��6    $
��Left=�68   $��116,206,0,0q�6S   $	��Top=�6h   $	��109��6�   ���#FFFEFD$
��Bold"�6�   �� 57   
   -   5         ��Name$ class_select_comboBox��57      $��Center=�58   
   $��246,206,214,289q�59   
   $��Center=�5:   
   $	��264��5;   
   $��26��5<   :    +� FocusedElement 5=      ��  �� ElementName$ student_ID_input_box��5?      5@      