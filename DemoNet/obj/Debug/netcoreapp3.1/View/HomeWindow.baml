   M S B A M L   `   `   `  ����B  >DemoNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoNet.ViewDemoNet.View  5   	   ;"clr-namespace:DemoNet.UserControlsDemoNet.UserControls  5   	       DemoNet.View.HomeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   &localclr-namespace:DemoNet.View  5   	   +uc"clr-namespace:DemoNet.UserControls  5   	   -   5          �Name$  HomeWD��5	   	   $��Regular"�5
   
   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    
  MainVM � DataContext# [  5   	    � Title$ 
HomeWindow��5   	   $	��800��6   $
��1500��6)    � WindowStartupLocation$ CenterOwner=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��130 �6   6-   �� 5      6!   .+�5   
   � -   5         �Name$ grdMenu��5      $��0��6     � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      6"   .+�5      � $��0��6   .+�5       �� -   5        	 ��Name$	 btnHome��5       
����� �

 J� Uid$
 1��6<   $��50��6D   $��0 0 0 10q�6P   .��6c   Home.  (System.Windows.Interactivity.Interaction   Triggers 5!      /  )System.Windows.Interactivity.EventTrigger  5"         	EventName$ Click��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5#      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *SwitchTabCommand+   CommandParameter 6Y   ��  �� ElementName$ HomeWD��5$        5%      $ 	MouseMove��6)   . 5&         64   �� *GetUidCommand+ 6V   �� $ btnHome��5'      5)      5*      � 5+      $��1��6   .+�5,      �� -   5        $	 btnBill��5,      
������$��50��6B   $
 2��6N   .��6V   Bill 5-        5.      $ Click��6)   . 5/         64   �� *SwitchTabCommand+ 6Y   �� $ HomeWD��50        51      $ 	MouseMove��6)   . 52         64   �� *GetUidCommand+ 6V   �� $ btnBill��53      55      56      57      � 58   
   $��1��6   .+�59      &    DemoNet.UserControls.HomeControl  -   5          Name$
 Home��59      $y�Visible=�6+   6B   &    DemoNet.UserControls.BillControl  5:      -   5          Name$
 Bill��5:      $y�Hidden=�6+   6A   5;      5<      5=      