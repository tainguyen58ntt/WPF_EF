   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.AdOrder   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  AdOrder��5   	   $	��951��6   $
��1405��6&   .��5	      � $��196,10,137,23q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��
lbOrderInf��5      $��Order Information��6'   6E   �� 5      -   5        $��lbOrId��5      $��	[OrderId]��6"   68   �� 5      -   5        $��txtOrId��5   (    �� 
IsReadOnly$
 True��6   $��25��67   ��6C   ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 6n   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��	lbOrCusId��5      $��[CustomerId]��6%   6>   �� 5      -   5        $��
txtOrCusId��5   (   $
 True��6   $��25��6:   ��6F   �� $ 
CustomerId�$ OneWay=� 6t   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbOrDate��5      $��[OrderDate]��6$   6<   �� 5      -   5        $��	txtOrDate��5      $��25��6'   ��63   �� $ 	OrderDate�$ OneWay=� 6`   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��
lbShipDate��5      $��[ShippedDate]��6&   6@   �� 5      -	   5        $��txtShipDate��5      $��25��6)   ��65   �� $ ShippedDate�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��	lbOrTotal��5      $��[Total]��6%   69   �� 5      -   5        $��
txtOrTotal��5      $��25��6(   ��64   �� $ Total�$ OneWay=� 6]   �� $ LvPro��$ SelectedItem�6�   �� 5       -   5        $��
lbOrStatus��5       $��[OrderStatus]��6&   6@   �� 5!      -   5        $��txtOrStatus��5!      $��25��6)   ��65   �� $ OrderStatus�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   5#      �� 5$   
   $ 
Horizontal=�6   $��
181,0,0,24q�6.   $
��Left=�6B   $	��769��6]   .+�5%      �� -   5         ��Name$ btnLoad��5%      $��10q�6&   $��80��62   $
��Load��6=   $��68��5&      �� 5'      -   5        $ 	btnInsert��5'      $��10q�6(   $��80��64   $��Insert��6?   $��67��5(      �� 5)      -   5        $ 	btnUpdate��5)      $��10q�6(   $��80��64   $��Update��6?   $��65��5*      �� 5+      -   5        $ 	btnDelete��5+      $��10q�6(   $��80��64   $��Delete��6?   $��65��5,      �� 5-      -   5        $ btn_View_OrderDetail��5-      $��80��63   $��View Order Detail��6>   $��64��5.   1   50      �� 51   
   -   5        $ btnStatistic��51      $��80��6'   $��Statistics ��62   $��65��52   .   $��441,213,551,79q�6:   �� 53   
   -   5        $��LvPro��53       $��1��6   $
��Auto��6-   $
��Auto��6:   $��0,74,-154,10q�6H   $��3��6^   	 �� View	 54      �� 55      .P�56      �� $��OrderId��6%   
 �� Width$	
 100��66    �� DisplayMemberBinding 57   -   �� $ OrderId��� 58      $��
CustomerId��6%   $	
 200��69    59   .   �� $ 
CustomerId��� 5:      $��	OrderDate��6%   $	
 200��68    5;   ,   �� $ 	OrderDate��� 5<      $��ShippedDate��6%   $	
 100��6:    5=   ,   �� $ ShippedDate��� 5>      $��Total��6%   $	
 100��64    5?   .   �� $ Total��� 5@      $��OrderStatus��6%   $	
 100��6:    5A   .   �� $ OrderStatus�5E      5G      �� 5H   
   -   5        $ btnClose��5H      $��3��6   $��10q�60   $��Right=�5I      $��Bottom=�6   $��80��5J      $��Close��6   6   �� 5K   
   $
��Left=�6   $��1257,213,0,0q�6/   $
��Wrap=�6E   $��	TextBlock��6Y   $	��Top=�6j   5O      5P      