   M S B A M L   `   `   `  ����D  @NowDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NowDesign	NowDesign  5   	   C&clr-namespace:NowDesign.MVVM.ViewModelNowDesign.MVVM.ViewModel  5   	       NowDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NowDesign     5   	   <	viewModel&clr-namespace:NowDesign.MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��920��6)    � WindowStyle$ 
ToolWindow=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � DataContext 5      ,  &NowDesign.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 30��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      6%    � RowDefinitions 5      �� 5      $��75 �6    6.   �� 5      6"   .+�5      �� $��JeraJin��6   $��Center=�5       $
��Left=�5!      
�������$��22(�5#      $��20,0,0,0q�5$      5%      �� 5'      $��1��6   .+�5(      	� $
��Home��6   $��50��5)      
�������$��14(�5+         MenuButtonTheme#��[  5,      6I   	� 5-      $��Board��6   $��50��5.      
�������$��14(�50      #��[  51      6I   	� 52      $��Member��6   $��50��53      
�������$��14(�55      #��[  56      6I   57      �� 59      $	��250��6   $��40��5:      $��Center=�5;      $
��Left=�5<      $��5q�5=      $��1��5>        ModernTextBox#��[ 5?      5@      �� 5B      $��1��6   $��1��5C      $��10q�5D      ��5E      �� *CurrentView+6?   5F      5I      5J      