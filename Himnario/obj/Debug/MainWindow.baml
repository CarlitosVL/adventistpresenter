   M S B A M L   `   `   `  ����C  ?Himnario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HimnarioHimnario  5   	       Himnario.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Himnario     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6.   -   5          � Title$  Himnario Adventista��5   	   $	��450��6%   $	��800��62   
������� � WindowStartupLocation$ CenterScreen=�6U    � WindowStyle$
 None=�5	   "   .��5
      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��90 �6   �� 5      $
��0.3* �6   .+�5   
   �� $��Stretch=�6   $��Stretch=�5      $��Resource/bg.jpg��5      $
��Fill=�5      $��3��6   � 5   
   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0q�5      $��Right=�6$   $	��Top=�5      .+�5      �� -   5         ��Name$ 
btSettings��5      
������ $��0q�5   2   $��0q�5      $��30��5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Tools=�6.   $��Stretch=�5   .   $��Stretch=�5   .   
���   �5    .   5"      �� 5#      -   5        $ btClose��5$      
������ $��0q�5#   2   $��0q�5&      $��30��5'      .��5(        $ Close=�6.   $��Stretch=�5)   .   $��Stretch=�5*   .   
���   �5+   .   5,      5.      5/      #  MaterialDesignThemes.Wpf.Card  50   
   $	��320��6   $
��auto��6*   $��1��51      
���   � J� Opacity$
 0.80Q�53      .��54      �� .+�55      �� $ 
Horizontal=�6   .+�56      �� $��1q�6    �� CornerRadius$ 5��61   $��5q�6B   
�����F�$
��Auto��57   -   $	��250��58      ._�59      �� -   5        	 ��Name$	 
tbBusqueda��59   "   $��Stretch=�66   $��Stretch=�6T   $��Center=�5:      $
��Bold"�6>   $��18(�6Q   
�������
 �� TextAlignment$
 Center=�5=   "   5>      �� 5?      -   5        $ 	btnSearch��5?   )   $��40��6   
������ .��5B        $ Search=�62   
�������5C   2   5D      5E      �� 5F      -   5         ��Name$ 
spControls��5H      $��2��5F      $
��auto��6*   $
��auto��67   $��Center=�6E   $	��Top=�6b   $ 
Horizontal=�5G      $y�Hidden=�6.   .+�5I      �� -   5        $ btnPlay��5I      
������ $��0q�6]   .��5J        -   5          Name$ 	imagePlay��5L   *   
������� 5K      �� *PlayStopImage+ �� Mode$ TwoWay=�5M      5N      �� 5O      -	   5        $ btnStop��5O      
������ $��0q�6]   .��5P        $
 Stop=�62   
�������5Q   2   5R      �� 5S      -
   5         ��Name$ sVolumen��5V   '   $	��100��5S      $��Center=�6*    � Minimum$ 0Q�5U       � Maximum$ 1Q�6)   $��50,0,0,0q�5V      
������� � Value 5T      �� *	Volumen+$ TwoWay=�5W      5X      5Y      5Z      �� 5[   
   -   5         ��Name$ listSuggest��5^      
���   �$��Stretch=�5\      $��1��5]      $y�Hidden=�6   $��2��5_      $��Center=�5`      $��0,42,0,0q�5a      $	��300��5b      $	 0.5Q�5c      ._�5d      �� -   5         ��Name$ 
SerachList��5d   %   $��11(�6   $��1��5e      $��Stretch=�5f      $��0,1,0,0q�5g      
�������$
��Bold"�5k      $��16)�5l      ��5m      �� 5n       �� 
TargetType" ��6   .�5o      -   5        5p       �� View 5r      �� 5s       �� AllowsColumnReorder .  .P�5t      ��  �� Width$ 30��5v      $��Himnos��6(    �� DisplayMemberBinding 5u      ��  �� Path$ NoHimno�5v   (   �� 5w      $	 200��5y      $��Himnos��6*    5x      �� $ Titulo�5y   *   5z      5|      5}      5~      5�      