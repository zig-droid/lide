   M S B A M L   `   `   `  ����?  ;Lide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LideLide  5   	       Lide.LoadData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lide     5   	     � Title$  LoadData��5   	   $	��600��6   $	��800��6'   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   $	��230��6,   .+�5      �� 
��� � �$��
Výpis dat��6'   $��Center=�6;   $��10q�6X   $	��Top=�6d   $	��143��6|   $
��Bold"�6�   � 5      -   5         �Name$ MainGrid��5      .+�5      �� -   5         ��Name$ 	textBlock��5      $
��Left=�6/   $	��Top=�6J   $	��300��6b   $	��300��6n   $
��Wrap=�6{   $��20,0,0,0q�6�   �� 5      -   5         ��Name$ firstNameTextBox��5      $
��Left=�64   $��500,105,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ lastNameTextBox��5      $
��Left=�63   $��500,210,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5      $��Smazat pojištěnou osobu��6   $
��Left=�6:   $��
500,25,0,0q�6U   $	��Top=�6i   $
��Bold"�6�   �� 5      $��Zadejte jméno��6   $
��Left=�60   $��
500,62,0,0q�6K   $	��Top=�6_   �� 5      $��Zadejte příjmení��6   $
��Left=�63   $��500,175,0,0q�6N   $	��Top=�6c   5      �� 5      -   5        $��	Load Data��5      $	��100��6C   $��10q�6O   $��Right=�6[    K� ZIndex$ 3��6w   �� 5      -   5        $
��Exit��5      $	��100��6>   $��10q�6J   $��Right=�6V   $ 2��6r   �� 5      -   5        $��Delete��5      $	��100��6A   $��10q�6M   $ 1��6Y   $��Right=�6j   �� 5      -   5        $
��Edit��5      $��10q�6=   $	��100��6I   $��Right=�6U   5      5      5      