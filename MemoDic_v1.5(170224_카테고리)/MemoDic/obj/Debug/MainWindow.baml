   M S B A M L   `   `   `  ����B  >MemoDic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MemoDicMemoDic  5   	   D @SSLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:SSLibrary;assembly=SSLibrary	SSLibrary 5   	       MemoDic.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MemoDic     5   	   @	SSLibrary*clr-namespace:SSLibrary;assembly=SSLibrary     5   	   -   5          �Name$  
MW_MemoDic��5   	    � Title$ MemoDic��5	   	   $	��350��6   $	��525��6&   .��5
      � .+�5   
   �� -   5         ��Name$ TB_ID��5      $
��Left=�6!   $��23��6<   $��	10,11,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��144��6�    �� 	MaxLength$ 10��6�   6�   �� 5   
    J� IsHitTestVisible .  $	�� ID��6-   $	��Top=�68   $
��Left=�6P   
���������6k   �� *Margin+ �� ElementName$ TB_ID����5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y�	 �� Value$	 	Collapsed=�63   
 �� Triggers
 5      �� 5       �� Binding 6&   �� *Text+$ TB_ID�� �� Value  6R   .a�5      ��  � y�$	 Visible=�6;   5      5      5      G� 5   
   -   5         G�Name$ PB_PW��5      $
��Left=�6%   $��	10,34,0,0q�6@   $	��Top=�6S   $	��144��6k   $��23��6�   6�   �� 5   
   -   5         ��Name$ TBL_PW��5       .  $	�� PW��6=   $	��Top=�6H   $
��Left=�6`   
���������6{   �� *Margin+$ PB_PW��6�   �� 5   
   -   5         ��Name$ CHB_Remember_me��5      $��Remember me��6,   $
��Left=�6B   $��23��6]   $��	10,63,0,0q�6i   $	��Top=�6|   $	��101��6�   ���	#CC000000 � Cursor$
 Hand��6�   
�������6�   �� 5   
   -   5         ��Name$ 	BTT_Login��5      $��Login��6$   $
��Left=�64   $��47��6O   $��
165,10,0,0q�6[   $	��Top=�6o   $��86��6�   $��1q�6�   $��14(�6�   �� 5   
   -   5        $ TB_RegisterID��5      $
��Left=�6)   $��23��6D   $��
114,62,0,0q�6P   $
 Wrap=�6d   $��Register ID��6x   $	��Top=�6�   $��67��6�   $��0q�6�   ���	#CC000000$
 Hand��6�    �� 
IsReadOnly . 6E  �� 5   
   -   5        $ 	TB_FindPW��5      $
��Left=�6%   $��23��6@   $��
183,62,0,0q�6L   $
 Wrap=�6`   $��Find PW��6t   $	��Top=�6�   $��70��6�   $��0q�6�   ���	#CC000000$
 Hand��6�    . 6U    SSLibrary.CHBTRV  5   
   -	   5        $��CHBTRV_CHBTreeView��5      $	��Top=�65   $��
250,30,0,0q�6M   $	��200��6a   $	��200��6m   �� 5    
   -
   5        $ BTT_Add��5       $	��Add��6"   $
��Left=�60   $��284,235,0,0q�6K   $	��Top=�6`   $��74��6x   6�   �� 5!   
   -   5        $ 
BTT_Delete��5!      $��Delete��6%   $
��Left=�66   $��410,235,0,0q�6Q   $	��Top=�6f   $��74��6~   6�   �� 5#   
   -   5        $ checkBox��5#      $
��Left=�6%   $��111,176,0,0q�6@   $	��Top=�6U   .��5$      �� .+�5%      �� $
��Left=�6   $��15��63   $��15��6>   $
��Fill=�6J   $��0,0,0,0q�6Y   $��Images/File.png��6j   �� 5&      $
��Left=�6   $��
20,-15,0,0q�67   Hi5(      5)      5*      5+      5,      