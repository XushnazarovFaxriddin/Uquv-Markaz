   M S B A M L   `   `   `  ����F  BUquv_Markaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Uquv_MarkazUquv_Markaz  5   	       Uquv_Markaz.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Uquv_Markaz     5   	   -   5        $
��home��5        � Title$  
MainWindow��5   	   $	��650��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      ��  �� CornerRadius$ 8��6      PrimaryBackgroundColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  6,   ._�5      � -   5         �Name$ gridMenu��5      $��60��6)   	 � RowDefinitions	 5      �� 5      $��30 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5      �� $��1��6!   
 �� Orientation$
 
Horizontal=�6.   $	��Top=�6G   .+�5      F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   5      �� 5"      $��1��6!   $��0,79.6,3,-0.4q�6.   $��3��6E   .+�5#      	� -   5         	�Name$ rdHome��5#   &    d� 	IsChecked$
 TrueY�66     MenuRadioButtonStyle#���  6G     home
 � Tag# �  6v   6�   	� 5$      -   5        $ rdGroups��5$   &   $��Groups��68   #���  6I    
 groups# �  6x   $��0 5 0 5q�6�   6�   	� 5%      -   5        $ rdUser��5%   &   $��Abituriyent��66   #���  6L     user# �  6{   $��0 5 0 5q�6�   6�   	� 5'      -   5        $ rdTest��5'   &   $
��Test��66   #���  6E     test# �  6t   6�   	� 5(      -   5        $ 	rdTeacher��5(   &   $��Teacher��69   #���  6K    	 teacher# � 	 6z   6�   	� 5)      -   5        $ 	rdGetTest��5)   &   $��Get Test��69   #���  6L    
 get_test# � 
 6{   $��0 5 0 5q�6�   6�   5*      5,      5-      � 51      $��1��6   	 52      �� 53      $��40 �6$   �� 54      .+�58      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $
 
Horizontal=�6�   $��RightToLeft=�6�   .+�59      �� -	   5         ��Name$ btnClose��59        IconButtonsStyle#��[ 6/    	 close#���  6Y   $ IsCloseButton��6�   �� 5:      -
   5        $ 
btnRestore��5:      $	��5,0q�61   ��5;      �� 5<       �� 
TargetType" ��6$    �� BasedOn# [ 6A   .�5=   "   ��  �� Property � ��  maximize �� Value# �  6<    �� Triggers 5>   "   �� 5?   &    �� Binding 62   ��  �� ElementName$
 home�� �� Path$ WindowState� �� Value 	Maximized6i   .a�5@   *   ��  � ��  restore# �  6D   5A   '   5C      5E      �� 5F      -   5        $ btnMinimize��5F      #���  62     minimize#���  6]   6�   5G      �� 5J      $��1��6   $��5q�6&   ._�5K       � -   5          �Name$ PagesNavigation��5K        � NavigationUIVisibility$ Hidden=�65   $��	0,0,0.4,0q�6U   5M      5N      5O      5Q      5R      5S      