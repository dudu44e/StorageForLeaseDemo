   M S B A M L   `   `   `  ����J  FStorageForLease, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:StorageForLeaseStorageForLease  5   	   +    %StorageForLease.ManagerSignUpPagexaml   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:StorageForLease     5   	     � Title$  ManagerSignUpPagexaml��5   	   $	��695��6'   $	��500��64   
����  � � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 0q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   $	��164��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?    � �� �#EAB01E6S   �� 51   "   $ border��6@    � �� �#EAB01E6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?    � �� �#F1CA686S   �� 55   "   $ border��6@    � �� �#F1CA686T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8   � ��6i   5;      5=      5?      5@      5A      .��5C      �� 
�������$
 20��6    $��30q�62   ._�5D   
   �� $��20q�6   .+�5E      �� $��Manager Sign up��6   
���   �$��Center=�5G      $��25(�5H      $��Broadway)�5I      5J      �� 5L      6   �� 5M      $��Enter Your ID��6   $��Palatino Linotype)�6,   $��5 20 0 5q�6K   $��18(�6]   
���   �6�   �� 5N      -   5         ��Name$ ID��5N      $��18(�5O      $��Courier New)�5P      
���   ����	#FF7CCFCF5R      �� 5S      $��Username��6   $��5 20 0 5q�6(   $��18(�6:   
���   �$��Palatino Linotype)�6[   6|   �� 5T      -   5        $ Username��5T      $��18(�5U      $��Courier New)�5V      
���   ����	#FF7CCFCF5X      �� 5Y      $��Password��6   $��Palatino Linotype)�6'   $��5 20 0 5q�6F   $��18(�6X   
���   �6{   �� 5Z      -   5        $ Password��5Z      $��18(�5[      $��Courier New)�5\      
���   ����	#FF7CCFCF5_      �� 5`      $��Enter Your Email��6   $��Palatino Linotype)�6/   $��5 20 0 5q�6N   $��18(�6`   
���   �6�   �� 5a      -   5        $ Email��5a      $��18(�5b      $��Courier New)�5c      
���   ����	#FF7CCFCF5e      �� 5f      $��Authorization code��6   $��Palatino Linotype)�61   $��5 20 0 5q�6P   $��18(�6b   
���   �6�   �� 5g      -   5        $ AuthorizationCode��5g      $��18(�5h      $��Courier New)�5i      
���   ����	#FF7CCFCF5k      �� 5l      -   5         ��Name$ Signup��5l   =   #��� 
 6   $��30��5m      ���	#FF44C9B5$��Blackadder ITC)�5o      $��UltraCondensed&�5p      $��Sign up��5q      $��
60 20 60 0q�5r      5s      �� 5t      -   5        $ BackToMainPage��5t   =   #��� 
 6   $��30��5u      ���	#FF44C9B5$��Blackadder ITC)�5w      $��UltraCondensed&�5x      $��Back to Main Page��5y      $��
60 20 60 0q�5z      5{      5|      5}      5~      