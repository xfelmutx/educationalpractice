   M S B A M L   `   `   `  ����G  CWpfUPractika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfUPractika.PagesWpfUPractika.Pages  5      (    "WpfUPractika.Pages.AddPropertyPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfUPractika.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  AddPropertyPage��5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��5       $��1��5!      $��Center=�5"      $%��Тип недвижимости��5#       �� TextAlignment$ Center=�5$      �� 5%   
   -   5         ��Name$ comboTypeId��5&      $��1��5'      $��2��5(      $��10q�5)      $��Center=�5*      �� 5-   
   $��2��5.      $��1��5/      $��Center=�50      $��Этаж��51      $ Center=�52      �� 53   
   -   5         ��Name$ 	textFloor��54      $��2��55      $��2��56      $��10q�57      $��Center=�58      �� 5;   
   $��3��5<      $��1��5=      $��Center=�5>      $��Комнаты��5?      $ Center=�5@      �� 5A   
   -   5        $ textRoom��5B      $��3��5C      $��2��5D      $��10q�5E      $��Center=�5F      �� 5I   
   $��4��5J      $��1��5K      $��Center=�5L      $��Площадь��5M      $ Center=�5N      �� 5O   
   -   5        $ textArea��5P      $��4��5Q      $��2��5R      $��10q�5S      $��Center=�5T      �� 5W   
   $��5��5X      $��1��5Y      $��Center=�5Z      $��
Адрес��5[      $ Center=�5\      �� 5]   
   -   5        $ comboAddressId��5^      $��5��5_      $��2��5`      $��10q�5a      $��Center=�5b      �� 5e   
   -   5         ��Name$ 	addButton��5f      $��6��5g      $��1��5h      $��10q�5i      $��Добавить��5k      �� 5l   
   -   5        $ cancelButton��5m      $��6��5n      $��2��5o      $��10q�5p      $��Отмена��5r      5s      5t      