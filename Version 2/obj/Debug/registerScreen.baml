   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   -    'StudentAttendanceTracker.registerScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  Register��5   	    � 
ResizeMode$ NoResize=�6   $	��600��60   $	��730��6=   .��5	      � ���#8A2432$��0,-2,0,2q�6    .+�5
   
   �� -   5         ��Name$ registerUsername��5
      $��
User Name:��6*   $��198,244,376,295q�6?   $��Center=�6X   $��16(�6s   $��32��6�   $	��150��6�   $��Right=�6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5        $ registerName��5      $��Professor Name:��6&   $��198,274,376,265q�6@   $��Center=�6Y   $��16(�6t   $��32��6�   $	��150��6�   $��Right=�6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5        $ registerDepartment��5      $��
Deparment:��6,   $��198,304,376,235q�6A   $��Center=�6Z   $��16(�6u   $��32��6�   $	��150��6�   $��Right=�6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5        $ registerEmail��5      $��Email:��6'   $��198,334,376,205q�68   $��Center=�6Q   $��16(�6l   $��32��6z   $	��150��6�   $��Right=�6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5        $ registerPassword��5      $��	Password:��6*   $��198,366,376,173q�6>   $��Center=�6W   $��16(�6r   $	��150��6�   $��32��6�   $��Right=�6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5        $ registerConfirmPassword��5      $��ConfirmPassword:��61   $��210,399,364,140q�6L   $��Center=�6e   $��16(�6�   $��32��6�   $	��150��6�   ���#FFFEFD$��Center=�6�   �� 5   
   -   5         ��Name$ usernameTextBox��5      $��Center=�6+   $��28��6H   $��357,250,167,295q�6T   $��10,1,1,0q�6m    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��200��6�   $��16(�6�   $��1��6�    J� Opacity$	 0.8Q�6�   $��Italic$�6�   �� 5   
   -   5        $ professornameTextBox��5      $��Center=�60   $��28��6M   $��357,280,167,265q�6Y   $��10,1,1,0q�6r   $
 Wrap=�6�   $��Center=�6�   $	��200��6�   $��16(�6�   $��2��6�   $	 0.8Q�6�   $��Italic$�6�   �� 5   
   -	   5        $ departmentTextBox��5      $��Center=�6-   $��28��6J   $��357,310,167,235q�6V   $��10,1,1,0q�6o   $
 Wrap=�6�   $��Center=�6�   $	��200��6�   $��16(�6�   $��3��6�   $	 0.8Q�6�   $��Italic$�6�   �� 5   
   -
   5        $ emailTextBox��5      $��Center=�6(   $��28��6E   $��357,340,167,205q�6Q   $��10,1,1,0q�6j   $
 Wrap=�6}   $��Center=�6�   $	��200��6�   $��16(�6�   $��4��6�   $	 0.8Q�6�   $��Italic$�6�   �� 5   
   -   5         ��Name$ registerSubmitButton��5      $��Register��6/   $��Center=�6B   $��312,472,291,17q�6_   $��Center=�6w   $	��121��6�   $��Center=�6�   $��16(�6�   $��32��6�   $��7��6�    �� 	IsDefault . 
�������$	 0.9Q�60  ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 � MappingMode$	 RelativeToBoundingBox=�67   
 �� 
StartPoint$
 0.5,0&�6[   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ 
formFilled��5      $�� ��6$   $��Center=�6/   $��243,35,148,316q�6L   $��Center=�6d   $	��367��6   $��22(�6�   $��46��6�   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 5   
   -   5        $ 	testlabel��5      $
��Left=�6#   $��
630,94,0,0q�6>   $	��Top=�6R   G� 5   
   -   5         G�Name$ passwordTextBox��5      $��Center=�6/   $��28��6L   $��357,372,167,175q�6X   $��10,1,1,0q�6q   $��Center=�6�   $	��200��6�   $	 0.8Q�6�   G� 5   
   -   5        $ confirmpasswordTextBox��5      $��Center=�66   $��28��6S   $��357,401,167,142q�6_   $��10,1,1,0q�6x   $��Center=�6�   $	��200��6�   $	 0.8Q�6�   �� 5    
   -   5         ��Name$ image��5       $
��Left=�6   $��84��6:   $��	36,10,0,0q�6F   $	��Top=�6Y   $	��291��6q   $��Resources/RegLogo.png��6}   $
��Fill=�6�   �� 5!   
   -   5        $ passwordNotEqual��5!      $�� ��6*   $��Center=�65   $��198,431,158,58q�6R   $��Center=�6j   $	��368��6�   $��22(�6�   $��32��6�   $
��Bold"�6�   ���#FFFEFD J� RenderTransformOrigin$ 0.465,0.326&�6�   �� 5"   
   ���#2B2B2B$
��Left=�6#   $��96��6>   $��0,93,0,0q�6J   $	��Top=�6\   $	��724��6t   $	 0.8Q�6�   �� 5#   
   -   5        $ registerScreenNameLabel��5#      $��Register��61   $
��Left=�6D   $��
115,92,0,0q�6_   $	��Top=�6s   $��27(�6�   $��Italic$�6�   $
��Bold"�6�   ���#FFFEFD6�   �� 5$   
   -   5        $" registerConfirmPassword_Copy��5$      $m��gYour password should be at least 6 bits, and include Uppercase, Lowercase, Number, and punctuation mark��66   $��Right=�6�   $��0,152,22,379q�6�   $��Center=�6�   $��12(�6�   $��40��6  $	��577��6  ���#FFFEFD6  5%      5&      