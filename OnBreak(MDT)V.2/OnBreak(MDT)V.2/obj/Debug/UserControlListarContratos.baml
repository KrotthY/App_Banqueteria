   M S B A M L   `   `   `  ����J  FOnBreak(MDT)V.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnBreak_MDT_V._2OnBreak_MDT_V._2  5      1    +OnBreak_MDT_V._2.UserControlListarContratos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:OnBreak_MDT_V._2     5      .��5	      � -   5        
�������.+�5   
   �� $
��Rut*��6   $
��Left=�6   $	��Top=�6:   $��	63,30,0,0q�6R     J� RenderTransformOrigin$  0.645,0.792&�6e   �� 5   
   $��Tipo de Evento��6   $
��Left=�6)   $��	54,84,0,0q�6D   $	��Top=�6W   �� 5   
   -   5         ��Name$ txtRutLc��5      $
��Left=�6$   $��23��6?   $��
175,26,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��144��6�   �� 5   
   $��N°Contrato��6   $
��Left=�6%   $��
390,30,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtNroContrato��5      $
��Left=�6*   $��
487,26,0,0q�6E   $	��Top=�6Y   $	��120��6q   $  -0.026,-0.379&�6}   �� 5   
   -   5         ��Name$ cboTipoEvento��5      $
��Left=�6*   $��
199,80,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5   
   $
��Left=�6   $	��167��6/   $��587,160,0,0q�6<   $	��Top=�6Q   $	��175��6i   ��5      �� 5      -   5        imgListarContrato�� �� ImageSource$, &/Images/dark_logo_white_background.jpg��5   8   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgListaContratoLc��5      $
��Left=�6.   $	��308��6I   $��41,148,0,-6q�6V   $	��Top=�6k   $	��530��6�   $   HorizontalScrollBarVisibility$ Visible=�6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 N° Contrato��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *Numero+  5      $	 Rut Cliente��6%   
 6:   �� *
RutCliente+  5      $	 	Modalidad��6%   
 68   �� *IdModalidad+  5      $	 Tipo de Evento��6%   
 6=   �� *IdTipoEvento+  5      $	 Hora de Inicio��6%   
 6=   �� *FechaHoraInicio+  5      $	 Hora de Termino��6%   
 6>   �� *FechaHoraTermino+5!      �� 5"   
   -   5         ��Name$ btnImprimir��5"      $��Imprimir��6&   $
��Left=�69   $��600,418,0,0q�6T   $	��Top=�6i   $	��142��6�   6�   �� 5#   
   -   5        $ btnEliminar��5#      $��Eliminar��6&   $
��Left=�69   $��
600,87,0,0q�6T   $	��Top=�6h   $	��100��6�   6�   �� 5$   
   -	   5        $ 	btnBuscar��5$      $��Buscar��6$   $
��Left=�65   $��
446,87,0,0q�6P   $	��Top=�6d   $	��100��6|   6�   5&      5'      