   M S B A M L   `   `   `  ����M  INguyenThanhTai_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.CusView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  CusView��5   	   $	��684��6   $	��913��6&   .��5	      � $	��622��6   $	��639��6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   .+�5      �� -   5        $��lbTitle��5      $��Customer Information��6$   6E   �� 5      -   5        $��lbCusId��5      $��[CustomerID]��6#   6<   �� 5      -   5        $��txtCusId��5   (    �� 
IsReadOnly$
 True��6   $��25��68   ��6D   ��  �� Path$ 
CustomerId� �� Mode$ OneWay=� � DataContext 6r   ��  �� ElementName$ LvPro��$ SelectedItem�6�   �� 5      -   5        $��
lbCusEmail��5      $��[Email]��6&   6:   �� 5      -   5        $��txtCusEmail��5      $��25��6)   ��65   �� $ Email�$ OneWay=� 6^   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��	lbCusName��5      $��[CustomerName]��6%   6@   �� 5      -   5        $��
txtCusName��5      $��25��6(   ��64   �� $ CustomerName�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   �� 5      -   5        $��	lbCusCity��5      $��[City]��6%   68   �� 5      -	   5        $��
txtCusCity��5      $��25��6(   ��64   �� $
 City�$ OneWay=� 6\   �� $ LvPro��$ SelectedItem�6�   �� 5      -
   5        $��lbCusCountry��5      $��	[Country]��6(   6>   �� 5      -   5        $��txtCusCountry��5      $��25��6+   ��67   �� $ Country�$ OneWay=� 6b   �� $ LvPro��$ SelectedItem�6�   �� 5       -   5        $��lbCusPassword��5       $��
[Password]��6)   6@   �� 5!      -   5        $��txtCusPassword��5!      $��25��6,   ��68   �� $ Password�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   �� 5"      -   5        $��
lbCusBirth��5"      $��
[Birthday]��6&   6=   (  "System.Windows.Controls.DatePicker  5#      -   5        $��txtCusBirth��5#      $��25��6,      Text 68   �� $ Birthday�$ OneWay=� 6d   �� $ LvPro��$ SelectedItem�6�   5$      �� 5%   
   $ 
Horizontal=�6   $
��Left=�5&      $��449,148,0,72q�6   .+�5'      �� -   5        	 ��Name$	 	btnUpdate��5'      $��10q�6(   $��80��64   $��Update��6?   $��65��5(      �� 5)      -   5        $	 btn_CusViewOrder��5)      $��80��6/   $��
View Order��6:   $��65��5*   0   
 J� RenderTransformOrigin$
 2.49,0.6&�6<   5+      �� 5-   
   -   5        $	 btnClose��5-      $��3��6   $��10q�60   $��Right=�5.      $��Bottom=�6   $��80��5/      $��Close��6   6   53      54      