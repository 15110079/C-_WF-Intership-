   M S B A M L   `   `   `  ����A  =Aikido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AidikoMemberManagement.ViewAidikoMemberManagement.View  5   	   )    #AidikoMemberManagement.View.Menubar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AidikoMemberManagement.View     5   	     � Title$  Menubar��5   	   $	��663��6   $	��800��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   .��5	      � $��60��6   $��Center=�6   $	��Top=�64   $��0,0,0,0q�6L   $	��780��6]    � ColumnDefinitions 5
   
   �� 5      �� 5      $
��155* �6   .+�5   
   �� -   5        $��btnDKHV��5   $   $��
0,0,610,10q�6   $��Đăng Ký Hội Viên��5      
�������
����  �$��Arial)�5      $��15(�6/   $��Normal$�6I   $
��Bold"�6h   $��Center=�5      $��Center=�64   $��2��6V   5      �� 5   
   -   5        $��	btnSearch��5   *   $��165.493,0,450,10q�6   $��Tìm Kiếm��5      
�������
����  �$��Arial)�5      $��15(�6/   $��Normal$�6I   $��Center=�5      $��Center=�64   $
��Bold"�6V   $��1��6t   5      �� 5   
   -   5        $��btnQLHP��5   *   $��325.493,0,292,10q�6   $��Quản Lý Hội Phí��5!      
�������
����  �$��Arial)�5"      $��15(�6/   $��Normal$�6I   $��Center=�5#      $��Center=�64   $
��Bold"�6V   $��1��6t   5%      �� 5'   
   -   5        $��btnQLL��5'   *   $��483.493,0,120,10q�6   $��Quản Lý Lớp��5)      
�������
����  �$��Arial)�5*      $��15(�6/   $��Normal$�6I   $��Center=�5+      $��Center=�64   $
��Bold"�6V   $��1��6t   5-      �� 5/   
   -   5        $��btnTL��5/   (   $��655.493,0,0,10q�6   $��Thiết Lập��51      
�������
����  �$��Arial)�52      $��15(�6/   $��Normal$�6I   $��Center=�53      $��Center=�64   $
��Bold"�6V   $��1��6t   55      �� 57   
   -   5         ��Name$ 
btnSearchQ��57   *   $��165.493,0,548,10q�6   $��Nhanh��59      
�������
����  �$��Arial)�5:      $��15(�6,   $��Normal$�6F   $��Center=�5;      $��Center=�61   $
��Bold"�6S   $��1��6q   �� 5=   
   -   5        $ 
btnSearchC��5=   *   $��227.493,0,450,10q�6   $��Điều kiện��5?      
�������
����  �$��Arial)�5@      $��15(�6,   $��Normal$�6F   $��Center=�5A      $��Center=�61   $
��Bold"�6S   $��1��6q   �� 5C   
   -   5        $��btnDKHVb��5C   %   $��0,45,610,10q�6   $��2��65   5E      �� 5G   
   -	   5        $��
btnSearchb��5G   +   $��165.493,45,450,10q�6   $��1��6=   5I      �� 5K   
   -
   5        $��btnQLHPb��5K   +   $��325.493,45,292,10q�6   $��1��6;   5M      �� 5O   
   -   5        $��btnQLLb��5O   +   $��483.493,45,120,10q�6   $��1��6:   5Q      �� 5S   
   -   5        $��btnTLb��5S   )   $��655.493,45,0,10q�6   $��1��67   5U      � 5W   
   -   5        $��ScreenRegisterMember��5W      $��-5,75,-5,-410q�6+   $y�Hidden=�6B   $��2��6V   .+�5X      �� $��
0,0,0,-164q�6   .��5Y      �� $	��799��6   .+�5Z      � $	��554��6   .+�5[      �� $��Center=�6    $	��Top=�6=   $��HỒ SƠ HỌC VIÊN��6U   $��Arial)�6n   $��20(�6�   $
��Bold"�6�   6�   �� 5\      $	��SKU��6!   $
��Left=�6/   $��Center=�6J   $��45��6n   $��10,40,0,-40q�6y   �� 5]      -   5        $��txtSKU��5]   "   $
��Left=�60   $��25��6K   $��100,40,0,-35q�6W   $��Center=�6m    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��270��6�   �� 5^      $��Số Đăng Ký��6    $
��Left=�65   $��85��6P   $��394,40,0,-40q�6[   �� 5_      -   5        $��txtSDK��5_   "   $
��Left=�60   $��25��6K   $��468,40,0,-35q�6W   $��Center=�6m   $
 Wrap=�6�   $	��Top=�6�   $	��270��6�   �� 5`      $��	Họ Tên��6    $
