   M S B A M L   `   `   `  ����A  =4InRow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:_4InRow.View_4InRow.View  5   	       _4InRow.View.exclamation   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:_4InRow.View     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  62     � Title$  exclamation��5   	   $	��700��5	   	   $
��1300��6    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 10��6   $��1q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �    winBorderColor1 � Color# [  6    � Offset$ 0Q�6H   � 5        winBorderColor2# [ 6   $	 0.5Q�6H   � 5        winBorderColor3# [ 6   $ 1Q�6H   5      ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $	��250 �6#   �� 5       $��* �6#   .+�5$      �� $ 	10,0,0,10��6   $��0��5%      ��5&      �� 5'      $	 0,0&�6*   $ 1,0.7&�6;   .��5(      �   secondaryBackColor1# [ 6'   $ 0Q�6T   � 5)        secondaryBackColor2# [ 6'   $ 1Q�6T   5*      ._�5-      �� .+�5/      �� 
 �� Orientation$
 
Horizontal=�6!   $��35��50   !   $��
15,25,0,40q�51   !   .+�53      �� $��/View/logoF.png��6    $��35��69   �� 54      $��Four in a Row��6$     titleColor2#��[ 55   $   $��20(�56   $   $��
Montserrat)�57   $   $��Medium"�58   $   $��Center=�59   $   $��10,0,0,0q�5:   $   5;      �� 5=      $
 Vertical=�6!   .+�5>      	� -   5          
menuButton#��[ 5>   &    
 color2
 � Tag# [ 5?      ��5@      �� *ShowCustomerViewCommand+.��5A      �� $
 
Horizontal=�6)   .+�5B   "   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6/     menuButtonIcon#��[ 6;   �� 5C   "   $
��Home��6,    	 menuButtonText#��[	 68   5D      5E      	� 5G      -   5        #��[ 5G   &    

 color3# [
 5H      ��5I      �� *ShowCustomerViewCommand+.��5J      �� $
 
Horizontal=�6)   .+�5K   "     $ FantasyFlightGames=�6/   #��[ 6I   �� 5L   "   $
��Game��6,   #��[	 68   5M      5N      5O      5R      5S      �� 5V      $ 	0,10,10,0��6   $��0,-1,0,1q�6.   $��1��6@   ��5W      �� 5X      $	 1,1&�6*   $	 0,0&�6;   .��5Y      �   primaryBackColor1# [ 6'   $ 0Q�6R   � 5Z        primaryBackColor2# [ 6'   $ 1Q�6R   5[      ._�5]      � $��
90,0,-12,0q�6   .+�5^      �� $��
Objective:��6    $��35(�62   $
��Bold"�6@   
����ح�$
��Left=�6i   $	��Top=�6�   $��
288,28,0,0q�6�   �� 5_      $W��QThe goal of Four in a Row is to connect four of your game pieces (usually discs),��6    $��16(�6y   
�������$
��Left=�6�   $	��Top=�6�   $��	84,97,0,0q�6�   �� 5`      $Z��Tin a row—either horizontally, vertically, or diagonally before your opponent does.��6    $��16(�6z   
�������$
��Left=�6�   $	��Top=�6�   $��
84,123,0,0q�6�   �� 5b      $��Tips for Winning:��6    $��24(�69   $
��Bold"�6G   
����ح�$
��Left=�6p   $	��Top=�6�   $��272,167,0,0q�6�   �� 5c      $Q��K1. Control the Center: Aim to occupy the central columns early in the game,��6    $��16(�6s   
�������$
��Left=�6�   $	��Top=�6�   $��
84,228,0,0q�6�   �� 5d      $t��n2. Block Your Opponent: Anticipate your opponent’s moves and try to block their potential winning sequences.��6    $��16(�6�   
�������$
��Left=�6�   $	��Top=�6�   $��
84,254,0,0q�6�   �� 5e      $z��t3. Think Ahead: Plan your moves a few steps in advance. Consider how your current move affects future possibilities.��6    $��16(�6�   
�������$
��Left=�6�   $	��Top=�6�   $��
84,280,0,0q�6�   �� 5f      $o��i4. Fast Play: The more games you play, the more points you accumulate. Speedy play can lead to more wins.��6    $��16(�6�   
�������$
��Left=�6�   $	��Top=�6�   $��
84,306,0,0q�6�   �� 5h      $"��Advantages of Four in a Row:��6    $��24(�6D   $
��Bold"�6R   
����ح�$
��Left=�6{   $	��Top=�6�   $��199,349,0,0q�6�   �� 5i      $R��L1. Strategic Thinking: The game encourages strategic planning and foresight.��6    $��16(�6t   
�������$
��Left=�6�   $	��Top=�6�   $��
93,407,0,0q�6�   �� 5j      $S��M2. Quick Matches: Rounds are relatively short, making it an ideal quick game.��6    $��16(�6u   
�������$
��Left=�6�   $	��Top=�6�   $��
94,433,0,0q�6�   �� 5k      $e��_3. Easy to Learn: Four in a Row has simple rules, making it accessible for players of all ages.��6    $��16(�6�   
�������$
��Left=�6�   $	��Top=�6�   $��
94,459,0,0q�6�    J� RenderTransformOrigin$ 0.481,3.797&�6�   5l      5r      �� 5s      -   5         ��Name$ btnClose��5s      ���#DA34AE$��0q�5u      $��X��5v      
�������$��12(�5x      $��
Montserrat)�5y       � Cursor$
 Hand��5z      $��1��5{      $��1007,7,16,661q�5|   (   $ 5.388,-2.823&�6?   ��5~      �� 5       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value �#DA34AE67    �� Triggers 5�      P� 5�       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5�   "   ��  � �� �#C62DAE6?   5�      5�      ��5�      �� 5�       �� 
TargetType" ��6&   .R�5�      �� $��18��6!   $��18��6,   $ 9��5�      #��z��5�      ._�5�      �� $��Bottom=�6/   $��0,0,0,2q�6J   5�      5�      5�      �� 5�      -   5        $ btnMinimize_Copy��5�      ���#28AEED$��0q�5�      $��-��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��1��5�      $��948,6,0,662q�5�   +   $
��Left=�6@   $��25��6[   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#28AEED67    5�      P� 5�       �@J�IsMouseOver$
 True��6=   . �5�   "   ��  � �� �#278BEF6?   5�      5�      ��5�      �� 5�      " ��6&   .R�5�      �� $��18��6!   $��18��6,   $ 9��5�      #��z��5�      ._�5�      �� $��Center=�6/   $��Center=�5�   !   5�      5�      5�      �� 5�      -   5        $ btnMaximize��5�      ���#28AEED$��0q�5�      $	��▢��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��1��5�      $��978,6,45,662q�5�   +   ��5�      �� 5�      " ��6   .�5�      ��  � �� �#28AEED67    5�      P� 5�       �@J�IsMouseOver$
 True��6=   . �5�   "   ��  � �� �#278BEF6?   5�      5�      ��5�      �� 5�      " ��6&   .R�5�      �� $��18��6!   $��18��6,   $ 9��5�      #��z��5�      ._�5�      �� $��Center=�6/   $��Center=�5�   !   5�      5�      5�      5�      5�      5�      