   M S B A M L   `   `   `  ����J  FOnBreak(MDT)V.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnBreak_MDT_V._2OnBreak_MDT_V._2  5   	   .    (OnBreak_MDT_V._2.OpcionalListarContratos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OnBreak_MDT_V._2     5   	   -   5          � Title$  Lista de Contratos��5   	   $	��600��6$   $	��600��61    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b   $��Yu Gothic UI Semibold)�6x    � Icon$ images/Captura1.JPG��6�    � WindowStyle$ ThreeDBorderWindow=�6�   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgListaContratos��5
      $
��Left=�6-   $	��571��6H   $	��Top=�6U   $	��594��6m   $   HorizontalScrollBarVisibility$ Visible=�6y   ���	#FFDEDEDE   
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 N° Contrato��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *Numero+  5      $	 Rut Cliente��6%   
 6:   �� *
RutCliente+  5      $	 	Modalidad��6%   
 68   �� *IdModalidad+  5      $	 Tipo de Evento��6%   
 6=   �� *IdTipoEvento+  5      $	 Hora de Inicio��6%   
 6=   �� *FechaHoraInicio+  5      $	 Hora de Termino��6%   
 6>   �� *FechaHoraTermino+5      5      5      