   M S B A M L   `   `   `  ����E  ABankSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankSystem.ViewBankSystem.View  5   	   !    BankSystem.View.UserSetting   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankSystem.View     5   	     � Title$  UserSetting��5   	   $��206.379��6   $��610.667��6.    � Icon$ Resources/bank_icon.jpg��6>    � 
ResizeMode$ NoResize=�6]   .��5	      � ��5
   
   �� 5       �� ImageSource$ Resources/back2.jpg��6   .+�5   
   � $
��Left=�6   $	��100��6*   $��	10,65,0,0q�67   $	��Top=�6J   $	��321��6b   .+�5      �� $��
Вклад��6   $
��Left=�6'   $��0,10,0,0q�6B   $	��Top=�6T   $��17��6l   $	��120��6x    �� 	ClickMode$ Press=�6�    d� 	IsChecked 6�   �� *Contribution+��6�   ��  �� Path$ ContributionCheck��� 5      $
��Left=�6   $��	154,9,0,0q�63   $
��Wrap=�6F   $ ��Введите сумму:��6Z   $	��Top=�6p   $��17��6�   $	��141��6�   �� 5      $
��Left=�6   $��23��61   $��
154,32,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��118��6}   {�6�   �� *Contribution+��6�   �� *DepositMoney+�� 5      $ ��Капитализация��6   $
��Left=�6/   $��0,38,0,0q�6J   $	��Top=�6\   $��17��6t   $	��120��6�   $ Press=�6�   {�6�   �� *Contribution+ 6�   �� *Capitalization+5      � 5   
   $
��Left=�6   $��50��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��572��6a   .+�5      �� $��0,1,0,0q�6   $
��Wrap=�6)   $��Введите имя��6=   $��18��6P   $	��120��6\    �� TextAlignment$ Center=�6h   $
��Left=�6   $	��Top=�6�   �� 5      $��22��6   $��0,24,0,0q�6"   $
 Wrap=�64   $	��120��6H   $
��Left=�6T   $	��Top=�6o   ��6�   �� *	FirstName+�� 5      $��	153,1,0,0q�6   $
��Wrap=�6+   $#��Введите фамилию��6?   $��18��6V   $	��120��6b   $ Center=�6n   $
��Left=�6�   $	��Top=�6�   �� 5      $��22��6   $��
153,24,0,0q�6"   $
 Wrap=�66   $	��120��6J   $
��Left=�6V   $	��Top=�6q   ��6�   �� *
LastName+�� 5      $��	304,1,0,0q�6   $
��Wrap=�6+   $#��Введите возраст��6?   $��18��6V   $	��120��6b   $ Center=�6n   $
��Left=�6�   $	��Top=�6�   �� 5      $��22��6   $��
304,24,0,0q�6"   $
 Wrap=�66   $	��120��6J   $
��Left=�6V   $	��Top=�6q   ��6�   �� *Age+�� 5      $��	452,1,0,0q�6   $
��Wrap=�6+   $*��$Введите личный счет��6?   $��18��6Z   $	��120��6f   $ Center=�6r   $
��Left=�6�   $	��Top=�6�   �� 5      $��22��6   $��
452,24,0,0q�6"   $
 Wrap=�66   $	��120��6J   $
��Left=�6V   $	��Top=�6q   ��6�   �� *PersonalMoney+5      �� 5   
   $��Отмена��6   $
��Left=�6"   $��496,135,0,0q�6=   $	��Top=�6R   $��86��6j   	 �� IsCancel	 . 5      �� 5   
   $��Принять��6   $
��Left=�6#   $��405,135,0,0q�6>   $	��Top=�6S   $��86��6k   ��6v   �� $ Accept�5       5!      