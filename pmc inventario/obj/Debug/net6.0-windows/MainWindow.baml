   M S B A M L   `   `   `  ����I  Epmc inventario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:pmc_inventariopmc_inventario  5   	       pmc_inventario.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:pmc_inventario     5   	     � Title$  
MainWindow��5   	   $	��644��6   $	��908��6)   .��5	      � #��� ��6    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ label��5      $��Organizador de Inventario��6   $��31,27,510,536q�6C   ���	#FF1D1212$
��Bold"�6�   $��Arial Black)�6�   $��24(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6q   �� *ActualWidth+ �� ElementName$ label�� �� Mode$ OneWay=�z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5       T� X$ 0Q�6)   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgLista��5      $��317,158,67,72q�6N   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   �� 5   
   -   5        $*��$   Agregar Articulo                 ��5      $
��Left=�5      $��
72,192,0,0q�6.   $	��Top=�6B   $	��118��6Z   $��35��6f   6r   �� 5   
   -   5        $,��&   Modificar Articulo                 ��5      $
��Left=�5      $��
72,288,0,0q�6.   $	��Top=�6B   $	��118��6Z   $��42��6f   6r   �� 5   
   -   5        $+��%   Eliminar Articulo                 ��5      $
��Left=�5      $��
72,392,0,0q�6.   $	��Top=�6B   $	��118��6Z   $��40��6f   6r   �� 5   
   $��Buscar��6   $
��Left=�6"   $��
737,97,0,0q�6=   $	��Top=�6Q   $	��104��6i   �� 5   
   $
��Left=�6   $��
317,97,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $	��389��6m   $��21��6y   �� 5    
   $!��Buscar por:                ��6   $
��Left=�5!      $��
317,74,0,0q�6-   $	��Top=�6A   	� 5"   
   $"��Codigo                      ��6   $��Center=�5#      $��0,80,0,0q�65   $	��Top=�6G   $��74��6_   	� 5$   
   $��Descripcion ��6   $
��Left=�5%      $��
512,80,0,0q�6   $	��Top=�62   �� 5&   
   $,��&El Articulo se encuentra en el sector:��6   $
��Left=�6A   $��297,561,0,0q�6\   $	��Top=�6q   �� 5'   
   -   5        $��	lblSector��5'      $�� ��6!   $
��Left=�6,   $��512,561,0,0q�6G   $	��Top=�6\   �� 5(   
   $-��'         Ver Ubicacion                 ��6   $
��Left=�5)      $��709,561,0,0q�6.   $	��Top=�6C   $	��132��6[   5+      5,      