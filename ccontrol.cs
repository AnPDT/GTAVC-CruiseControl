   
�  �tM ���� � �
CRUISE CONTROL ACTIVATED�  
�  �tM ���� � �
CRUISE CONTROL DEACTIVATED�  ����� V �  M �����      �A'  �            �  z M ���� 
�  �1M ���� �  �tM ���� � � �
CRUISE CONTROL DEACTIVATED�  �����  ۀ  M �����  ���� )��� #���;   M #��� 
�  �tM M��� � � �
CRUISE CONTROL DEACTIVATED�  �����  �1M 9���� �  ۀ  M ����  ����'  �  �� M ����     @ � �  �� M �����  !     @M ����     � � �  �	M }����  9   M ����     ����    � �  �  !   M [���  � �  9  M <���   �  �  M $��� ���   �     �    c   �  Ʉ M ����� !     @#    � M ���� #���� 9  9  M *���� �  
�  M ����   *���� 9  9  M 2���!   M @���     �?�   l���    *����   �����  ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$CLEO .cs}
0000:
:mod_activate
wait 10 ms
if 05EE: key_pressed 116
jf @mod_activate
wait 200 ms
0AD1: show_formatted_text_highpriority "Cruise Control Activated" time 1000
:char_activity
wait 10 ms
if 05EE: key_pressed 116 
then
    wait 200 ms
    0AD1: show_formatted_text_highpriority "Cruise Control Deactivated" time 1000
    jump @mod_activate
end
if and
    0256: player $PLAYER_CHAR defined    
    00DF: actor $PLAYER_ACTOR in_any_car
jf @char_activity
03C0: 1@ = actor $PLAYER_ACTOR car
0007: 2@ = 20.0 //default speed
0227: 3@ = car 1@ health
0085: 4@ = 3@
0006: 5@ = 0
0006: 7@ = 0
0006: 8@ = 0
if 047A: actor $PLAYER_ACTOR on_any_bike
then
    while true
        wait 10 ms
        if 05EE: key_pressed 49
        then 02D4: car 1@ turn_off_engine
        end
        if 05EE: key_pressed 116
        then
            wait 200 ms        
            01C3: remove_references_to_car 1@
            0AD1: show_formatted_text_highpriority "Cruise Control Deactivated" time 1000
            jump @mod_activate
        end
        if 80DB: not actor $PLAYER_ACTOR in_car 1@
        then        
            01C3: remove_references_to_car 1@
            jump @char_activity
        end
    end
else    
    while 003B: 4@ == 3@
        wait 10 ms
        if 05EE: key_pressed 116
        then
            wait 200 ms        
            01C3: remove_references_to_car 1@
            0AD1: show_formatted_text_highpriority "Cruise Control Deactivated" time 1000
            jump @mod_activate
        end
        if 05EE: key_pressed 49
        then 02D4: car 1@ turn_off_engine
        end
        if 80DB: not actor $PLAYER_ACTOR in_car 1@
        then        
            01C3: remove_references_to_car 1@
            jump @char_activity
        end
        0227: 4@ = car 1@ health
        if 05EE: key_pressed 187 
        then
            000B: 2@ += +2.5
            wait 200 ms
        end
        if 05EE: key_pressed 189
        then
            if 0021: 2@ > 2.5 
            then 
                000B: 2@ += -2.5 
            end
            wait 200 ms
        end
        if 05EE: key_pressed 9 
        then
            if 0039: 5@ == 0 
            then
                0006: 5@ = 1
                0006: 7@ = 1
            else 
                0006: 5@ = 0 
            end
            wait 200 ms
        end
        02E3: 6@ = car 1@ speed
        if 0021: 6@ > 2@ 
        then 
            0006: 8@ = 1 
        end
        if and
            00E1: key_pressed 0 14
            0039: 5@ == 1
        then 
            0006: 5@ = 0 
        end    
        if 00E1: key_pressed 0 16
        then
            // nothing to do
        else 
            0006: 8@ = 0 
        end    
        00A0: store_actor $PLAYER_ACTOR position_to 15@ 16@ 17@ 
        02CE: 14@ = ground_z_at 15@ 16@ 17@ 
        0063: 14@ -= 17@ // (float)
        if 84C9:   not player $PLAYER_CHAR in_flying_vehicle 
        then
            if or
                0021:   14@ > 2.5 
                0023:   -2.5 > 14@ 
            then
                break
            end
        end    
        if or 
            0039: 8@ == 1
            0039: 5@ == 1
        then
            if or
                00E1: key_pressed 0 10
                00E1: key_pressed 0 11
            then 
                0006: 7@ = 1
            else
                if and
                    0039: 7@ == 1
                    0039: 5@ == 1
                then
                    while 0021: 2@ > 6@
                        wait 20 ms
                        000B: 6@ += +1.0
                        04BA: set_car 1@ speed_to 6@
                    end
                    0006: 7@ = 0
                else 
                    04BA: set_car 1@ speed_to 2@ 
                end
            end
        end 
    end
end
01C3: remove_references_to_car 1@
jump @char_activity�  __SBFTR 