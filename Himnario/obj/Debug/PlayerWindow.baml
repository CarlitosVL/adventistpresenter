   M S B A M L   `   `   `  ����C  ?Himnario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HimnarioHimnario  5   	       Himnario.PlayerWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Himnario     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6.   -   5          � Title$  Himno��5   	   $	��450��6   $	��800��6$    � WindowStyle$
 None=�60    � WindowState$ 	Maximized=�6C   .��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   r� -   5        $��reproductor��5      $��Stretch=�6*   $��Stretch=�6H   $��3��6d    r� LoadedBehavior$ Manual=�5       r� UnloadedBehavior$ Manual=�6/    r� Stretch$
 Fill=�6I    r� Source 6X   ��  �� Path$	 Uri�	 r� Volume	 5      �� *	Volumen+�� 5   
   $��2��6   $
��auto��6"   $��30��6/   $��Center=�6;   $��Center=�6X   
 �� Orientation$
 
Horizontal=�5      .+�5      �� -   5         ��Name$ btnPlay��5      
������ $��0q�6U   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ 	imagePlay��5   V      Kind 6*   �� *PlayStopImage+ �� Mode$ TwoWay=�6V   5      �� 5      -   5        $ btnStop��5      
������ $��0q�6U   .��5        $
 Stop=�6*   5      �� 5      $	��100��6   $��Center=�6"    � Minimum$ 0Q�6d    � Maximum$ 1Q�6p   $��50,0,0,0q�5       � Value 5   =   �� *	Volumen+$ TwoWay=�5      5      � 5   
    � ColumnDefinitions 5      �� 5       $��* �6#   �� 5!      $	��100 �6#   .+�5#      �� -   5         ��Name$
 spUp��5$      $��1��5#      $
 
Horizontal=�6)   $��Stretch=�6B   .+�5&      �� -   5        $ btnMax��5'      
������ $��Stretch=�5&   2   $��Stretch=�6P   $��0q�6l   .��5(        -   5        $ 
imgRestore��5)   .   $ WindowRestore=�5(   .   $��Stretch=�6C   $��Stretch=�6a   5)   .   5*      �� 5+      -	   5        $ btnClose��5,      
������ $��Stretch=�5+   2   $��Stretch=�6P   $��0q�6l   .��5-        $ WindowClose=�6.   $��Stretch=�6A   $��Stretch=�6_   5.      5/      50      51      52      