   M S B A M L   `   `   `  ����B  >DemoNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoNet.ViewDemoNet.View  5   	       DemoNet.View.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   &localclr-namespace:DemoNet.View  5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  LoginWD��5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     LoginVM � DataContext# [ 5   	    � Title$ LoginWindow��5   	   $	��620��5   	   $
��1000��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��400 �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5       �� 5!      $	��140 �6    .+�5#      � $��0��6   
������� 5%      �� 5&      $	��200 �6$   �� 5'      �� 5(      �� 5)      $	��100 �6$   .+�5+      �� $��0��6    �� Orientation$ 
Horizontal=�5,      .+�5-      �� $	��118��6   $��72��5.      $��70 0 0 0q�5/      $?��9/View/240819846_451998545864852_2627778154468788654_n.png��6.   �� 50      $ Vertical=�6!   $��Center=�51   !   $��	-10 0 0 0q�52   !   .+�53      �� $��30(�54      $��Cooper Black)�55      ���#100E17$��
UltraBlack"�57      $��0 0 0 0q�58      .��6.   
Flánner5:      �� 5;      $��0 0 0 10q�5<      $��Center=�5=      $��12(�5>      $��Cooper Black)�5?      ���#100E17$��Light"�5A      .��60   Demo5D      5F      5G      �� 5H      $��1��6   $ 
Horizontal=�6*   .+�5I      �� $��Segoe UI)�6   $��50��5J      $
��Bold"�5K      $��40,30,10,10q�5L      .��6.   Tên đăng nhâp6=   �� 5M      $	��180��6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Username��5O      $��10,15,10,20q�5P      ��5N      �� *
Username+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5R      5S      �� 5T      $��2��6   $ 
Horizontal=�6*   .+�5U      �� $��Segoe UI)�6   $��50��5V      $
��Bold"�5W      $��40,30,40,10q�5X      .��6-   Mật khẩu67   G� 5Y      -   5         G�Name$ PasswordBox��5\      $	��180��5Z      $��10,15,10,20q�5[      $	 Password��5]      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5^         
HelperText$ At least 12 characters��5_      .  (System.Windows.Interactivity.Interaction   Triggers 5`      /  )System.Windows.Interactivity.EventTrigger  5a         	EventName$ PasswordChanged��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5b   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *PasswordChangedCommand+   CommandParameter 5c   @   ��  �� ElementName$ PasswordBox��5d      5f      5g      �� 5h      $��3��6   $��40��5i      $	��150��5j      $��12(�5k      ���#100E17$��Segoe UI)�5m      
�������$��Right=�5o      $	��Top=�5p      $��	0,20,30,0q�5q       # MaterialDesignRaisedLightButton#��[ 5r       � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��6N   ��5s      �� *LoginCommand+��66   �� $ LoginWD��.��6g   Đăng nhập6r   � 5t      $��0��6   5v      5w      � 5x      $��1��6   ���#100E17.+�5{      �� $��Segeo UI)�5|      
�������$��15(�5~      $
��Bold"�5      $��Center=�5�      $��Center=�5�      .��69    Bạn chưa có tài khoản ?6R   5�      5�      � 5�   
   $��1��6   ���#100E17$��Bottom=�5�      $	��150��5�       � Triggers 5�      :� 5�       :� RoutedEvent$ 
MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W�  W� From 1505�   !   	 W� To 5505�   !    g� Duration$ 0:0:01D�5�   !    �� TargetProperty$ Height�5�   !   5�      �� 5�      	 �� To Teal5�   !   $ 0:0:01D�5�   !   $1 +(Button.Background).(SolidColorBrush.Color)�5�   !    �� 
TargetName$ 
signuplogo��5�   !   5�      �� 5�       Teal5�   !   $ 0:0:01D�5�   !   $/ )(Grid.Background).(SolidColorBrush.Color)�5�   !   $ grid2��5�   !   5�      5�      5�      5�      :� 5�      $ 
MouseLeave��6   .[�5�      �� .��5�      �� .��5�      W�  5505�   !    1505�   !   $ 0:0:01D�5�   !   $ Height�5�   !   5�      �� 5�       #100E175�   !   $ 0:0:01D�5�   !   $/ )(Grid.Background).(SolidColorBrush.Color)�5�   !   $ grid2��5�   !   5�      �� 5�       #100E175�   !   $ 0:0:01D�5�   !   $1 +(Button.Background).(SolidColorBrush.Color)�5�   !   $ 
signuplogo��5�   !   5�      5�      5�      5�       5�      �� 5�      $��75 �6    �� 5�      $	��500 �6    .+�5�      � $��0��6   
�������.+�5�      �� -   5         ��Name$ 
signuplogo��5�      $��0 30 0 0q�5�      ���#100E17 + 'MaterialDesignFloatingActionLightButton#��[ 5�      $- 'MaterialDesignFloatingActionLightButton��5�      .��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�5�      
�������$��30��5�      $��30��5�      5�      5�      � 5�      -   5        $��grid2��5�      $��1��5�      ���#100E17 5�      �� 5�      $��70 �6$   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5          ��Name$  signuptxtblock��5�      $��Segoe UI)�5�      $��	ExtraBold"�5�      $��Center=�5�      $��Center=�5�      
���������5�      �� 5�      ! �� 
TargetType"! ��6    .�5�      �� " �� Property" � ��# �� Value$$# Bạn chưa có tài khoản ?��65   �� 5�      " � ��$# 15(�69   $ �� Triggers$ 5�      �� 5�   "   % �� Binding% 6.   �� $ grid2��& �� Path$& IsMouseOver�' �� Value' True6f   .a�5�   &   �� " � ��$# 
Đăng kí��6=   �� 5�   &   " � ��$# 20(�6A   5�   #   5�      5�      �� 5�      $��1��6   $ 
Horizontal=�6*   .+�5�      �� $��Segoe UI)�6   $��50��5�      $
��Bold"�5      $��40,30,20,10q�5     .��6.   Tên đăng nhâp6=   �� 5     $	��180��6   $	 Username��5     $��10,15,10,20q�5     5     5	     �� 5
     $��4��6   $ 
Horizontal=�6*   .+�5     �� $��Segoe UI)�6   $��50��5     $
��Bold"�5     $��40,30,70,10q�5     .��6.   Gmail65   �� 5     $	��180��6   $	 Gmail��5     $��10,15,10,20q�5     5     5     �� 5     $��2��6   $ 
Horizontal=�6*   .+�5     �� $��Segoe UI)�6   $��50��5     $
��Bold"�5     $��40,30,50,10q�5     .��6-   Mật khẩu67   G� 5     -   5        $ PasswordBox1��5      $	��180��5     $��10,15,10,20q�5     $	 Password��5!     $
 True��5"     $ At least 12 characters��5#     5$     �� 5%     $��3��6   $ 
