   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.CusOrderDetail   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  CusOrderDetail��5   	   $	��711��6    $
��1120��6-   .��5	      � $��196,10,137,23q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��
lbOrderInf��5      $��Order Information��6'   6E   �� 5      -   5        $��	lbOrderId��5      $��	[OrderId]��6%   6;   �� 5      -   5        $��
txtOrderId��5   (    �� 
IsReadOnly$
 True��6   $��25��6:   ��6F   ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 6q   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbFlowerBouquetId��5      $��[FlowerBouquetId]��6-   6K   �� 5      -   5        $��txtFlowerBouquetId��5   (   $
 True��6   $��25��6B   ��6N   �� $ FlowerBouquetId�$ OneWay=� 6�   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbUnitPrice��5      $��[UnitPrice]��6'   6?   �� 5      -   5        $��txtUnitPrice��5   (   $
 True��6   $��25��6<   ��6H   �� $ 	UnitPrice�$ OneWay=� 6u   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��
lbQuantity��5      $��
[Quantity]��6&   6=   �� 5      -	   5        $��txtQuantity��5   )   $
 True��6   $��25��6<   ��6H   �� $ Quantity�$ OneWay=� 6t   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��
lbDiscount��5      $��
[Discount]��6&   6=   �� 5      -   5        $��txtDiscount��5   (   $
 True��6   $��25��6;   ��6G   �� $ Discount�$ OneWay=� 6s   �� $ LvPro��$ SelectedItem�6�   5!      �� 5"   
   $ 
Horizontal=�6   $
��Left=�5#      $��189,136,0,84q�6   5&      �� 5'   
   -   5        $��LvPro��5'       $��1��6   $
��Auto��6-   $
��Auto��6:   $��0,74,-154,10q�6H   $��3��6^    �� View 5(      �� 5)      .P�5*      �� $��OrderId��6%   	 �� Width$		 100��66   
 �� DisplayMemberBinding
 5+   -   �� $ OrderId��� 5,      $��FlowerBouquetId��6%   $		 200��6>   
 5-   .   �� $ FlowerBouquetId��� 5.      $��	UnitPrice��6%   $		 200��68   
 5/   ,   �� $ 	UnitPrice��� 50      $��Quantity��6%   $		 100��67   
 51   ,   �� $ Quantity��� 52      $��Discount��6%   $		 100��67   
 53   .   �� $ Discount�58      5:      �� 5;   
   -   5         ��Name$ btnClose��5;      $��3��6   $��10q�60   $��Right=�5<      $��Bottom=�6   $��80��5=      $��Close��6   6   5A      5B      