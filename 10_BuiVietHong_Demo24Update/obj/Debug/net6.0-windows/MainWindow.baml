   M S B A M L   `   `   `  ����V  R10_BuiVietHong_Demo24Update, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_10_BuiVietHong_Demo24Update_10_BuiVietHong_Demo24Update  5   	   -    '_10_BuiVietHong_Demo24Update.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_10_BuiVietHong_Demo24Update     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $D��>Information about ContactList design by Bui Viet Hong - SE1730��6   $
��Left=�6Y   $��	10,10,0,0q�6t   $	��Top=�6�   4  .System.Windows.Automation.AutomationProperties   IsColumnHeader$
 True��6�   
���   �$��16(�6�   �� 5   
   $��ID��6   $
��Left=�6   $��	10,52,0,0q�68   $	��Top=�6K   �� 5   
   $��Contact Name��6   $
��Left=�6'   $��	10,79,0,0q�6B   $	��Top=�6U   �� 5   
   $��Company Name��6   $
��Left=�6'   $��
10,110,0,0q�6B   $	��Top=�6V   �� 5   
   $��Phone��6   $
��Left=�6    $��
10,149,0,0q�6;   $	��Top=�6O    J� RenderTransformOrigin$ -8.948,-1.37&�6g   �� 5   
   -   5        $��ContactIdTextBox��5   �   $
��Left=�6   $��
111,56,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $	��274��6u   6�   �� 5   
   -   5        $��ContactNameTextBox��5   �   $
��Left=�6   $��
111,87,0,0q�6-   $
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $	��274��6u   6�   �� 5   
   -   5        $��CompanyNameTextBox��5   �   $
��Left=�6   $��111,118,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��274��6v   6�   �� 5   
   -   5        $��PhoneTextBox��5   �   $
��Left=�6   $��111,152,0,0q�6-   $
 Wrap=�6B   $�� ��6V   $	��Top=�6^   $	��274��6v   6�   �� 5   
   -   5        $
��Load��5      $
��Left=�6    $��66,0,0,0q�6;   $��Center=�6M   6h   �� 5   
   -   5        $��Insert��5      $
��Left=�6"   $��	147,0,0,0q�6=   $��Center=�6P   $ 	0.5,0.516&�6�   �� 5   
   -   5        $��Cancel��5      $
��Left=�6"   $��	342,0,0,0q�6=   $��Center=�6P   6k   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $��	248,0,0,0q�6=   $��Center=�6P   6k   �� 5   
   -	   5        $��ContactListView��5   >   $��	0,248,0,0q�6U    �� View 5      �� 5      .P�5      �� $��
Contact Id��6%    �� DisplayMemberBinding 69   �� *	ContactID+�� 5      $��Contact Name��6%    6;   �� *ContactName+�� 5      $��Company Name��6%    6;   �� *CompanyName+�� 5      $��Phone��6%    64   �� *Phone+5      5       5!      5"      