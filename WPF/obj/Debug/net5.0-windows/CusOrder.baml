   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.CusOrder   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  CusOrder��5   	   $	��682��6   $
��1064��6'   .��5	      � $��196,10,137,23q�6    � RowDefinitions 5
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
CustomerId�$ OneWay=� 6t   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbOrDate��5      $��[OrderDate]��6$   6<   �� 5      -   5        $��	txtOrDate��5   (   $
 True��6   $��25��69   ��6E   �� $ 	OrderDate�$ OneWay=� 6r   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��
lbShipDate��5      $��[ShippedDate]��6&   6@   �� 5      -	   5        $��txtShipDate��5   (   $
 True��6   $��25��6;   ��6G   �� $ ShippedDate�$ OneWay=� 6v   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��	lbOrTotal��5      $��[Total]��6%   69   �� 5      -   5        $��
txtOrTotal��5   (   $
 True��6   $��25��6:   ��6F   �� $ Total�$ OneWay=� 6o   �� $ LvPro��$ SelectedItem�6�   �� 5       -   5        $��
lbOrStatus��5       $��[OrderStatus]��6&   6@   �� 5!      -   5        $��txtOrStatus��5!   )   $
 True��6   $��25��6<   ��6H   �� $ OrderStatus�$ OneWay=� 6w   �� $ LvPro��$ SelectedItem�6�   5#      �� 5$   
   $ 
Horizontal=�6   $
��Left=�5%      $��189,136,0,84q�6   .+�5'      �� -   5         ��Name$ btn_View_OrderDetail��5'      $	��108��63   $��View Order Detail��6?   $��41��5(   4   5)      �� 5*   
   -   5        $��LvPro��5*       $��1��6   $
��Auto��6-   $
��Auto��6:   $��0,74,-154,10q�6H   $��3��6^   	 �� View	 5+      �� 5,      .P�5-      �� $��OrderId��6%   
 �� Width$	
 100��66    �� DisplayMemberBinding 5.   -   �� $ OrderId��� 5/      $��
CustomerId��6%   $	
 200��69    50   .   �� $ 
CustomerId��� 51      $��	OrderDate��6%   $	
 200��68    52   ,   �� $ 	OrderDate��� 53      $��ShippedDate��6%   $	
 100��6:    54   ,   �� $ ShippedDate��� 55      $��Total��6%   $	
 100��64    56   .   �� $ Total��� 57      $��OrderStatus��6%   $	
 100��6:    58   .   �� $ OrderStatus�5<      5>      �� 5?   
   -   5        $ btnClose��5?      $��3��6   $��10q�60   $��Right=�5@      $��Bottom=�6   $��80��5A      $��Close��6   6   5G      5H      