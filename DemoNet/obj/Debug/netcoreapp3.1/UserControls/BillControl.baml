   M S B A M L   `   `   `  ����B  >DemoNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DemoNet.UserControlsDemoNet.UserControls  5      ;"clr-namespace:DemoNet.UserControlsDemoNet.UserControls  5      &     DemoNet.UserControls.BillControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DemoNet.UserControls     5      :userControl"clr-namespace:DemoNet.UserControls     5      -   5          >�Name$  BillCT��5
       
  BillVM � DataContext# [  5      
�������.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��Danh sách đơn hàng��6   $��Center=�6-   $��Center=�6J   $
��Bold"�6e   $��25(�6w   6�   �� 5   
   $��1��6   $��Right=�6   $��10q�6:   $��Cập nhập dữ liệu��6F   
����� ���6s   �� *LoadCommand+6�   �� 5   
   -   5         ��Name$ lvsOrder��5   !   $��2��6   ��63   �� *	ListOrder+��5      �� 5      .R�5      �� $��10q�6!   
�����w�.+�5      �� $��10q�6$   $��15(�6k   $
��Bold"�6y   ��60   �� *Name+ �� StringFormat$ Tên khách hàng: {0}��6�   �� 5      $��10q�6$   $��15(�6q   $
��Bold"�6   ��60   �� *PhoneNumber+$ Số điện thoại: {0}��6�   �� 5      ��6%   �� *ListProduct+��5      �� 5   "   .R�5   &   %   DemoNet.UserControls.ProductTag     ButtonContent$ Thêm��5#         ButtonVisible$ Hidden��5$         HeaderContent 5       �� *Name+   TextBoxText 5!      �� *Amount+$
 x{0}��	   ImageSource	 5"      �� *	ImgSource+5$   6   5%   #   5'      �� 5(      $��10q�6$   $��18(�6h   $
��Bold"�6v   ��60   �� *Total+$ Thanh toán: {0}��6�   5+      5.      50      52      53      