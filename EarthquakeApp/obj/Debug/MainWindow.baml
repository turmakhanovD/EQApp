   M S B A M L   `   `   `  ����H  DEarthquakeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EarthquakeAppEarthquakeApp  5   	       EarthquakeApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EarthquakeApp     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��323* �6   �� 5      $	��96* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      5        5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   Z�    ClipboardContentBinding 68   Z�   5       6%   Z�  68   Z�   5       6%   Z�  68   Z� 5!      �� 5"   
   -   5        $	��Get��5"      $
��Left=�6   $��
180,28,0,0q�6:   $��1��6N   $	��Top=�6[   $��76��6s   6~   �� 5#   
   -   5        $��count��5#      $
��Left=�6   $��28��6:   $��	36,28,0,0q�6F   $��1��6Y    �� TextWrapping$
 Wrap=�6f   $	��Top=�6{   $	��120��6�   6�   5&      5'      