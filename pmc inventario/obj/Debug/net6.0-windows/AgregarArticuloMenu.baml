   M S B A M L   `   `   `  ����I  Epmc inventario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:pmc_inventariopmc_inventario  5   	   (    "pmc_inventario.AgregarArticuloMenu   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:pmc_inventario     5   	     � Title$  AgregarArticuloMenu��5   	   $	��257��6%   $	��497��62   .��5	      � ���	#FF69D2E6$��	0,0,0,-16q�6"    � ColumnDefinitions 5
   
   �� 5      $
��153* �6   �� 5      $��7* �6   .+�5   
   �� -   5        $��
btnAgregar��5      $��Agregar��6#   $��Center=�65   $��	0,174,0,0q�6R   $	��Top=�6e   $��96��6}   6�   �� 5   
   -   5        $��	txtCodigo��5      $
��Left=�6#   $��
209,45,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��229��6~   �� 5   
   -   5        $��txtDescripcion��5      $
��Left=�6(   $��
209,88,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��229��6�   �� 5   
   $��Codigo��6   $
��Left=�6!   $��	64,45,0,0q�6<   $	��Top=�6O    J� RenderTransformOrigin$ -0.114,-0.371&�6g   $��91��6�   �� 5   
   $��Descripción��6   $
��Left=�6&   $��	64,84,0,0q�6A   $	��Top=�6T   $ -0.114,-0.371&�6l   $��91��6�   �� 5   
   $��
Ubicación��6   $
��Left=�6$   $��
64,123,0,0q�6?   $	��Top=�6S   $ -0.114,-0.371&�6k   $��91��6�   �� 5   
   -   5        $��	lblTitulo��5      $&�� Agregar Articulo                ��6!   $
��Left=�5      $��
186,10,0,0q�6-   $	��Top=�6A   $ -0.114,-0.371&�6Y   $	��125��6   $
��Bold"�6�   �� 5   
   -   5        $��cmbUbicacion��5      $
��Left=�6'   $��209,129,0,0q�6B   $	��Top=�6W   $	��120��6o   $��20��6{   .@�5      �� .��5      �� A16    5      �� 5      .��5      �� A26    5      �� 5      .��5      �� A36    5      �� 5       .��5!      �� B16    5"      �� 5#      .��5$      �� B26    5%      �� 5&      .��5'      �� B36    5(      �� 5)      .��5*      �� C16    5+      �� 5,      .��5-      �� C26    5.      �� 5/      .��50      �� C36    51      52      54      55      