Horizontal=�6*   .+�5&     �� $��Segoe UI)�6   $��50��5'     $
��Bold"�5(     $��
40,30,0,10q�5)     .��6,   Nhập lại Mật khẩu6?   G� 5*     -   5        $ PasswordBox2��5-     $	��180��5+     $��10,15,10,20q�5,     $	 Password��5.     $
 True��5/     $ At least 12 characters��50     51     �� 53     $��5��6   .+�54     �� $��40��55     $	��150��56     $��12(�57     ���#100E17$��Segoe UI)�59     
�������$��Center=�5;     $��Center=�5<     $��0,0,0,0q�5=     #��[ 5>     $4 .Resource name: MaterialDesignRaisedLightButton��5?     .��6N   
Đăng kí6W   5@     5B     5F     � 5G  
   $��0��6   ��5H     �� 5I     ( �� 
StartPoint$( 0.1,0&�6&   ) �� EndPoint$) 0.9,1&�69   .��5J     � * � Color$
* Teal��6#   + � Offset$+ 1Q�60   � 5K     $* Orange��6#   $+ 0Q�62   5L     .+�5N     �� $	��490��6   $	��Top=�5O     , �� CornerRadius$, 
0 0 70 200��5P     ���#100E175Q  ,   �� 5R     $ Vertical=�6   .+�5S     �� 
�������$��30(�5T     $��SemiBold"�5U     $��Segoe UI)�5V     $��Center=�5W     $��0 40 0 0q�5X     .��6*   *(Chào mừng bạn đến với Flanner!6J   �� 5Y     
�������$��18(�5Z     $��SemiBold"�5[     $��Segoe UI)�5\     $��Center=�5]     $��0 0 0 20q�5^     .��6*   '%Ứng dụng tính toán tại quầy6G   �� 5_     $��/View/background.png��6   $	��326��5`     $	��426��5a     $��Bottom=�5b     5e     5f     5h     5i     