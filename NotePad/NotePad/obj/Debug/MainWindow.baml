   M S B A M L   `   `   `  ����B  >NotePad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NotePadNotePad  5   	       NotePad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:NotePad     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�65    � Icon$ 	doge1.jpg��6N   .��5	      � .+�5   
   o� -   5         o�Name$
 menu��5      $	��Top=�6   $
��Left=�65    o� 
IsMainMenu .  $	��152��6z   $��14(�6�   .@�5      m� $
��File��6    m� Icon 5      �� 5      $7��1                 C:\Users\rresh\Desktop\doge1.jpg��6   5   5   .@�5      m� $��Create��6   .@�5      m� -   5         m�Name$ createButton��5      $��Are you sure?��65   6i   5      m� 5      -   5        $ 	newWindow��5      $��
New window��6.   5      �� 5      6   m� 5      -   5        $
 open��5      $
��Open��6)   5      m� 5      -   5        $
 save��5      $
��Save��6)   5      m� 5      -   5        $ saveAs��5   .   $��	Save as..��6   5       �� 5!      6   m� 5#      -   5        $
 exit��5#      $
��Exit��6)   67   5$      m� 5%      $
��Edit��6   .@�5&      m� -	   5        $ 	printDate��5&      $
��Date��6.   6V   m� 5'      -
   5        $
 time��5'      $
��Time��6)   6K   m� 5(      -   5        $ smile��5(      $��Smile��6*   6N   m� 5)      -   5        $��My phone number��5)      6M   5*      m� 5+      $��About��6   $��49��6&   .@�5,      �� $��
By rreshrr��6   $
��Left=�6-   ���	#FF255B156a   5-      5.      �� 5/   
   -   5         ��Name$
 text��5/      $
��Left=�6    $	��395��6;   $��0,24,0,0q�6H   	 �� TextWrapping$
	 Wrap=�6Z   $	��Top=�6o   $	��792��6�   $��14(�6�   52      53      