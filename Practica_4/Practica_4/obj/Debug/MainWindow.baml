   M S B A M L   `   `   `  ����E  APractica_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Practica_4
Practica_4  5   	       Practica_4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Practica_4     5   	   -   5          �Name$  Ventana_Inicio��5   	    � Title$ Gestor Teatro��5	   	   $	��450��6   $	��800��6,   .��5
      � ���	#FF8B0606 � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5         ��Name$ canvas_salas��5      $��1��6'   ���	#FF5F0303.+�5      �� -   5        $ canvas_escenario��5      $	��400��6/   $	��100��6;   
 �� Top$ 50��6H    �� Left$	 100��6X   ���	#FF444444$y�Hidden=�6�   .+�5      �� -   5         ��Name$ label_escenario��5      $��	Escenario��61   $��50(�6E   $ 11��6S   $ 90��6c   � 5      -   5         �Name$ Grid_asientos��5   A   $	 150��6   $	��500��6(   $	��200��64   $	 -50��6X   5      5      �� 5      -   5        $ label_ocupado��5      $��Ocupado��6+   $	 155��6=   $	 160��6O   $y�Hidden=�6`   �� 5      -   5        $ label_reservado��5      $��	Reservado��6-   $	 300��6A   $	 160��6S   $y�Hidden=�6d   �� 5      -   5        $ label_libre��5      $��Libre��6)   $	 450��69   $	 160��6K   $y�Hidden=�6\   �� 5      -	   5        $ label_color_ocupado��5      $	��   ��61   $	 130��6?   $	 160��6Q   
���  ��$��20��6s   $y�Hidden=�6   �� 5      -
   5        $ label_color_reservado��5      $	��   ��63   $	 270��6A   $	 160��6S   
��� ���$��20��6x   $y�Hidden=�6�   �� 5      -   5        $ label_color_libre��5      $	��   ��6/   $	 420��6=   $	 160��6O   
�������$��20��6s   $y�Hidden=�6   �� 5      -   5        $ label_fecha��5      $
��Bold"�6)   $�� ��6;   $ 59��6F   $ 12��6W   �� 5      -   5        $ 
label_hora��5      $
��Bold"�6(   $�� ��6:   $	 212��6E   $ 12��6W   5      �� 5   
   $��0��6   .+�5       �� $��10(�6   $
��Bold"�6"   .��64   *(Por favor, haga doble click en una sala:6^   �� 5!      -   5         ��Name$ lst_box_salas��5!      $	��390��6-   $��0,0,0,0q�6:   $	��197��6K   ���	#FF8B0606���	#FF8B0606$��18(�6�   $
��Bold"�6�   6�   5"      5#      5$      