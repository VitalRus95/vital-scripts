�	SNOW         �  V� M ���� �����  �
SNOWM ����  9   M 3���         A �D   
  p�  ��   

      	M �����
%Snow ~r~ON~s~ [Script by ~y~Vital~s~]� ���   �
Snow ~r~OFF��  9  M ����    J
  �   
 �    �>333? ���>   ? k   [   {    
 {    
 � 1�   
  �C!    
    1�   
   DM ����  !    
   �M ����?���>ff�? � � � >   
   
PAGE_00�  ����   A �D   
  p�  ��   

      	M ��� ����FLAG   SRC ]  {$CLEO} //  Script by Vital (Vitaly Pavlovich Ulyanov)
script_name 'SNOW'

const minStartX = 10.0
const maxStartX = 630.0
const minStartY = -15.0
const maxStartY = -350.0

int i
int snow = 0
float x[10]
float y[10]
float mx, my

while true
    wait 0
    
    if not Player.IsPlaying(0)
    then continue
    end
    
    if Pad.TestCheat("SNOW")
    then
        if snow == 0
        then
            snow = 1
            for i = 0 to 9
                x[i] = Math.RandomFloatInRange(minStartX, maxStartX)
                y[i] = Math.RandomFloatInRange(minStartY, maxStartY)
            end
            Text.PrintStringNow("Snow ~r~ON~s~ [Script by ~y~Vital~s~]", 3000)
        else
            snow = 0
            Text.PrintStringNow("Snow ~r~OFF", 3000)
        end
    end
    
    if snow == 1
    then
        for i = 0 to 9
            mx, my = Mouse.GetMovement()
            float s = Math.Sin(y[i])
            float ms = Math.Sin(mx)
            float r = Math.RandomFloatInRange(0.25, 0.7)
            float ySpeed = Math.RandomFloatInRange(0.3, 0.5)
            s *= r
            s += ms
            
            x[i] +=@ s
            y[i] +=@ ySpeed
            
            if and
                y[i] < 448.0
                x[i] > 0.0
                x[i] < 640.0
            then
                if y[i] > -10.0
                then
                    Text.UseCommands(true)
                    Text.SetScale(0.4, 1.8)
                    Text.SetDropshadow(1, 0, 148, 255, 150)
                    Text.Display(x[i], y[i], "PAGE_00")
                    Text.UseCommands(false)
                end
            else
                x[i] = Math.RandomFloatInRange(minStartX, maxStartX)
                y[i] = Math.RandomFloatInRange(minStartY, maxStartY)
            end
        end
    end
end4  __SBFTR 