   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankSystem.ViewBankSystem.View  5   	   #    BankSystem.View.MoneyTransfer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankSystem.View     5   	     � Title$  MoneyTransfer��5   	   $	��380��6   $	��720��6,    � Icon$ Resources/bank_icon.jpg��68   .��5	      � $��0,0,-3,0q�6   ��5
   
   �� 5       �� ImageSource$ Resources/back2.jpg��6   .+�5   
   �� $��Отмена��6   $
��Left=�6"   $��630,319,0,0q�6=   $	��Top=�6R   $��75��6j    �� IsCancel . 6u   �� 5   
   $��Принять��6   $
��Left=�6#   $��549,319,0,0q�6>   $	��Top=�6S   $��76��6k   ��6v   ��  �� Path$ Accept��� 5   
   $
��Left=�6   $��23��6-   $��549,291,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��156��6z   ��6�   �� *Sum+ �� Mode$ TwoWay=�� 5   
   $	��255��6   $��0,10,0,0q�6   $	��Top=�6.    � ColumnDefinitions 5      �� 5      .+�5      �� $
��Left=�6   $��	10,10,0,0q�63   $
��Wrap=�6F   $B��<Клиент который переводит деньги:��6Z   $	��Top=�6�   $��24��6�   $	��315��6�    �� TextAlignment$ Center=�6�   �� 5      $
��Left=�6   $��
390,10,0,0q�63   $
��Wrap=�6G   $D��>Клиент которому поступают деньги:��6[   $	��Top=�6�   $��24��6�   $	��315��6�   $ Center=�6�   �� 5      $
��Left=�6   $��343,134,0,0q�63   $
��Wrap=�6H   $
��🠖��6\   $	��Top=�6f   $��30��6~   $��36��6�   $ Center=�6�   $��36(�6�   &   System.Windows.Controls.DataGrid  5      $
��Left=�6   $	��206��62   $��	10,39,0,0q�6?   $	��Top=�6R   $	��315��6j   	   AutoGenerateColumns	 .  
 �� SelectedValue
 6v   �� *SelectedSender+$ TwoWay=���5      �� *
AllUsers+��68   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+  5      $ Имя��6)    66   �� *	FirstName+  5      $ Фамилия��6)    6:   �� *
LastName+  5      $ Возраст��6)    6:   �� *Age+  5      $ Счет��6)    67   �� *PersonalMoney+5         5!      $
��Left=�6   $	��206��62   $��
390,39,0,0q�6?   $	��Top=�6S   $	��315��6k   	 .  
 6w   �� *SelectedRecipient+$ TwoWay=���5"      �� *
AllUsers+��68   Z�  5#        5$      $ ID��6)    65   �� *ID+  5%      $ Имя��6)    66   �� *	FirstName+  5&      $ Фамилия��6)    6:   �� *
LastName+  5'      $ Возраст��6)    6:   �� *Age+  5(      $ Счет��6)    67   �� *PersonalMoney+5*      5+      �� 5,   
   $
��Left=�6   $��549,270,0,0q�6/   $
��Wrap=�6D   $ ��Введите сумму:��6X   $	��Top=�6n   $	��156��6�   5.      5/      