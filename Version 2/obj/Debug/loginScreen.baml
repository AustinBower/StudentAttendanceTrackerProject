   M S B A M L   `   `   `  ����S  OStudentAttendanceTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StudentAttendanceTrackerStudentAttendanceTracker  5   	   *    $StudentAttendanceTracker.loginScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StudentAttendanceTracker     5   	     � Title$  Login��5   	    � 
ResizeMode$ NoResize=�6   $	��550��6-   $	��730��6:   .��5	      � ���#8A2432.+�5
   
   �� -   5         ��Name$ image��5
      $
��Left=�6   $��84��6:   $��	36,10,0,0q�6F   $	��Top=�6Y   $	��291��6q   $��Resources/RegLogo.png��6}   $
��Fill=�6�   �� 5   
   ���#2B2B2B$
��Left=�6#   $��96��6>   $��0,94,0,0q�6J   $	��Top=�6\   $	��724��6t    J� Opacity$	 0.8Q�6�   �� 5   
   -   5         ��Name$ LoginScreenNameLabel��5      $��Login��6.   $
��Left=�6>   $��120,107,0,0q�6Y   $	��Top=�6n   $��27(�6�   $��Italic$�6�   $
��Bold"�6�   ���#FFFEFD6�   �� 5   
   -   5        $ loginUsernameLabel��5      $��
User Name:��6,   $��232,249,388,240q�6A   $��Center=�6Z   $��Center=�6u   $��16(�6�   $	��104��6�   $��32��6�   $��Right=�6�   ���#FFFEFD$
��Bold"�6�   �� 5   
   -   5        $ usernamePasswordLabel��5      $��	Password:��6/   $��231,283,389,206q�6C   $��Center=�6\   $��Center=�6w   $��16(�6�   $	��104��6�   $��32��6�   $��Right=�6�   ���#FFFEFD$
��Bold"�6�   G� 5   
   -   5         G�Name$ loginPasswordBox��5      $��346,284,248,211q�60   $��10,1,1,0q�6I   $��Center=�6\   $	��130��6w   $��26��6�   $��Center=�6�   $��2��6�   �� 5   
   -   5         ��Name$ usernameTextBox��5      $��26��6+   $��346,254,248,241q�67   $��10,1,1,0q�6P    �� TextWrapping$
 Wrap=�6c   $��Center=�6w   $	��130��6�   $��Center=�6�   $��1��6�   �� 5   
   -   5        $ passwordNotEqual��5      $�� ��6*   $��Center=�65   $��48,345,26,144q�6R   $��Center=�6i   $	��650��6�   $��18(�6�   $��32��6�   ���#FFFEFD J� RenderTransformOrigin$ 0.465,0.326&�6�   �� 5   
   -   5        	 ��Name$	 loginSubmitButton��5      $��Submit��6,   $��Center=�6=   $��257,405,365,82q�6Z   $��Center=�6r   $	��102��6�   $��34��6�   $��3��6�   
 �� 	IsDefault
 . 
�������$	 0.9Q�6�   $
��Bold"�6  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -	   5        $	 loginGoBackButton��5      $��Go Back��6,   $��Center=�6>   $��381,405,243,82q�6[   $��Center=�6s   $	��100��6�   $��34��6�   $��4��6�    �� IsCancel . 
�������$	 0.9Q�6�   $
��Bold"�6  ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5!      5#      5$      