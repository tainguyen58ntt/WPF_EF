   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.AdFlower   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  AdFlower��5   	   $	��696��6   $	��959��6'   .��5	      � $	��622��6   $	��639��6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��lbTitle��5      $��Flower Information��6$   6C   �� 5      -   5        $��lbFlId��5      $��[FlowerBouquetId]��6"   6@   �� 5      -   5        $��txtFlId��5   (    �� 
IsReadOnly$
 True��6   $��25��67   ��6C   ��  �� Path$ FlowerBouquetId� �� Mode$ OneWay=� � DataContext 6v   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbFlCate��5      $��
[Category]��6$   6;   �� 5      -   5        $��	txtFlCate��5   (   $
 True��6   $��25��69   ��6E   �� $ 
CategoryId�$ OneWay=� 6s   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbFlName��5      $��[FlowerBouquetName]��6$   6D   �� 5      -   5        $��	txtFlName��5   (   $
 True��6   $��25��69   ��6E   �� $ FlowerBouquetName�$ OneWay=� 6z   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��lbFlDescription��5      $��[Description]��6+   6E   �� 5      -	   5        $��txtFlDes��5   (   $
 True��6   $��25��68   ��6D   �� $ Description�$ OneWay=� 6s   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��	lbFlPrice��5      $��[UnitPrice]��6%   6=   �� 5      -   5        $��
txtFlPrice��5   (   $
 True��6   $��25��6:   ��6F   �� $ 	UnitPrice�$ OneWay=� 6s   �� $ LvPro��$ SelectedItem�6�   �� 5       -   5        $��lbFlUnitStock��5       $��[UnitsInStock]��6)   6D   �� 5!      -   5        $��txtFlUnitStock��5!   (   $
 True��6   $��25��6>   ��6J   �� $ UnitsInStock�$ OneWay=� 6z   �� $ LvPro��$ SelectedItem�6�   �� 5"      -   5        $��
lbFlStatus��5"      $��[FlowerBouquetStatus]��6&   6H   �� 5#      -   5        $��txtFlStatus��5#   (   $
 True��6   $��25��6;   ��6G   �� $ FlowerBouquetStatus�$ OneWay=� 6~   �� $ LvPro��$ SelectedItem�6�   �� 5$      -   5        $��lbFlSupplierId��5$      $��[SupplierId]��6*   6C   �� 5%      -   5        $��txtFlSupplierId��5%   (   $
 True��6   $��25��6?   ��6K   �� $ 
SupplierId�$ OneWay=� 6y   �� $ LvPro��$ SelectedItem�6�   5&      �� 5'   
   $ 
Horizontal=�6   $
��Left=�5(      $��189,136,0,84q�6   .+�5)      �� -   5         ��Name$ btnLoad��5)      $��10q�6&   $��80��62   $
��Load��6=   $��68��5*      �� 5+      -   5        $ 	btnInsert��5+      $��10q�6(   $��80��64   $��Insert��6?   $��67��5,      �� 5-      -   5        $ 	btnUpdate��5-      $��10q�6(   $��80��64   $��Update��6?   $��65��5.      �� 5/      -   5        $ 	btnDelete��5/      $��10q�6(   $��80��64   $��Delete��6?   $��65��50      51      �� 52   
   -   5        $��LvPro��52       $��1��6   $
��Auto��6-   $
��Auto��6:   $��0,74,-91,10q�6H   $��3��6]   	 �� View	 53      �� 54      .P�55      �� $��FlowerBouquetId��6%   
 �� Width$	
 100��6>    �� DisplayMemberBinding 56   -   �� $ FlowerBouquetId��� 57      $��
CategoryId��6%   $	
 200��69    58   .   �� $ 
CategoryId��� 59      $��FlowerBouquetName��6%   $	
 200��6@    5:   ,   �� $ FlowerBouquetName��� 5;      $��Description��6%   $	
 100��6:    5<   ,   �� $ Description��� 5=      $��	UnitPrice��6%   $	
 100��68    5>   .   �� $ 	UnitPrice��� 5?      $��UnitsInStock��6%   $	
 100��6;    5@   .   �� $ UnitsInStock��� 5A      $��FlowerBouquetStatus��6%   $	
 100��6B    5B   .   �� $ FlowerBouquetStatus��� 5C      $��
SupplierId��6%   $	
 100��69    5D   .   �� $ 
SupplierId�5G      5I      �� 5J   
   -   5        $ btnClose��5J      $��3��6   $��10q�60   $��Right=�5K      $��Bottom=�6   $��80��5L      $��Close��6   6   �� 5M   
   -   5        $"��Search FlowerBouquet By Name��5M      $
��Left=�6T   $��380,350,0,0q�6o   $	��Top=�6�   $��23��6�   $	��185��6�   �� 5N   
   -   5         ��Name$ txtSearchByName��5N      $
��Left=�6+   $��380,393,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   5R      5S      