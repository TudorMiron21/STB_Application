   M S B A M L   `   `   `  ????B  >STB_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:STB_AppSTB_App  5   	       STB_App.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:STB_App  5   	   -   5          ? WindowStyle$
  None=?5	   	    ? AllowsTransparency . 
??????  ? Title$ 
MainWindow??5   	   $	??547??5   	   $	??963??5   	   .??5      ?? -   5         ??Name$ 	BorderImg??5       ?? CornerRadius$ 30??5      ??5   
   ?? 5       ?? ImageSource$ Images\loginImg.png??6    j? Stretch$ UniformToFill=?5       j? 
AlignmentY$	 Top=?5      ._?5   
   ?? $ 30??6   ??5      ?? 5       ?? Color$ 	#FF62704D??6"   	 ?? Opacity$		 0.9Q?5    "   ._?5"      ? 
 ? RowDefinitions
 5#      ?? 5$      $??25 ?6%   ?? 5&      $	??500 ?6$   ?? 5'      $??* ?6$   .+?5*      ??  ?? Orientation$ Vertical=?6   $	??Top=?5+      $??1??5,      $	??500??5-      $??232,50,231,0q?5.      $	??450??5/      .+?50      ?? $ 
Horizontal=?6!   $	??Top=?51   !   $??Center=?52   !   .+?54      ?? $??Username??6$   
???????$??15(?56   $   $??	10,15,0,0q?57   $   ?? 58      -   5         ??Name$ Username??58   "   $??30??59   "   $	??200??5:   "   
???????$??15,5,0,5q?5<   "   $??15(?5=   "   5>   "   5?      ?? 5A      .+?5B      ?? -   5         ??Name$ 	userError??5B   $   $??Username-ul exista deja!??5C   $   $??9(?5D   $   ???	#FFF9D31B$??Center=?5F   $   $??60,2,0,0q?5G   $   $y?Hidden=?5H   $   5I      ?? 5J      $ 
Horizontal=?6!   $??52??5K   !   $	??333??5L   !   .+?5M      ?? $??Parola??6$   
???????$??15(?5O   $   $??	55,10,0,5q?5P   $   $??23??5Q   $   ?? 5R      .+?5S      G? -   5         G?Name$ Password??5T   *    /  +MaterialDesignFloatingHintRevealPasswordBox#??[  5S   *   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   
Background
 ?   ?)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Password??5V   *   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $??35??5X   *   $	??200??5Y   *   $??	18,0,10,5q?5Z   *   
???????4  .System.Windows.Automation.AutomationProperties   IsColumnHeader . 5^   *   ?? 5`      .+?5a   "   ?? -   5        $ 	passError??5a   ,   $??Cel putin 8 caractere!??5b   ,   $??9(?5c   ,   ???	#FFF9D31B$y?Hidden=?5e   ,   $??50,0,0,5q?5f   ,   5g      5j      5l      ?? 5n      $ 
Horizontal=?6!   $??Center=?5o   !   $	??315??5p   !   $??0,5,0,0q?5q   !   .+?5s      ?? $
??Nume??6$   
???????$??15(?5u   $   $??	45,10,5,5q?5v   $   ?? 5w      -   5        $
 Nume??5w   "   $??30??5x   "   $	??200??5y   "   $??15(?5z   "   $??15,5,0,5q?5{   "   
???????5}   "   5~      ?? 5      $ 
Horizontal=?6!   $??Center=?5?   !   $??42??5?   !   $	??294??5?   !   .+?5?      ?? $??Prenume??6$   
???????$??15(?5?   $   $??	17,12,0,0q?5?   $   ?? 5?      -   5        $ Prenume??5?   "   $??30??5?   "   $	??200??5?   "   $??15(?5?   "   
???????$??20,5,0,5q?5?   "   5?      ?? 5?      $ 
Horizontal=?6"   $??73??5?   "   $	??320??5?   "   .+?5?      ?? $??	Categorie??6$   
???????$??15(?5?   $   $??	20,20,0,0q?5?   $   ?? 5?      -	   5         ??Name$ Category??5?   #    " MaterialDesignOutlinedComboBox#??[ 5?   #   $ Selecteaza o categorie...??5?   #      
Foreground
 ????? . $??50??5?   #   
???   ?$	??200??5?   #   $??25,0,0,0q?5?   #   ??5?   #   ?? *ShortStringList+.@?5?      ?? $??Student??6+   ?? 5?      $
??Elev??6+   ?? 5?      $??Adult??6+   ?? 5?      $??Copil??6+   ?? 5?      $??	Pensionar??6+   5?      5?      ?? 5?      $ 
Horizontal=?6!   $??Center=?5?   !   $	??334??5?   !   .+?5?      ?? $??Numar Telefon??6$   
???????$??15(?5?   $   $??0,6,12,0q?5?   $   ?? 5?      -
   5        $ Telefon??5?   "   $??30??5?   "   $	??200??5?   "   $??15(?5?   "   
???????$??5,5,5,5q?5?   "   5?   "   5?      ?? 5?      $ 
Horizontal=?6!   $??Center=?5?   !   $	??333??5?   !   .+?5?      ?? $??Email??6$   
???????$??15(?5?   $   $??	60,15,0,5q?5?   $   ?? 5?      -   5        $ Email??5?   "   $??30??5?   "   $	??200??5?   "   $??15(?5?   "   
???????$??20,5,0,5q?5?   "   5?   "   5?      ?? 5?      -   5         ??Name$ register??5?      $??Register??5?      $	??180??5?      $??30??5?      
??? E?? J? Opacity$	 0.9Q?5?      $??0,50,0,0q?5?      ??5?      ?? 5?       ?? 
TargetType" ??6.   .R?5?   "   ?? $ border??6)   
???????
???   ?$??1q?5?   )   $ 10??5?   )   ._?5?   &   ?? $??Register??67   $??Center=?5?   7   $??Center=?5?   7   5?   #    ?? Triggers 5?   "   P? 5?   &    P? Property ?@J?IsMouseOver P? Value . . ?5?   *   ??  ?? 
TargetName$ border??61    ?? Property ? ?? ?? Value
 ? ???5?   1   5?   '   P? 5?   &    ? ?? . . ?5?   *   ?? $ border??61    ? ??
 ?? ??5?   1   5?   '   5?      5?      5?      ?? 5     $ 
Horizontal=?6   $??Right=?5     .+?5     ?? -   5        $ minimize??5     $
??____??5     $??20??5     $??20??5     $??0,5,10,0q?5     
??? ?????5
     ?? 5     " ??6.   .R?5  "   ?? $ 10??6)   
??? ???5  #   5     5     ?? 5     -   5        $ close??5     $??Close??5     $??20??5     $??20??5     $??0,5,20,0q?5     ??5     ?? 5     " ??6.   .R?5  "   ?? $ border??6)   $ 10??5  )   
???  ??5  #    5  "   P? 5  &    ?@J?IsMouseOver . . ?5!  *   ?? $ border??61    ? ??
 ? E??5#  1   5$  '   5&     5*     5+     ?? 5.     $ 
Horizontal=?6   $??2??5/     52     54     57     59     