   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.Ad_OrderWPF.Ad_Order  5   	        WPF.Ad_Order.ADInsertOrder   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Ad_Order     5   	     � Title$  ADInsertOrder��5   	   $	��660��6   $
��1060��6,   .��5	      � $��196,10,137,23q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��
lbOrderInf��5      $��Order Information��6'   6E   �� 5      -   5        $��lbOrId��5      $��	[OrderId]��6"   68   �� 5      -   5        $��txtOrId��5      $��25��6%   ��61   ��  �� Path$ OrderId� �� Mode$ OneWay=� � DataContext 6\   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��	lbOrCusId��5      $��[CustomerId]��6%   6>   �� 5      -   5         ��Name$ 
cbCustomer��5      ��5      �� 5      .R�5      �� ��6$   �� *CustomerName+5      5      �� 5       -   5        $��lbOrDate��5       $��[OrderDate]��6$   6<   (  "System.Windows.Controls.DatePicker  5"      -   5        $��dbOrDate��5"      $��25��6+      Text 67   �� $ 	OrderDate�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�5#      �� 5$      -   5        $��
lbShipDate��5$      $��[ShippedDate]��6&   6@     5&      -	   5        $��dbOrShipdate��5&      $��25��6/    6;   �� $ ShippedDate�$ OneWay=� 6j   �� $ LvPro��$ SelectedItem�5'      5-      �� 5.   
   $ 
Horizontal=�6   $��
181,0,0,24q�6.   $
��Left=�6B   $	��769��6]   .+�5/      �� -
   5        	 ��Name$	 	btnInsert��5/      $��80��6(   $��Insert��63   $��67��50      
 J� RenderTransformOrigin$
 0.5,0.5&�6&   z�51      V� 52      .~�53      �� �� 54      �� 55       �� Angle$ 0.081Q�6*   T� 56      57      59      5;      �� 5R   
   -   5        $	 btnClose��5R      $��3��6   $��0,107,10,11q�60   $��Right=�5S      $��80��5T      $��Close��6   6   5X      5Y      