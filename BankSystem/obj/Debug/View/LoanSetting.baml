   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankSystem.ViewBankSystem.View  5   	   !    BankSystem.View.LoanSetting   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankSystem.View     5   	     � Title$  LoanSetting��5   	   $��224.109��6   $��384.257��6.    � Icon$ Resources/bank_icon.jpg��6>   .��5	      � ��5
   
   �� 5       �� ImageSource$ Resources/back2.jpg��6   .+�5   
   � $
��Left=�6   $	��173��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��157��6b   .+�5      �� $
��Left=�6   $��	10,10,0,0q�63   $
��Wrap=�6F   $8��2Данные о выбранном клиенте:��6Z   $	��Top=�6}   $	��137��6�   $��33��6�   �� 5      $
��Left=�6   $��	10,49,0,0q�63   $
��Wrap=�6F   $	��Top=�6Z   $	��137��6r   $��30��6~   �� 5      $�	ФИО - ��6    �� 5      �6   �� *
FullName+5      �� 5      $
��Left=�6   $��	10,87,0,0q�63   $
��Wrap=�6F   $	��Top=�6Z   $	��137��6r   $��30��6~   �� 5      $�Баланс - ��6    �� 5      �6   �� *PersonalMoney+5      �� 5      $
��Left=�6   $��
10,126,0,0q�63   $
��Wrap=�6G   $	��Top=�6[   $	��137��6s   $��37��6   �� 5      $*�$Кредитный процент - ��6    �� 5      �6   �� *PercentageOfLoan+5      5      � 5   
   $
��Left=�6   $	��113��6*   $��
172,10,0,0q�67   $	��Top=�6K   $	��188��6c   .+�5      �� $
��Left=�6   $��	10,10,0,0q�63   $
��Wrap=�6F   $F��@Введите сумму выдаваемого кредита:��6Z   $	��Top=�6�   $	��168��6�   �� 5      $
��Left=�6   $��21��61   $��	10,47,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��168��6|   ��6�   �� *	AddLoan+5      �� 5    
   $��Отмена��6   $
��Left=�6"   $��291,163,0,0q�6=   $	��Top=�6R   $��75��6j    �� IsCancel . 6u   �� 5!   
   $��Принять��6   $
��Left=�6#   $��211,163,0,0q�6>   $	��Top=�6S   $��75��6k   ��6v   ��  �� Path$ Accept�5#      5$      