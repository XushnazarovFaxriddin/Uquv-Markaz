   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      F BUquv_Markaz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Uquv_Markaz.Pages.DashboardUquv_Markaz.Pages.Dashboard 5      '   !Uquv_Markaz.Pages.Dashboard.Index   5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Uquv_Markaz.Pages.Dashboard     5        N� Title$  Index��5       N� 
Background
 �����.��5      �  � 	Resources 5   
      CleanSeparator �� 
TargetType   LiveCharts.Wpf.Separator �� Property �� Value��%P   &	        �� 5      "  6+   .�5      ��  � {� .  6>   5      5      .+�5   
   #   LiveCharts.Wpf.CartesianChart  &    LiveCharts.Wpf.Charts.Base.Chart   AxisY 5         LiveCharts.Wpf.Axis     
Foreground
 ����   Title$ Baholar kesimida��63     5      
 �\\��$ Foizlar kesimida��62   	   Position$	 RightTop=�6K   
   	Separator
 5        5      #��[  6(   6R   5        5      
 �/kU�$ Ballar kesimida��67   $	 RightTop=�6O   
 5         5!      #��[  6(   6R   5#         Series 5&         LiveCharts.Wpf.LineSeries     LiveCharts.Wpf.Series   Values;   5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 	1,5,3,5,3 6!      	ScalesYAt$ 0��64      Title$ 	1-7MAT-19��6B     5(      $ 20,30,70,20,10 6!   $ 1��6:   $ 1-3PM-19��6H     5*      $ 600,300,200,600,800 6!   $ 2��6?   $ 	1-2ATT-20��6M     5-      $ 1,3.5,2,3.5,5.5 6!   $ 0��6:   $ 
1-2KIDT-20��6H   5/      �� 50   
      MaterialDesignBody1TextBlock#��[ 51      $
��Left=�52      $��	40,11,0,0q�53      $	��Top=�6    $��Guruhlar��54      �� 55   
   #��[ 56      $
��Left=�57      $��
410,11,0,0q�58      $	��Top=�6!   $��Guruhlar statistikasi��59      5Q      5R      