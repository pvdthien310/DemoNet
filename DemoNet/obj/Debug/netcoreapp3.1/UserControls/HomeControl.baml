   M S B A M L   `   `   `  ����B  >DemoNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DemoNet.UserControlsDemoNet.UserControls  5      &     DemoNet.UserControls.HomeControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DemoNet.UserControls     5      -   5          >�Name$  
mainwindow��5	       
  HomeVM � DataContext# [  5      
�������.��5      �  � ColumnDefinitions 5   
   �� 5      $	��650 �6   6-   �� 5      $��50 �6   6,   �� 5      $	��650 �6   6-   .+�5   
   �� $��0��6   $
��True��6'   .��5      �� .+�5      �� $��Danh sách sản phẩm��6   $��20(�65   $
��Bold"�6C   $��Center=�6U   6t   �� 5      -   5         ��Name$ 
lvsProduct��5      ��6/   �� *ListProduct+ �� SelectedItem 6S   �� *
Selected+��5      �� 5      .R�5      �� .+�5   "   %   DemoNet.UserControls.ProductTag     ButtonContent$ Thêm��5          ButtonVisible$ Visible��5!         TestCommand 5      ��  �� Path$ DataContext.Btncommand2�	 �� RelativeSource	 �� 
 �� AncestorType
 ListView   ButtonCommandParameter 5      ��    HeaderContent 5      �� *Name+   TextBoxText 5      �� *Price+ �� StringFormat$ {0} VND��   ImageSource 5      �� *	ImgSource+5!   7   5"      5#      5%      5&      5'      �� 5)   
   $��2��6   .��5*      �  � RowDefinitions 5+      �� 5,      $
��Auto �6$   64   �� 5-      $
��Auto �6$   64   �� 5.      $
��Auto �6$   64   �� 5/      $
��Auto �6$   64   �� 50      $
��Auto �6$   64   .+�52      �� $��0��6   $��Đơn hàng��6%   $��20(�68   $
��Bold"�6F   $��Center=�6Y   6x   #   DemoNet.UserControls.UserInfo  53      $	��500��6!   $��1��6-      TextBoxText1 6:   �� *
OrderOwner+ �� Mode$ TwoWay=�   TextBoxText2 6k   �� *PhoneNumber+$ TwoWay=�6�   � 54      $��2��6   .+�55      �� ��6   �� *Order+��56      �� 57      .R�58   "   (   "DemoNet.UserControls.ProductInBill     TestCommand 59   %   �� $ DataContext.DeleteCommand�	 �� 
 ListView   ButtonCommandParameter 5:   %   ��    AmountPr 5;   %   �� *Amount+$  x {0} ��   PricePr 5<   %   �� *Price+$( " Đơn giá sản phẩm : {0} VND��   NamePr 5=   %   �� *Name+   ImageSource 5>   %   �� *	ImgSource+   TotalPr 6G   �� *Total+$  Tổng: {0} VND��6�   5?      5A      5B      �� 5C      $��3��6    �� Orientation$ 
Horizontal=�6+   .+�5D      �� $��Tổng đơn hàng: ��6   $��20(�66   
�������
����� �6k   �� 5E      $��20(�6g   
�������
����� ���6   �� *
TotalOrder+$  Tổng thanh toán:{0} VND��6�   5G      �� 5H      $��3��6   $��30��6&   $��Right=�63   $��10 10 10 10q�6O   $��Thanh toán��6�   ��6d   �� *
Btncommand+6�   5K      5L      5M      5N      