   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankSystem
BankSystem  5   	       BankSystem.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BankSystem     5   	     � Title$  
BankSystem��5   	   $	��428��6   $	��945��6)    � 
ResizeMode$ NoResize=�65    � Icon$ Resources/bank_icon.jpg��5	   	   .��5
      � .+�5   
   � $
��Left=�6   $	��399��6*   $	��Top=�67   $	��939��6O   ��5      �� 5       �� ImageSource$ Resources/back2.jpg��6   .+�5      &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��399��62   $��	335,0,0,0q�6?   $	��Top=�5      $	��604��6/      AutoGenerateColumns .   �� SelectedValue 5      �� *SelectedUser+ �� Mode$ TwoWay=���5      �� *
AllUsers+��68   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *ID+  5      $ Имя��6)   	 66   �� *	FirstName+  5      $ Фамилия��6)   	 6:   �� *
LastName+  5      $ Возраст��6)   	 6:   �� *Age+  5      $ Личный Счет��6)   	 6>   �� *PersonalMoney+  5      $# Депозитный Счет��6)   	 6B   �� *DepositMoney+  5      $ Кредит��6)   	 69   �� *Loan+  5      $ 
Вклад��6)   	 68   �� *Contribution+  5      $  Капитализация��6)   	 6@   �� *Capitalization+5      � 5       $	��379��6   $��	10,10,0,0q�6    $	��320��63   $
��Left=�6?   $	��Top=�6Z   .+�5!      �� $��
41,10,42,0q�6   $
��Wrap=�60   $(��"Работа с клиентами��5"      $	��Top=�62   $��25��6J   $��16(�6q   
 �� TextAlignment$
 Center=�6   ��6V   Z� 6   �� 5#      $��Удалить��6   $
��Left=�6+   $��	10,53,0,0q�6F   $	��Top=�5$      $	��107��61   $��25��6=   ��6I   ��  �� Path$ 
DeleteUser��� 5%      $��Добавить��6   $
��Left=�6,   $��
203,53,0,0q�6G   $	��Top=�5&      $	��107��61   $��25��6=   ��6I   �� $ AddUser��� 5'      $ ��Редактировать��6   $
��Left=�61   $��	10,97,0,0q�6L   $	��Top=�5(      $	��107��61   $��25��6=   ��6I   �� $ EditUser��� 5)      $��Выдать кредит��6   $
��Left=�61   $��
10,143,0,0q�6L   $	��Top=�5*      $	��107��61   $��25��6=   ��6I   �� $ EditLoan��� 5+      $#��Погасить кредит��6   $
��Left=�63   $��203,143,0,0q�6N   $	��Top=�5,      $	��107��61   $��25��6=   ��6I   �� $ EditLoanRepayment��� 5-      $��Перевод денег��6   $
��Left=�61   $��
203,97,0,0q�6L   $	��Top=�5.      $	��107��61   $��25��6=   ��6I   �� $ Trasfer��� 5/      $#��Журнал действий��6   $
��Left=�63   $��
10,187,0,0q�6N   $	��Top=�50      $	��107��6-   $��25��69   ��6E   �� $ ShowActivityLog��� 51      $��TestAddUser��6   $
��Left=�6/   $��
10,339,0,0q�6J   $	��Top=�52      $	��113��6)   $��30��6U   ��65   �� *TestAddUser+6U   �� 53      $��TestAddMonth��6   $
��Left=�60   $��201,339,0,0q�6K   $	��Top=�54      $	��109��6-   $��30��6Z   ��69   �� *TestAddMonth+6Z   55      56      58      59      