   M S B A M L   `   `   `  ����J  FOnBreak(MDT)V.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnBreak_MDT_V._2OnBreak_MDT_V._2  5      /    )OnBreak_MDT_V._2.UserControlListarCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:OnBreak_MDT_V._2     5      .��5	      � -   5        
�������.+�5   
   �� $	��Rut��6   $
��Left=�6   $	��Top=�69   $��	63,30,0,0q�6Q     J� RenderTransformOrigin$  0.645,0.792&�6d   �� 5   
   $��Tipo Actividad*��6   $
��Left=�6*   $��	54,84,0,0q�6E   $	��Top=�6X   �� 5   
   -   5         ��Name$ 
txtRutLcli��5      $
��Left=�6&   $��23��6A   $��
175,26,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��165��6�   �� 5   
   $��Tipo Empresa��6   $
��Left=�6'   $��
390,30,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ cboTipoEmpresa��5      $
��Left=�6+   $��
487,26,0,0q�6F   $	��Top=�6Z   $	��120��6r   $  -0.026,-0.379&�6~   �� 5   
   -   5        $ cboTipoActividad��5      $
��Left=�6-   $��
175,80,0,0q�6H   $	��Top=�6\   $	��120��6t   �� 5   
   $
��Left=�6   $	��169��6/   $��588,154,0,0q�6<   $	��Top=�6Q   $	��177��6i   ��5      �� 5      -   5        imgLogoTipo�� �� ImageSource$, &/Images/dark_logo_white_background.jpg��5   2   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgListaClienteLcli��5      $
��Left=�6/   $	��302��6J   $��
15,138,0,0q�6W   $	��Top=�6k   $	��568��6�      GridLinesVisibility$	 All=�6�      
IsReadOnly .    AutoGenerateColumns .  	   SelectionMode$	 Single=�6�   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6�   $   HorizontalScrollBarVisibility$ Visible=�6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Rut Cliente��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
RutCliente+  5      $ Razon Social��6%    6;   �� *RazonSocial+  5      $ Nombre Completo��6%    6>   �� *NombreContacto+  5      $ Email��6%    64   �� *MailContacto+  5      $ 	Direccion��6%    68   �� *	Direccion+  5      $ Telefono��6%    67   �� *
Telefono+5!      �� 5"   
   -   5         ��Name$ btnImprimir��5"      $��Imprimir��6&   $
��Left=�69   $��618,408,0,0q�6T   $	��Top=�6i   $	��142��6�   6�   �� 5#   
   -   5        $ btnEliminar��5#      $��Eliminar��6&   $
��Left=�69   $��
588,87,0,0q�6T   $	��Top=�6h   $	��100��6�   6�   �� 5$   
   -	   5        $ 	btnBuscar��5$      $��Buscar��6$   $
��Left=�65   $��
422,87,0,0q�6P   $	��Top=�6d   $	��100��6|   6�   5&      5'      