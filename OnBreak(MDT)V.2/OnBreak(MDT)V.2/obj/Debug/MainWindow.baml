   M S B A M L   `   `   `  ����J  FOnBreak(MDT)V.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnBreak_MDT_V._2OnBreak_MDT_V._2  5   	   !    OnBreak_MDT_V._2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OnBreak_MDT_V._2     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  On Break System��5	   	   $	��600��6!   $
��1080��6.    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`   $��Yu Gothic UI Semibold)�6v    � Icon$ images/Captura1.JPG��6�   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   ���	#FF1F8DE5.��5      � .+�5      �� $�� ��6   $��Center=�6$   $��Center=�6A   $��22(�6\   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�68   $��Right=�6Q   .+�5      �� $��On Break��6    $��Center=�60   $��18(�6K   '  !MaterialDesignThemes.Wpf.PopupBox  5      $��10q�6/      PlacementMode$ BottomAndAlignRightEdges=�6;   	   	StaysOpen	 .  
   PopupContent.
 5      �� $	��150��6%   .+�5      �� $��Configuracion��6%   �� 5      $��Ayuda��6%   �� 5      �� 5      -   5         ��Name$ ButtonPopUpSalir��5   %   $��Cerrar Sesion��6?   6W   5       5"      5$      5&      5'      � 5)   
   $��Stretch=�6   $��1��6-   ���	#FF1F8DE5 5*      �� 5+      $��70 �6    �� 5,      $	��326 �6    .+�5.      � $��0��6   
�������.+�5/      �� $��Images/Captura3.jpg ��6   50      �� 51      $��Stretch=�6   $��Disabled=�6@   $
��Auto=�6i   $��1��6�   $��
0,0,0,-125q�6�   .��52      �� -   5         ��Name$
 Menu��52      $��10q�6+   54      56      �� 57   
   -   5        $ StackPanelMain��57      $��1��6-   $��1��6:   .+�58      �� $,��&/Images/dark_logo_white_background.jpg��6   $	��522��6D   59      5;      5<      