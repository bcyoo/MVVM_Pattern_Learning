   M S B A M L   `   `   `  ����D  @CRUD.MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRUD.MVVM	CRUD.MVVM  5   	   ;"clr-namespace:CRUD.MVVM.ConvertersCRUD.MVVM.Converters  5
   	       CRUD.MVVM.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CRUD.MVVM     5   	   9
converters"clr-namespace:CRUD.MVVM.Converters     5
   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      4   .CRUD.MVVM.Converters.BoolToVisibilityConverter   BoolToVisibilityConverter # ReversBoolToVisibilityConverter   
FalseValue   	TrueValue��%e   &	        &	        5   
   6/     5   
   $ Visible=�5      $ 	Collapsed=�5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��80��5      $��Right=�5       $��Search��5!      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ MemberDataGrid��5"      $��1��6+   $��0 10 0 0q�68      AutoGenerateColumns .     
IsReadOnly . ��5#      �� *	Members+*  $Microsoft.Xaml.Behaviors.Interaction	   Triggers	 5)      +  %Microsoft.Xaml.Behaviors.EventTrigger  5*      
   	EventName$
 SeletectionChanged��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5+      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand .    Command 6,   �� *SelectionChangedCommand+5,   ,   5/         Columns 52   
   0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6G   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6!   �� *Name+ �� Mode$ TwoWay=�6G     54      $ Phone��6H    6!   �� *Phone+$ TwoWay=�6H     55      $ Regested Date��6S    6!   �� *	RegDate+ �� StringFormat$ {0:d}��6S   4
  .System.Windows.Controls.DataGridCheckBoxColumn
  56      $	 Use��6L    6%   �� *IsUse+$ TwoWay=�6L   58      �� 5:   
   $��1��5;      $��0 0 5 0q�5<      $��Right=�5=       �� Orientation$ 
Horizontal=�5>      .+�5?      �� -   5         ��Name$ 	NewButton��5@      $��80��5A      $	��New��5C      ��5B      �� *
NewCommand+y�5D      �� *	IsEditing+ �� 	Converter# [ �� 5E      -   5        $ 
EditButton��5F      $��80��5G      $��5 0 0 0q�5H      $
��Edit��5I      y�5J      �� *	IsEditing+# [ �� 5K      -   5        $ DeleteButton��5L      $��80��5M      $��5 0 0 0q�5N      $��Delete��5O      y�5P      �� *	IsEditing+# [ �� 5Q      -   5        $ 
SaveButton��5R      $��80��5S      $��Delete��5U      ��5T      �� *DeleteCommand+y�5V      �� *	IsEditing+# [  �� 5W      -   5        $ CancelButton��5X      $��80��5Y      $��5,0,0,0q�5Z      $��Cancel��5\      ��5[      �� *CancelCommand+y�5]      �� *	IsEditing+# [  5^      � 5_   
   -   5         �Name$ 
DetailGrid��5`      $��1��5a      $��1��5b      $��0 10 0 0q�5c      {�5d      �� *	IsEditing+ 5e      �� 5f      $
��0.3* �6#   �� 5g      $
��0.7* �6#    5i      �� 5j      $
��Auto �6    �� 5k      $
��Auto �6    �� 5l      $
��Auto �6    �� 5m      $
��Auto �6    �� 5n      $
��Auto �6    .+�5p      �� $��4q�6   
�������._�5q      �� $��4 0 0 0q�5r      
�������$��Id��5t      5u      �� 5w      -   5         ��Name$ Id��5x      $��1��5y      $��4q�5z      ��5{      �� *EditMember.Id+�� 5|      $��1��5}      $��4q�5~      
�������._�5�      �� $��4 0 0 0q�5�      
�������$
��Name��5�      5�      5�      5�      5�      