   M S B A M L   `   `   `  ����Q  MYoutubeAudioDownloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:YoutubeAudioDownloaderYoutubeAudioDownloader  5   	   '    !YoutubeAudioDownloader.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:YoutubeAudioDownloader     5   	   ���	#FF01001F  � Title$  YoutubeAudioDownloader��5	   	   $	��450��6(   $	��800��65   .��5
      �  � RowDefinitions 5   
   �� 5      $
��400* �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��Scroll��5      $
��Auto=�6%   $��0��6H   .��5      � -   5        $
��Wrap��5       � Orientation$ Vertical=�6$   5      �� 5   
   $��Добавить��6   $��1��6H   $��
10,10,0,10q�6U   $
��Left=�6i   $��75��6�   ���	#FFB40000
���������6$   ��  �� Path$ 
AddCommand�6�   �� 5   
   $��Сохранить��6   $��1��6J   $��
0,10,10,10q�6W   $��Right=�6k   $��75��6�   ���	#FF00B419
���������6%   �� $ SaveCommand�6�   � 5   
   -   5        $��Progress��5       � Minimum$ 0Q�6K   $��117,10,117,10q�6W   ���	#FF000346$��1��6�    � Value 6&   �� $ ProgressValue�6�   5      5      