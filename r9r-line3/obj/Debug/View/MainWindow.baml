   M S B A M L   `   `   `  ����D  @r9r-line3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:r9r_line3	r9r_line3  5   	       r9r_line3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:r9r_line3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��Compte��5      $
��Wrap=�6"   �� 5      .�6   COMPTE6   5      �� 5   
   -   5         ��Name$	 Nom��5      $��1��6   $	��Nom��6,   $��Center=�67   $��Center=�6T   $��50��6o   $	��264��6{   6�   �� 5   
   -   5        $ Prenom��5      $��2��6"   $��Prenom��6/   $��Center=�6=   $��Center=�6Z   $��50��6u   $	��264��6�   �� 5!   
   $��3��6   $��0,0,0,55q�6"   $��2��64   .+�5"      �� -   5         ��Name$ btn_envoyer��5"      $��ENVOYER��6*   $��5,5,5,5q�6<   6M   5#      �� 5$   
   -   5         ��Name$ 
textBlock2��5$      $
��Wrap=�6(   $��1��6<   $��15(�6L   �� 6\   $
��Bold"�6`   $�Liste Voyage��6r   �� 6�   $
��Bold"�6�   $� :��6�   6�   �� 5)   
   -   5         ��Name$ listBox��5)      $��10,10,10,10q�6#   $��1��69   $��1��6J   $��2��6X   ��5*      �� 5+      .R�5-      �� �� 5.      $��SemiBold"�6!   �6   �� *	NOMVOYAGE+6!   50      51      53      �� 55   
   $��7��6   $��1��6"   .+�56      �� -   5        $ btn_supprimer��56      $��
ACTUALISER��6,   $��5,5,5,5q�6A   �� 57      -   5        $ btn_modifier��57      $��MODIFIER��6+   $��5,5,5,5q�6>   58      59      5:      