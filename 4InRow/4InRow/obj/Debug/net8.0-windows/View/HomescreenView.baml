   M S B A M L   `   `   `  ����A  =4InRow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:_4InRow.View_4InRow.View  5   	   !    _4InRow.View.HomescreenView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:_4InRow.View     5   	   -   5          � Title$  HomescreenView��5   	   $	��550��6!   $	��800��6.    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 50��6   ��5   
   �� 5       �� ImageSource$ /View/img2.jpg��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.90Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5      �    winBorderColor1
 � Color#
 [  6#    � Offset$ 0Q�6L   � 5         winBorderColor2#
 [ 6#   $	 0.5Q�6L   � 5!        winBorderColor3#
 [ 6#   $ 1Q�6L   5"      ��5%      �� 5&      $	 0,1&�6&   $		 1,0&�67   .��5'      �   secondaryBackColor1#
 [ 6#   $ 0Q�6P   � 5(        secondaryBackColor2#
 [ 6#   $ 1Q�6P   5*      ._�51      �  � RowDefinitions 52      �� 53      $��30 �6$   �� 54      .+�57      �  � ColumnDefinitions 58      �� 59      �� 5:      $��25 �6+   �� 5;      $��25 �6+   �� 5<      $��25 �6+   �� 5=      $��5 �6+   .+�5A      �� $��Four in a Row - HOME��6    
�������$��10(�5C       $��
Montserrat)�5D       $��0��5E       $��Center=�5F       $��10,0,0,0q�5G       �� 5K      -   5         ��Name$ btnMinimize��5K      ���#28AEED$��0q�5M      $��-��5N      
�������$��12(�5P      $��
Montserrat)�5Q       � Cursor$
 Hand��5R      $��2��5S      ��5U      �� 5V       �� 
TargetType" ��6$   .�5W   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5X   "   P� 5Y   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5Z   *   ��  � �� �#278BEF6G   5[   '   5]      ��5_      �� 5`       �� 
TargetType" ��6.   .R�5a   "   �� $��18��6)   $��18��64   $ 9��5b   )   #��z��5c   )   ._�5d   &   �� $��Center=�67   $��Center=�5e   7   5f   #   5g      5i      �� 5l      -   5        $ btnClose��5l      ���#DA34AE$��0q�5n      $��X��5o      
�������$��12(�5q      $��
Montserrat)�5r      $
 Hand��5s      $��3��5t      ��5w      �� 5x      " ��6$   .�5y   "   ��  � �� �#DA34AE6?    5z   "   P� 5{   &    �@J�IsMouseOver$
 True��6E   . �5|   *   ��  � �� �#C62DAE6G   5}   '   5      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��6)   $��18��64   $ 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Bottom=�67   $��0,0,0,2q�6R   5�   #   5�      5�      5�      �� 5�      $��1��5�       �� Orientation$ Vertical=�5�      $��
97,35,70,0q�5�      .+�5�      �� $��/View/logoF.png��6   $	��200��65   $	��150��6A   �� 5�      $��FOUR IN A ROW��6    
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $��
Good luck!��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       � 5�      $	��515��6   .+�5�      �� $��Four Game Instructions:��6$   $��20(�6C   $
��Bold"�6Q   $��Center=�6c   $	��Top=�6�   $��10q�6�   �� 5�      $A��;1. Players take turns dropping colored discs into the grid.��6$   $
��Left=�6g   $	��Top=�6�   $��	33,46,0,0q�6�   �� 5�      $a��[2. The goal is to connect four discs of your color vertically, horizontally, or diagonally.��6$   $��Center=�6�   $	��Top=�6�   $��0,65,0,0q�6�   �� 5�      $^��X3. Plan your moves strategically to block your opponent and create winning combinations!��6$   $
��Left=�6�   $	��Top=�6�   $��	33,89,0,0q�6�   �� 5�      $8��24. The first player to achieve four in a row wins!��6$   $
��Left=�6^   $	��Top=�6y   $��
33,110,0,0q�6�   5�      �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��Start��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462AD86?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      5�      5�      5�      5�      