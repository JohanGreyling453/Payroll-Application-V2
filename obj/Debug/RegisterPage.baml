   M S B A M L   `   `   `  ����O  KPayroll Appplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Payroll_AppplicationPayroll_Appplication  5   	   '    !Payroll_Appplication.RegisterPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Payroll_Appplication     5   	     � Title$  Login��5   	   #��Z��5	   	   #��Z��5
   	   
������� � WindowState$ 	Maximized=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��/9496184.png��6   $��516,68,0,-57q�6&   $��2��6<   �� 5   
   $��0��6   ���#86C2A6$	��100��63   ._�5      �� .+�5      �� $��Welcome��6   $��Center=�6+   $��Center=�6H   $��50(�6c   $
��Bold"�6q   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6+      	Direction$	 320Q�69      ShadowDepth$ 5Q�6I      Opacity$	 0.5Q�6Y   5       5!      5"      �� 5%   
   $^��XPlease Register an account, an admin will review your account and set log in permissions��6   $��Center=�6t   $��0,228,0,586q�6�   
���   �$��30(�6�   $��1��6�   ��5&      �� 5'       �� 
TargetType" ��6   	 �� Triggers	 5(      �� 5)      
 �� Binding
 6&   �� *IsRetracted+ �� Value True6F   .a�5*      ��  �� Property � y� �� Value$ 	Collapsed=�6;   5+      5-      5/      �� 52   
   $��1��6   ���#F5F6EE$��953,334,653,212q�63    �� CornerRadius$ 	0,10,10,0��6L    53        54      $
 Gray��6#   $	 320Q�60   $ 5Q�6@   $	 0.5Q�6P   ._�56      � $��20q�6    57      �� 58      $
��Auto �6$   �� 59      $
��Auto �6$   .+�5=      �� $��Username��6   $��18(�6,   $
��Bold"�6:   $��0,5,0,5q�6L   �� 5>      -   5         ��Name$ txtUsername��5>      $��0��6/   $�� ��6<   $	��Top=�6D   $��16(�6\   $��5q�6j   $��0,37,0,0q�6v   �� 5A      $��Password��6   $��18(�6,   $
��Bold"�6:   $��	0,83,0,28q�6L   G� 5B      -   5         G�Name$ txtPassword��5B      $��1��63   $	��Top=�6@   $��16(�6X   $��5q�6f   $��0,24,0,0q�6r   �� 5D      $��Confirm Password��6   $��18(�64   $
��Bold"�6B   $��0,170,0,149q�6T   $��2��6i   G� 5E      -   5        $ txtConfirmPassword��5E      $	��Top=�6:   $��16(�6R   $��5q�6`   $��	0,112,0,0q�6l   �� 5G      $��Register��6   $��Center=�6,   $��0,84,0,0q�6I   $	��150��6[   $��40��6g   $	��Top=�6s   $��1��6�   ��5H      �� 5I       �� 
TargetType" ��6*   .R�5J      �� $ 10��6%   #��z��67   #��z��6a   #��z��6�   ._�5K   "   �� $��Center=�63   $��Center=�6P   5L       �� Triggers 5M      P� 5N   "    P� Property �@J�IsMouseOver P� Value . . �5O   &   ��  � ��
 �   �6C   5P   #   5R      ��5T      �� 5U      " ��6    .�5V      ��  � �� �#4143466;   �� 5W       � ��
 �����6;   5X      5Z      5[      5\      �� 5]   
   $��1��6   ���#F5F6EE$��646,334,960,212q�63   $ 	10,0,0,10��6L    5^        5_      $
 Gray��6#   $	 230Q�60   $ 5Q�6@   $	 0.5Q�6P   ._�5a      �� $��/My first design (1).png��6   $��0,0,0,16q�66   5b      5c      5d      