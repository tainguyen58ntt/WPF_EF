   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF.Ad_OrderDetailWPF.Ad_OrderDetail  5   	   )    #WPF.Ad_OrderDetail.AdUpdateOrdetail   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF.Ad_OrderDetail     5   	     � Title$  AdUpdateOrdetail��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��
lbOrderInf��5      $��OrderDetail Information��6'   6K   �� 5      -   5        $��	lbOrderId��5      $��	[OrderId]��6%   6;   �� 5      -   5        $��
txtOrderId��5   (    �� 
IsReadOnly$
 True��6   $��25��6:   ��6F   ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 6q   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbFlowerBouquetId��5      $��[FlowerBouquetId]��6-   6K   �� 5      -   5        $��txtFloId��5   )   $
 True��6   $��25��69   ��6E   �� $ FlowerBouquetId�$ OneWay=� 6x   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbUnitPrice��5      $��[UnitPrice]��6'   6?   �� 5      -   5        $��txtUnitPrice��5      $��25��6+   ��67   �� $ 	UnitPrice�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��
lbQuantity��5      $��
[Quantity]��6&   6=   �� 5      -	   5        $��txtQuantity��5      $��25��6*   ��66   �� $ Quantity�$ OneWay=� 6b   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��
lbDiscount��5      $��
[Discount]��6&   6=   �� 5      -   5        $��txtDiscount��5      $��25��6)   ��65   �� $ Discount�$ OneWay=� 6a   �� $ LvPro��$ SelectedItem�6�   5       �� 5!   
   $ 
Horizontal=�6   $
��Left=�5"      $��189,136,0,84q�6   .+�5#      �� -   5         ��Name$ 	btnUpdate��5#      $��10q�6(   $��80��64   $��Update��6?   $��67��5$      5%      5'      5(      