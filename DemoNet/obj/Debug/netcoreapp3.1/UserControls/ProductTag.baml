   M S B A M L   `   `   `  ����B  >DemoNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DemoNet.UserControlsDemoNet.UserControls  5      %    DemoNet.UserControls.ProductTag   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DemoNet.UserControls     5      -   5          >�Name$  userControl��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��400��6,   $	��250��6;   �� 5      $	��100 �6   �� 5      $	��150 �6   �� 5      $	��100 �6   .+�5   
   � 
���   �.+�5      �� $��Center=�6s   $��10q�6�   
���������6   �� *HeaderContent+ �� ElementName$ userControl�� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5   
   $��2��6m   $��Center=�6}   $��10 0 0 0q�6�    �� Padding$	 5,1q�6�   ��6   �� *TextBoxText+$ userControl��$ PropertyChanged=�6�   �� 5   
   $��1��6m   $	��100��6}   ��6   �� *ImageSource+$ userControl��$ PropertyChanged=�6�   �� 5   
   
����� �
�������$��20 0 0 0q�66   $��3��6H   $��Thêm��6X   y�6g   �� *ButtonVisible+$ userControl��$ PropertyChanged=���6�   �� *TestCommand+$ userControl��$ PropertyChanged=���6&  �� *ButtonCommandParameter+$ userControl��$ PropertyChanged=�5      5      