   
  
 
 
 ��}   	  
  ��}   
  
  ��}     
  ��}      2� �	�� � M N����  9    M Z���    S���     � �fL�  � �� � 9   M �����  �  M ����
 U �  �  	M ����� U �  �  
M ����� U �  �  M ����� U  ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC 1  {$CLEO}
0000:   
10@ = 8
10@ *= 2
10@ += 0x7DBCB0
11@ = 9
11@ *= 2
11@ += 0x7DBCB0
12@ = 10
12@ *= 2
12@ += 0x7DBCB0
13@ = 11
13@ *= 2
13@ += 0x7DBCB0
0@ = 0
while true
wait 50 ms
if and
    05EE: key_pressed 9
    80E0:   not player $PLAYER_CHAR driving 
    03EE:   player $PLAYER_CHAR controllable
then
    if 0039: 0@ == 0
    then
        0006: 0@ = 1
    else
        0006: 0@ = 0
    end
    wait 200 ms
end
05E0: 5@ = read_memory 0x00864C66 size 1 virtual_protect 1
      if and
      80E0:   not player $PLAYER_CHAR driving 
      03EE:   player $PLAYER_CHAR controllable
      0@ == 1 
      then
          if 
            00E1:   key_pressed 0 8
          then
          05DF: write_memory 10@ size 2 value 0x55 virtual_protect 0  
          end           
          
          if
            00E1:   key_pressed 0 9
          then
          05DF: write_memory 11@ size 2 value 0x55 virtual_protect 0  
          end  
          
          if
            00E1:   key_pressed 0 10
          then
          05DF: write_memory 12@ size 2 value 0x55 virtual_protect 0  
          end  
          
          if
            00E1:   key_pressed 0 11
          then
          05DF: write_memory 13@ size 2 value 0x55 virtual_protect 0  
          end  
      end
endS  __SBFTR 