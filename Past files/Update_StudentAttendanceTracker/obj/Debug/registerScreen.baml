   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   -    'StudentAttendanceTracker.registerScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  Register��5   	   $��427.436��6   $��766.5��6+    � WindowState$ 	Maximized=�69   .��5	      � ���	#FF741D1E.+�5
   
   �� -   5         ��Name$ registerUsername��5
      $��
User Name:��6*   $��235,86,393,279q�6?   $��Center=�6W   $��16(�6r   $��31��6�   $	��130��6�   $��Right=�6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5        $ registerName��5      $��Professor Name:��6&   $��239,117,387,248q�6@   $��Center=�6Y   $��16(�6t   $��31��6�   $	��132��6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5        $ registerDepartment��5      $��
Deparment:��6,   $��272,145,391,220q�6A   $��Center=�6Z   $��16(�6u   $��31��6�   $��95��6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5        $ registerEmail��5      $��Email:��6'   $��313,176,391,190q�68   $��Center=�6Q   $��16(�6l   $��30��6z   $��54��6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5        $ registerPassword��5      $��	Password:��6*   $��277,207,393,157q�6>   $��Center=�6W   $��16(�6r   $��88��6�   $��32��6�   $��Right=�6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5        $ registerConfirmPassword��5      $��ConfirmPassword:��61   $��228,239,392,117q�6L   $��Center=�6e   $��16(�6�   $��40��6�   $	��138��6�   ���	#FFFFECC7$��Center=�6�   �� 5   
   -   5         ��Name$ usernameTextBox��5      $��Center=�6+   $��23��6H   $��394,94,244,279q�6T    �� TextWrapping$
 Wrap=�6l   $��Center=�6�   $	��120��6�   $��16(�6�   $��1��6�   �� 5   
   -   5        $ professornameTextBox��5      $��Center=�60   $��23��6M   $��394,124,244,249q�6Y   $
 Wrap=�6r   $��Center=�6�   $	��120��6�   $��16(�6�   $��2��6�   �� 5   
   -	   5        $ departmentTextBox��5      $��Center=�6-   $��23��6J   $��394,154,244,219q�6V   $
 Wrap=�6o   $��Center=�6�   $	��120��6�   $��16(�6�   $��3��6�   �� 5   
   -
   5        $ emailTextBox��5      $��Center=�6(   $��23��6E   $��394,184,244,189q�6Q   $
 Wrap=�6j   $��Center=�6~   $	��120��6�   $��16(�6�   $��4��6�   �� 5   
   -   5         ��Name$ registerSubmitButton��5      $��Register��6/   $��Center=�6B   $��278,335,392,29q�6_   $��Center=�6w   $��88��6�   $��Center=�6�   $��16(�6�   $��32��6�   $��7��6�    �� 	IsDefault . 6  �� 5   
   -   5        $ registerGoBackButton��5      $��GoBack��6/   $��Center=�6@   $��394,335,273,29q�6]   $��Center=�6u   $��91��6�   $��Center=�6�   $��16(�6�   $��32��6�   $��8��6�    �� IsCancel . 6	  �� 5   
   -   5        $ registerScreenNameLabel��5      $��Register��61   $
��Left=�6D   $��	89,36,0,0q�6_   $	��Top=�6r   $��26.667(�6�   $��Italic$�6�   $
��Bold"�6�   ���	#FFFFECC76�   �� 5   
   -   5        $ passwordNotEqual��5      $�� ��6*   $��Center=�65   $��214,373,177,-23q�6R   $��Center=�6k   $	��367��6�   $��22(�6�   $��46��6�   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 5   
   -   5        $ 
formFilled��5      $�� ��6$   $��Center=�6/   $��243,35,148,316q�6L   $��Center=�6d   $	��367��6   $��22(�6�   $��46��6�   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 5   
   -   5        $ 	testlabel��5      $
��Left=�6#   $��
630,94,0,0q�6>   $	��Top=�6R   G� 5   
   -   5         G�Name$ passwordTextBox��5      $��Center=�6/   $��394,217,244,157q�6L   $��Center=�6e   $	��120��6�   $��22��6�   G� 5   
   -   5        $ confirmpasswordTextBox��5      $��Center=�66   $��394,247,244,127q�6S   $��Center=�6l   $	��120��6�   $��22��6�   �� 5   
   -   5        $" registerConfirmPassword_Copy��5      $[��UYour password should be at least 6 bits, and include Uppercase, Lowercase, and Number��66   $��Right=�6�   $��0,284,111,72q�6�   $��Center=�6�   $��12(�6�   $��40��6�   $	��489��6�   ���	#FFFFECC76	  5      5      