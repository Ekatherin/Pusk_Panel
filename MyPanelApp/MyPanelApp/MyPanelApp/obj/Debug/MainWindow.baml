   M S B A M L   `   `   `  ����E  AMyPanelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyPanelApp
MyPanelApp  5   	       MyPanelApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyPanelApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType   MyAzureStyle �� Property �� Value��%}   &	        �� 5
   
   " ��6   .�5      ��  � ��
 �����6;   �� 5       � ��$ 20(�6)   66   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��2* �6   6,   .+�5   
   �� $��0��6   
�������67   �� 5   
   $��1��6   
������68   �� 5   
   $��2��6   
�������67   �� 5   
   $��0��6   $	��Top=�6%   .+�5      �� -   5         ��Name$ 
GalleryBtn��5      $��Gallery��6)   6V   5      �� 5   
   $��0��6   $��Bottom=�6%   .+�5      �� -   5        $ AppsBtn��5      $
��Apps��6&   6M   �� 5      -   5        $ SettingsBtn��5      $��Settings��6*   6?   5      �� 5    
   -   5        $��AppsListView��5    9   $��1��6N   ��6   �� *Applications+��5!      �� 5"      .R�5#      �� .+�5$      ��  �� Orientation$ 
Horizontal=�6%   .+�5%      �� 
��������6$   �� *ApplicationCategory.Title+6l   5&      �� 5'      ��6    �� *Title+6<   �� 5(      ��6    �� *
FilePath+6?   5)      5*      5,      �� 5-   
   $��2��6   .+�5.      �� -   5        $��
SearchText��5.      .��6P   50      �� 52      -   5        $��CategoryCombobox��52       �� DisplayMemberPath$ Title��53      	 �� SelectedItem	 54      �� 
 �� ElementName$
 AppsListView�� �� Path$&  SelectedItem.ApplicationCategory�55      �� 56      -   5        $��CategoryTitle��56      ��57      �� $
 AppsListView��$, &SelectedItem.ApplicationCategory.Title��� 59      -   5         ��Name$ TitleTextBox��59      ��5:      �� $
 AppsListView��$ SelectedItem.Title��� 5<      -	   5        $ DiscriptionTextBox��5<      ��5=      �� $
 AppsListView��$ SelectedItem.FilePath��� 5?      -
   5        $��SaveBtn��5?      $
��Save��6$   6K   5@      �� 5A   
   $
��Auto=�6   $��3��6;   .��5B      �  � 
ItemHeight$	 200��6    � 	ItemWidth$	 200��6)   
�������.+�5C      ��   MyBrownStyle#��[ 6   .��6?   16B   �� 5D      .��6   26   �� 5E      .��6   36   �� 5F      #��[  6   .��6?   46B   5G      5H      5I      5J      