��Left=�61   $��57��6L   $��10,70,0,-73q�6W   �� 5a      -   5        $��txtName��5a   "   $
��Left=�61   $��25��6L   $��100,70,0,-68q�6X   $��Center=�6n   $
 Wrap=�6�   $	��Top=�6�   $	��270��6�   �� 5b      $��Quốc Tịch��6    $
��Left=�64   $��85��6O   $��394,70,0,-73q�6Z   �� 5c      -   5        $��	txtNation��5c   "   $
��Left=�63   $��25��6N   $��468,70,0,-68q�6Z   $��Center=�6p   $
 Wrap=�6�   $	��Top=�6�   $	��270��6�   �� 5d      $��Địa Chỉ��6    $
��Left=�62   $��57��6M   $��10,100,0,-106q�6X   �� 5e      -   5        $��
txtAddress��5e   "   $
��Left=�64   $��25��6O   $��100,100,0,-101q�6[   $��Bottom=�6s   $
 Wrap=�6�   $	��Top=�6�   $	��635��6�   �� 5f      $��Số Điện Thoại��6    $
��Left=�68   $��90��6S   $��10,130,0,-139q�6^   �� 5g      -   5        $��txtPhone��5g   "   $
��Left=�62   $��25��6M   $��100,130,0,-134q�6Y   $��Bottom=�6q   $
 Wrap=�6�   $	��Top=�6�   $	��270��6�   (  "System.Windows.Controls.DatePicker  5h      -   5        $��dtpRegisterDay��5h   &   $
��Left=�6<   $��25��6W   $��265,160,0,0q�6c   $	��Top=�6x   $	��494��6�   �� 5i      $��Ngày Đăng Ký��6    $
��Left=�67   $��90��6R   $��170,160,0,-173q�6]     5j      -   5        $��dtpBirthday��5j   %   $
��Left=�68   $��25��6S   $��265,190,0,-201q�6_   $	��Top=�6w   $	��494��6�   �� 5k      $��
Ngày Sinh��6    $
��Left=�64   $��90��6O   $��170,190,0,-206q�6Z   �� 5l      -   5        $��txtBirthplace��5l   "   $
��Left=�67   $��25��6R   $��265,220,0,-234q�6^   $	��Top=�6v   $
 Wrap=�6�   $	��Top=�6�   $	��494��6�   �� 5m      $��	Nơi Sinh��6    $
��Left=�63   $��90��6O   $��170,220,0,-239q�6Z   �� 5n      $��Lớp Đăng Ký��6    $
��Left=�66   $��90��6Q   $��170,250,0,-272q�6\   �� 5o      -   5        $��cboRegisterClass��5o   #   $
��Left=�6;   $��25��6V   $��265,250,0,-267q�6b   $	��Top=�6z   $	��494��6�   �� 5p      $
��Left=�6"   $	��120��6=   $��40,160,0,-272q�6J   $	��Top=�6a   $	��100��6y   �� 5q      $��CẤP 6��6    $
��Left=�60   $��45��6K   $��10,290,0,-350q�6V     5r      $
��Left=�6%   $��25��6@   $��55,290,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5s      $��CẤP 5��6    $
��Left=�60   $��45��6K   $��10,320,0,-350q�6V     5t      $
��Left=�6%   $��25��6@   $��55,320,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5u      $��CẤP 4��6    $
��Left=�60   $��45��6K   $��10,350,0,-350q�6V     5v      $
��Left=�6%   $��25��6@   $��55,350,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5w      $��CẤP 3��6    $
��Left=�60   $��45��6K   $��10,380,0,-350q�6V     5x      $
��Left=�6%   $��25��6@   $��55,380,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5y      $��CẤP 2��6    $
��Left=�60   $��45��6K   $��10,410,0,-350q�6V     5z      $
��Left=�6%   $��25��6@   $��55,410,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5{      $��CẤP 1��6    $
��Left=�60   $��45��6K   $��10,440,0,-350q�6V     5|      $
��Left=�6%   $��25��6@   $��55,440,0,-350q�6L   $	��Top=�6c   $	��705��6{   �� 5}      $��I DAN VN��6    $
��Left=�63   $��71��6N   $��10,470,0,-527q�6Y     5~      $
��Left=�6%   $��25��6@   $��86,470,0,-522q�6L   $	��Top=�6c   $	��273��6{   �� 5      $��	II DAN VN��6    $
��Left=�64   $��71��6O   $��10,500,0,-560q�6Z     5�      $
��Left=�6%   $��25��6@   $��86,500,0,-555q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��
III DAN VN��6    $
��Left=�65   $��71��6P   $��10,530,0,-593q�6[     5�      $
��Left=�6%   $��25��6@   $��86,530,0,-588q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��	IV DAN VN��6    $
��Left=�64   $��71��6O   $��10,560,0,-626q�6Z     5�      $
��Left=�6%   $��25��6@   $��86,560,0,-621q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��V DAN VN��6    $
��Left=�63   $��71��6N   $��10,590,0,-659q�6Y     5�      $
��Left=�6%   $��25��6@   $��86,590,0,-654q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��	VI DAN VN��6    $
��Left=�64   $��71��6O   $��10,620,0,-692q�6Z     5�      $
��Left=�6%   $��25��6@   $��86,620,0,-688q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��
VII DAN VN��6    $
��Left=�65   $��71��6P   $��10,650,0,-725q�6[     5�      $
��Left=�6%   $��25��6@   $��86,650,0,-720q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��VIII DAN VN��6    $
��Left=�66   $��76��6Q   $��10,680,0,-758q�6\     5�      $
��Left=�6%   $��25��6@   $��86,680,0,-753q�6L   $	��Top=�6c   $	��273��6{   �� 5�      $��I DAN AIKIDAI��6    $
��Left=�68   $	��100��6S   $��388,470,0,-527q�6_     5�      $
��Left=�6%   $��25��6@   $��488,470,0,-522q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��II DAN AIKIDAI��6    $
��Left=�69   $	��100��6T   $��388,500,0,-560q�6`     5�      $
��Left=�6%   $��23��6@   $��488,500,0,-555q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��III DAN AIKIDAI��6    $
��Left=�6:   $	��100��6U   $��388,530,0,-593q�6a     5�      $
��Left=�6%   $��23��6@   $��488,530,0,-588q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��IV DAN AIKIDAI��6    $
��Left=�69   $	��100��6T   $��388,560,0,-626q�6`     5�      $
��Left=�6%   $��23��6@   $��488,560,0,-621q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��V DAN AIKIDAI��6    $
��Left=�68   $	��100��6S   $��388,590,0,-659q�6_     5�      $
��Left=�6%   $��23��6@   $��488,590,0,-654q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��VI DAN AIKIDAI��6    $
��Left=�69   $	��100��6T   $��388,620,0,-692q�6`     5�      $
��Left=�6%   $��23��6@   $��488,620,0,-687q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��VII DAN AIKIDAI��6    $
��Left=�6:   $	��100��6U   $��388,650,0,-725q�6a     5�      $
��Left=�6%   $��23��6@   $��488,650,0,-720q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $��VIII DAN AIKIDAI��6    $
��Left=�6;   $	��100��6V   $��388,680,0,-758q�6b     5�      $
��Left=�6%   $��23��6@   $��488,680,0,-753q�6L   $	��Top=�6d   $	��273��6|   �� 5�      $
��Lưu��6!   $
��Left=�6/   $��30��6J   $��260,730,0,-808q�6V   $	��Top=�6n   $��96��6�   �� 5�      $��Print��6!   $��Right=�61   $��30��6M   $��0,730,260,-808q�6Y   $	��Top=�6q   $��96��6�   5�      5�      5�      5�      � 5�   
   -   5        $��ScreenSearchNhanh��5�      $��0,75,0,-568q�6(   $y�Hidden=�6=   $��2��6Q   .+�5�      �� $��Search Nhanh��6   $
��Bold"�6-   $��Arial)�6K   $��16(�6j   .��5�      � $	��350��6   $	��Top=�6$   $
��Left=�6<   $	��782��6W   $��Normal"�6c   $��15(�6�   .+�5�      �� $��Tìm Kiếm��6   $��
9,16,0,311q�6/   �� 5�      $
��Left=�6   $��Center=�6@   $��100,9,350,313q�6b   $��25��6y   �� 5�      $��Tìm Kiếm��6   $��8,51,680,269q�60   �� 5�      $��Xuất File��6   $��150,51,550,268q�61   &   System.Windows.Controls.DataGrid  5�      -   5        $��
dgvSearchQ��5�      $
��Left=�61   $	��402��6L   $��10,99,0,-151q�6Y   $	��Top=�6o   $	��762��6�   
�������   RowBackground
 �����   AlternatingRowBackground
 �����   SelectionMode$ Extended=�6�   5�      5�      5�      � 5�   
   -   5        $��ScreenSeachCondition��5�      $��0,75,0,-568q�6+   $y�Hidden=�6@   $��2��6T   .+�5�      �� $ ��Search Theo Điều Kiện��6   $
��Bold"�66   $��Arial)�6T   $��16(�6s   .��5�      � $	��350��6   $	��Top=�6$   $
��Left=�6<   $	��782��6W   $��Normal"�6c   $��15(�6�   .+�5�      �� $	��SKU��6   $��10,10,713,310q�6*   �� 5�      $
��Left=�6   $��Center=�6@   $��72,10,428,317q�6b   $��25��6y   �� 5�      $��	Họ Tên��6   $��10,47,710,279q�6-   �� 5�      $
��Left=�6   $��Bottom=�6@   $��72,47,428,278q�6b   $��25��6y   �� 5�      $��Ngày Đăng Ký��6   $��392,5,295,320q�63     5�      $
��Left=�6!   $��	492,5,0,0q�6<   $	��Top=�6O   $	��280��6g   $��25��6s   �� 5�      $��
Ngày Sinh��6   $��392,47,294,277q�60     5�      $
��Left=�6!   $��
492,47,0,0q�6<   $	��Top=�6P   $	��280��6h   $��25��6t   �� 5�      $��Tìm Kiếm��6   $��10,87,698,235q�60   �� 5�      $��Xuất File��6   $��103,87,604,234q�61     5�      -   5        $��
dgvSearchC��5�      $
��Left=�61   $	��403��6L   $��10,134,0,-187q�6Y   $	��Top=�6p   $	��762��6�   
�������
 �����
 �����$ Extended=�6�   5�      5�      5�      � 5�   
   -   5        $��	ScreenFee��5�      $��0,75,0,-568q�6    $y�Hidden=�65   $��2��6I   .+�5�      �� $'��!Quản Lý Hội Phí Hội Viên��6   $��Center=�6;   $��Center=�6_   $��Arial)�5�      $��15(�66   $��Normal$�6P   $
��Bold"�6o   .��5�      � $��Normal"�6   .+�5�      �� $��Class��6   $��	30,20,0,0q�6,   $
��Left=�6?   $��50��6Z   $��30��6e   $��Center=�6q   $	��Top=�6�   $��Arial)�6�   $��15(�6�   6�   �� 5�      $	��200��6   $��25��6+   $��
100,20,0,0q�67   $
��Left=�6K   $	��Top=�6f   
�������
����  �6�     5�      -   5        $��dgvFee��5�      $��10,60,10,60q�6-   $��Center=�6B   
�������
 �����
 �����$ Extended=�5�   a   $��Arial)�5�      $��15(�62   $��Normal$�6L   5�      �� 5�      $��Export��6   $��Center=�6.   $��Bottom=�6K   $	��100��6f   $��30��6r   $��0,0,0,10q�6~   $��Arial)�5�      $��15(�64   $��Normal$�6N   $
��Bold"�6m   
���   �6�   5�      5�      5�      � 5�   
   -   5        $��ScreenClass��5�      $��0,75,0,-568q�6"   $y�Visible=�67   $��2��6L   .+�5�      �� $��Quản Lý Lớp��6   $��Arial)�6,   $��16(�6K   $
��Bold"�6e   .��5�      � $	��543��6   $	��Top=�6$   $
��Left=�6<   $	��782��6W   $��15(�6c   $��Normal"�6}   $��0,0,-14,-16q�6�   .+�5�        -   5        $��dgvClass��5�   G   $
��Left=�6   $	��453��6:   $��	10,20,0,0q�6W   $	��Top=�6j   $	��755��6�   
�������
 �����
 �����$ Extended=�5�   m   �� 5�      -    5        $��btnSaveC��5�      $
��Lưu��6-   $��Right=�6;   $��Bottom=�6W   $��30��6r   $	��100��6~   $��	0,0,50,25q�6�   6�   �� 5�      -!   5        $��	btnDelete��5�      $��-��6.   $
��Left=�6:   $��Bottom=�6U   $��30��6p   $��30��6|   $��170,0,50,25q�6�   6�   �� 5�      -"   5        $��btnAdd��5�      $��+��6+   $
��Left=�67   $��Bottom=�6R   $��30��6m   $��30��6y   $��100,0,50,25q�6�   6�   5�      5�      5�      � 5�   
   -#   5        $��ScreenSetting��5�      $��0,75,0,-346q�6$   $y�Hidden=�69   $��2��6M   .+�5�      �� $��Thiết Lập��6   $��
0,0,0,-217q�6*   $
��Bold"�6>   $��15(�6\   $��Arial)�6v   .��5�      � $��Normal"�6   $��15(�67   .+�5�      �� $4��.Chọn ảnh nền khi in hồ sơ hội viên��6   $��15(�6I   $��Italic$�6c   $��	60,10,0,0q�6�   6�   �� 5�      $	��300��6   $	��382��6)   $
��Left=�66   $	��Top=�6Q   $��	40,40,0,0q�6i   6~   �� 5�      -$   5        $��checkboxDefault��5�      $��30��66   $��30��6A   $��35,400,650,0q�6M   6e   �� 5�      $	��140��6   $��40��6(   $��Mặc định��64   $��75,400,540,0q�6G   6_   �� 5�      -%   5        $��btnSave��5�      $��70��6,   $��35��67   $
��Lưu��6C   $
��Left=�6Q   $��Bottom=�6l   $��
150,0,0,10q�6�   $
��Bold"�6�   6�   5�      5�      5�      5�      5�      