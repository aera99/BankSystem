   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankSystem.ViewBankSystem.View  5   	   #    BankSystem.View.LoanRepayment   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankSystem.View     5   	     � Title$  LoanRepayment��5   	   $��145.785��6   $��274.132��60    � Icon$ Resources/bank_icon.jpg��6@   .��5	      � ��5
   
   �� 5       �� ImageSource$ Resources/back2.jpg��6   .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $	��110��6n   $��32��6z   �� 5      $ �Сумма кредита:��6    �� 5      �6   �� *Loan+5      �� 5   
   $
��Left=�6   $��
125,10,0,0q�6/   $
��Wrap=�6C   $B��<Введите сумму погашения кредита:��6W   $	��Top=�6   $	��131��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
125,47,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��131��6y   ��6�   �� *PaymentLoan+�� 5   
   $��Отмена��6   $
��Left=�6"   $��
196,85,0,0q�6=   $	��Top=�6Q   $��60��6i    �� IsCancel . 6t   �� 5   
   $��Принять��6   $
��Left=�6#   $��
125,85,0,0q�6>   $	��Top=�6R   $��60��6j   ��6u   ��  �� Path$ Accept�5      5      