   M S B A M L   `   `   `  ���� Q  MYoutubeAudioDownloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:YoutubeAudioDownloaderYoutubeAudioDownloader  '    !YoutubeAudioDownloader.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:YoutubeAudioDownloader     ���	#FF01001F  � Title$  YoutubeAudioDownloader��$	��450��$	��800��.���  � RowDefinitions �� $
��400* ��� $��50 �.+��� -   $��Scroll��$
��Auto=�$��0��.��� -   $
��Wrap�� � Orientation$ Vertical=��� $��Добавить��$��1��$��
10,10,0,10q�$
��Left=�$��75�����	#FFB40000
�����������  �� Path$ 
AddCommand��� $��Сохранить��$��1��$��
0,10,10,10q�$��Right=�$��75�����	#FF00B419
����������� $ SaveCommand�� -   $��Progress�� � Minimum$ 0Q�$��117,10,117,10q����	#FF000346$��1�� � Value �� $ ProgressValue