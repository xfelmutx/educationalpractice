   M S B A M L   `   `   `  ����G  CWpfUPractika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfUPractikaWpfUPractika  5          WpfUPractika.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfUPractika     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  
MainWindow��5      $	��800��5	      $	��550��5
      .��5      � ��5   
   �� 5       �� ImageSource$ Images/background.jpg��6    j� Stretch$
 Fill=�6=    � RowDefinitions 5   
   �� 5      �� 5      $��5* �6   .+�5   
   �� ���#E683006   � 5   
    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��3* �6#   �� 5      $��2* �6#   .+�5      �� $��0��5       $	��100��5!      $��60��5"      $��Images/logo.png��5#      �� 5&      $��1��5'      $��Center=�5(      $��30(�5)      $��ESOFT Corp.��5*       �� TextAlignment$ Center=�5+      � 5,      $��0��6   $��2��6     5-      �� 5.      �� 5/      .+�52      �� -   5         ��Name$ 
backButton��53      $��0��54      $��50��55      $��10q�56      $��Center=�57      $��
Назад��59      �� 5:      -   5        $ 
exitButton��5;      $��1��5<      $��50��5=      $��10q�5>      $��Center=�5?      $��
Выход��5A      5B      5C       � 5E   
   -   5          �Name$ frameNav��5F      $��1��5G      $��20q�5H        � NavigationUIVisibility$ Hidden=�5I      5K      5L      