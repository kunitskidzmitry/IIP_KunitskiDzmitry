   M S B A M L   `   `   `  ����G  Cbankrekening, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:bankrekeningbankrekening  5   	       bankrekening.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:bankrekening     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Het beginsaldo:��6   $
��Left=�69   $��	55,76,0,0q�6T   $	��Top=�6g   $	��116��6   �� 5   
   -   5         ��Name$ txtBeginSaldo��5      $
��Left=�6)   $��23��6D   $��
176,79,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ label1��5      $��Het aantal jaren:��6    $
��Left=�6<   $��
55,130,0,0q�6W   $	��Top=�6k    J� RenderTransformOrigin$ 0.816,-0.029&�6�   $	��116��6�   �� 5   
   -   5        $ txtAantaalYaren��5      $
��Left=�6+   $��23��6F   $��176,134,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ label2��5      $��De rente per yaar��6    $
��Left=�6<   $��
55,180,0,0q�6W   $	��Top=�6k   $	��116��6�   �� 5   
   -   5        $ txtRente��5      $
��Left=�6$   $��23��6?   $��176,192,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5         ��Name$ btnBerekenen��5      $��	Berekenen��6'   $
��Left=�6;   $��200,240,0,0q�6V   $	��Top=�6k   $��96��6�   ���	#FF0E0707
���   ����	#FF5BE9ED6�   �� 5   
   -   5        $ 	lblResult��5      $�� ��6#   $
��Left=�6.   $��
71,349,0,0q�6I   $	��Top=�6]   $	��225��6u   5      5      