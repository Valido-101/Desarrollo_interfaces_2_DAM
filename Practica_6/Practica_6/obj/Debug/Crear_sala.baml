   M S B A M L   `   `   `  ����E  APractica_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Practica_6
Practica_6  5   	       Practica_6.Crear_sala   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Practica_6     5   	   -   5          � Title$  
Crear_sala��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s   .��5	      � ���	#FF8B0606$��0,0,0,0q�6"   .+�5
   
   �� $��Título del evento:��6   $
��Left=�6-   $��118,104,0,0q�6H   $	��Top=�6]   �� 5   
   -   5         ��Name$ txtbox_nombre_evento��5      $
��Left=�60   $��23��6K   $��225,104,0,0q�6W    �� TextWrapping$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   $��Fecha del evento: ��6   $
��Left=�6-   $��118,154,0,0q�6H   $	��Top=�6]   �� 5   
   -   5        $ txtbox_fecha��5      $
��Left=�6(   $��23��6C   $��225,154,0,0q�6O   $
 Wrap=�6d   $��Formato dd/mm/aaa��6x   $	��Top=�6�   $	��120��6�   
�������6�   �� 5   
   $��Hora:��6   $
��Left=�6    $��118,204,0,0q�6;   $	��Top=�6P   �� 5   
   -   5        $ txtbox_hora��5      $
��Left=�6'   $��23��6B   $��225,204,0,0q�6N   $
 Wrap=�6c   $��Formato hh:mm��6w   $	��Top=�6�   $	��120��6�   
�������6�   �� 5   
   $��Filas:��6   $
��Left=�6!   $��440,104,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $ txtbox_filas��5      $
��Left=�6(   $��23��6C   $��486,104,0,0q�6O   $
 Wrap=�6d   $��Número de filas��6x   $	��Top=�6�   $	��120��6�   
�������6�   �� 5   
   $��Butacas:��6   $
��Left=�6#   $��423,154,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ txtbox_columnas��5      $
��Left=�6+   $��23��6F   $��486,154,0,0q�6R   $
 Wrap=�6g   $��Butacas por fila��6{   $	��Top=�6�   $	��120��6�   
�������6�   �� 5   
   -   5         ��Name$ 	btn_crear��5      $��Crear��6$   $	��100��64   $��30��6@   $��357,274,0,0q�6L   $	��Top=�6y   $
��Left=�6�   �� 5   
   $��Cartel:��6   $
��Left=�6"   $��428,205,0,0q�6=   $	��Top=�6R   �� 5   
   -   5        $ txtbox_cartelEvento��5      $
��Left=�6/   $��23��6J   $��487,203,0,0q�6V   $
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��120��6�   �� 5   
   -	   5        $ btn_elegirArchivo��5      $	��100��6,   $��23��68   $��Elegir archivo��6D   $��
540,20,0,0q�6]   6q   5      5      