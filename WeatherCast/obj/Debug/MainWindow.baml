   M S B A M L   `   `   `  ����  WeatherCast    WeatherCast.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $��871.5��6)   .��5      �  J� RenderTransformOrigin$ 0.498,0.207&�6    � ColumnDefinitions 5   
   �� 5      $
��215* �6   �� 5      $
��215* �6    � RowDefinitions 5
   
   �� 5      $��6* �6   �� 5      $	��23* �6   .+�5   
   �� -   5         ��Name$ latitudeBox��5      $
��Left=�6'   $��46��6B   $��	10,10,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $	��412��6�    �� TextAlignment$ Center=�6�   $��28(�6�   $��Rockwell)�6�    �� MaxLines$ 1��6�   ��6u   ��  �� Path$ Latitude�6   �� 5   
   -   5        $ longitudeBox��5      $
��Left=�6(   $��46��6C   $��	10,10,0,0q�6O   $
 Wrap=�6b   $	��Top=�6�   $	��412��6�   $ Center=�6�   $��28(�6�   $��Rockwell)�6�   $��1��6�   $ 1��6  ��6v   �� $ 	Longitude�6  �� 5   
   -   5        $ 
weatherBox��5      $
��Left=�6&   $	��233��6A   $��	10,10,0,0q�6N   $��1��6a   $
 Wrap=�6n   $	��Top=�6�   $	��412��6�   $ Center=�6�   $ 1��6�   $��Rockwell)�6�   $��48(�6  	 �� 
IsReadOnly	 . $��Center=�6/  $��Center=�6Q  ��6�   �� $ Temperature�
 �� Mode$
 OneWay=�6Q  �� 5   
   -   5         ��Name$ SearchButton��5      $��Обновить��6'   $��1��6:   $��Center=�6J   $��102,66,88,61q�6g   $��1��6}   $��Center=�6�   $	��242��6�   $	��126��6�   $��Rockwell)�6�   $��48(�6�   6�   5      5      