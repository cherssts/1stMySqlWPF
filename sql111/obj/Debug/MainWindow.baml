   M S B A M L   `   `   `  ����A  =sql111, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:sql111sql111  5   	       sql111.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:sql111     5   	   -   5          �Name$  _mainWin��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 
MainWindow��5
   	   $��500         ��6   $	��835��5       � 	Resources 5         DataGridTemplate1 �� 
TargetType&   System.Windows.Controls.DataGrid��%L   &	        �� 5   
   "  64   .R�5      � 
�������6   5      5      .��5      � .+�5   
   �� $��Center=�6   $	��134��6.   $��0,-1,0,0q�6;   $	��Top=�6M   $	��836��6e   ���	#FFFFB488$��2��6�   .+�5      �� $��
MySql Test��6   $��58��6)    �� Left$ 42��65   
 �� Top$ 32��6F   $	��161��6V   $��30(�6b   $
��Bold"�6p   $��Calibri)�6�   $��Normal$�6�   5      �� 5   
   -   5         ��Name$ 
_newButton��5      $��New Profile��6%   $
��Left=�6;   $��40��6V   $��
10,138,0,0q�6b   $	��Top=�6v   $��90��6�   ���	#FFFFB488���	#FFA27357
���   �6�   �� 5   
   $��10,183,17,0q�6   
���iii�
���iii�$��2��6I   	 J� RenderTransformOrigin$	 0.5,0.5&�6]   $	��271��6}   $	��Top=�6�     5   
   -   5        
  Name$
 _dataDisplay��5      $��22,196,29,0q�6)      CanUserResizeColumns .     CanUserResizeRows .  $	��243��6v   $	��Top=�6�   
���   �
�������   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserSortColumns .  ��6�   ��  �� Path$ LoadDataBinding� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � �� �	#FFFF942763   �� 5       � ��$
 Bold"�63   �� 5       � ��$ 1,0,2,1q�68   �� 5       � ��
 �   �64   5       5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6F      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6R      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ emp_id�6]     5%      $
 Name��6D   $ * 6R    .   6%   �� $
 name�6\     5&      $ 	Birthdate��6k   $ * 6~    .   6%   �� $ 
birth_date� �� StringFormat$ {0:dd/MM/yyyy}��6�     5'      $	 Sex��6C   $ * 6P    .   6%   �� $	 sex�6Z     5(      $ Salary��6F   $ * 6V    .   6%   �� $ salary�6`     5)      $ 	Branch ID��6I   $ * 6\    .   6%   �� $ 	branch_id�6f     5*      $ Sup ID��6F   $ * 6V    .   6%   �� $ sup_id�6`   4  .System.Windows.Controls.DataGridTemplateColumn  5+      $  ��6)   $ 60 63    .     CellTemplate 5,      �� 5-      .R�5.      �� $ 
_updatebtn��6%   -   5        $��Update��5.   9   ���#b3ff87
���   �$��SemiBold"�6�   ���#68944e6�   5/      51        52      $  ��6)   $ 60 63    .   53      �� 54      .R�55      �� $ 
_deletebtn��6%   -   5        $��Delete��55   9   ���#ff6363
���   ����#b04343$��SemiBold"�6�   6�   56      58      5:      �� 5;   
   -   5         ��Name$ 
_searchBox��5;      $��32��6&   $��508,146,17,0q�62    �� TextWrapping$
 Wrap=�6H   $�� ��6\   $	��Top=�6d   $��2��6�   $��20(�6�   5=      5>      