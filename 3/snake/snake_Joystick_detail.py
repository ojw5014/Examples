from pycm import *
import time
import math

_RATIO              = 1000

m_anJoystick = []
m_nCnt_Motor = 13

class CVar:
    IsTorqOn                = False
    nScreenWidth            = 0
    nScreenHeight           = 0
    nTouch_XY_X0            = 0
    nTouch_XY_Y0            = 0
    nTouch_Pos0             = 0
    nTouch_Pos_X0           = 0
    nTouch_Pos_Y0           = 0
    nTouch_XY_X1            = 0
    nTouch_XY_Y1            = 0
    nTouch_Pos1             = 0
    nTouch_Pos_X1           = 0
    nTouch_Pos_Y1           = 0
    nButton_0               = -1
    nButton_1               = -1
    nBack_Background        = 0
    btn0                    = None
    btn1                    = None

class CTimer:
    nTimer                  = 0
    IsTimer                 = False
        
    def __init__(self):
        self.nTimer = 0
        self.IsTimer = 0

    def Set(self):
        self.IsTimer      = True
        self.nTimer       = millis()
        
    def Get(self):
        if self.IsTimer :
            return millis() - self.nTimer
        return 0
        
    def Destroy(self):
        self.IsTimer = False


m_nInterval = 6 # 6

m_anIDs = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26]
m_IsTorqOn = False

def Rad2Deg(rad):
    return rad * 180.0 / math.pi
def Deg2Rad(Angle):
    return Angle * math.pi / 180.0

def Sin(fAngle):
    return math.sin(Deg2Rad(fAngle))
def Cos(fAngle):
    return math.cos(Deg2Rad(fAngle))
def CalcS(fSlide_Angle, fTurn_Angle = 0, fTilt_Interval=3,nLine_Limit=6, nLine = 1, nCol = 0):
    nLine = nLine-1
    fMod = ((nLine + nCol) % nLine_Limit) % fTilt_Interval
    fTmp = ((nLine + nCol) % nLine_Limit) // fTilt_Interval
    if(fMod<fTilt_Interval-2):
        return 0
    fDir = pow(-1,((fTilt_Interval-fTmp)+1))
    fResult = fDir*fSlide_Angle
    if (fTurn_Angle > 0) and (fDir > 0):
        fResult -= fTurn_Angle
    elif (fTurn_Angle < 0) and (fDir < 0):
        fResult -= fTurn_Angle
    return fResult
def CalcT(fTilt_Angle, fTilt_Interval=3,nLine_Limit=6, nLine=1,nCol=0):
    nLine = nLine-1
    fTmp = ((nLine + nCol) % nLine_Limit) % fTilt_Interval
    if(fTmp<fTilt_Interval-2):
        return 0
    return pow(-1,(fTilt_Interval-fTmp+1))*fTilt_Angle

def CalcSnake(nIndex, nTime_ms, fAngle_Turn = 0, IsBackward = False, nCnt_Motor = 13, fAngle_Head_Up = 10, fAngle_Body_Up_Down = 10, fAngle_Body_Left_Right = 70):
    #print(nTime_ms, fAngle_Head_Up, fAngle_Body_Up_Down, fAngle_Body_Left_Right)

    nLine_First = 1
    nLine_Last = m_nInterval
    nLine_Limit = m_nInterval

    fTilt_Interval = m_nInterval/2

    #nT = 2
    nLine = 0
    
    i = nIndex

    #for i in range(nLine_First, nLine_Last+1):    
    if IsBackward == False :
        nLine = nLine_Last - i + 1
    else :
        nLine = i

    afBody_T=[]
    afBody_T.append(fAngle_Head_Up)
    for nCol in range(0,nCnt_Motor):
        fTmp = CalcT(fAngle_Body_Up_Down,fTilt_Interval,nLine_Limit, nLine, nCnt_Motor-nCol)
        #print(fTmp)
        afBody_T.append(fTmp)

    # Head
    afBody_T[0] = afBody_T[0] - afBody_T[1]/2
    #Tail
    afBody_T[len(afBody_T) - 1] = afBody_T[len(afBody_T) - 1] - afBody_T[len(afBody_T) - 2] / 2

    afBody_S=[]
    afBody_S.append(0)
    for nCol in range(1,nCnt_Motor):
        fTmp = CalcS(fAngle_Body_Left_Right,fAngle_Turn,fTilt_Interval,nLine_Limit, nLine, nCnt_Motor-nCol)
        #print(fTmp)
        afBody_S.append(fTmp)
    afBody_S[0] = -afBody_S[2]
    afBody = []
    
    afBody.append(nTime_ms)

    for nCol in range(0,nCnt_Motor):
        afBody.append(afBody_T[nCol])
        afBody.append(afBody_S[nCol])

    #print(nLine,afBody)
    #delay(100)
    return afBody
    
# 각도를 모터에서 사용하는 Data 로 바꾸어 주는 함수(float -> int)
def CalcAngle2Raw(fAngle) :
    if fAngle == None :
        fAngle = 0.0
    return (int)(round(fAngle * 4096.0 / 360.0 + 2048.0))
def CalcRaw2Angle(nRaw) :
    if nRaw == None :
        nRaw = 0
    return (float)(360.0 * ((nRaw - 2048.0) / 4096.0))
def Setup_Speed(nID, nValue) :
    DXL(nID).write32(112, nValue) # 112 : profile velocity
def Writes(IDs, nAddress, values, size = 4, fPercent = 1.0):
    #profile 속도 조정
    Setup_Speed(254, int(values[0] * fPercent))
    #syncwrite
    etc.write8(1200,0)
    etc.write16(1202,nAddress)
    etc.write8(1204,size)
    nMot_First = 5
    nMot_Cnt = 1
    nPos = 1
    for i in IDs:
        nID = i  
        etc.write8(1205,nID)        
        etc.write32(1206,CalcAngle2Raw(values[nPos]))
        etc.write8(1200,1)    
        nPos = nPos + 1    
    etc.write8(1200,2)    
def Move(IDs, values, fPercent = 1.0, fPercent_Delay = 1.0) :
    if (fPercent_Delay == 0):
        fPercent_Delay = fPercent
    Writes(IDs, 116, values, 4, fPercent)
    Wait((int)(round(values[0] * fPercent_Delay)))
def Wait(nMilliseconds) :
    tmr = CTimer()
    tmr.Set()
    while(tmr.Get() < nMilliseconds) :
        # if btnList != None:
        #     #스마트폰의 터치 입력을 확인
        #     GetTouch_Down()               
        #     # 버튼 눌림 체크 - 터치의 소비
        #     nNum0, nNum1, Event_Dn0, Event_Dn1, Event_Up0, Event_Up1, Btn0, Btn1 = GetButton(btnList)      
        CheckJoystick()      
        #pass #delay(1)
    #tmr = None    
def TorqAll(IsOn, IsSound = None):
    TorqOnOff(-1, IsOn, IsSound)
def TorqOnOff(nNum, IsOn, IsSound = None):
    if (IsOn == True) :
        if IsSound == True :
            buzzer.melody(14)
        if (nNum >= 0) :
            DXL(nNum).torque_on()
        else :
            dxlbus.torque_on()
            m_IsTorqOn = True
    else :        
        m_IsTorqOn = False
        if IsSound == True :
            buzzer.melody(15)
        #모션을 바로 종료 시킴
        #Motion_Play(-3)
        #모션이 종료됨을 기다림
        #waitMotionStop()
        if (nNum >= 0) :
            DXL(nNum).torque_off()
        else :
            dxlbus.torque_off()


def GetTouch_Down():
    XY_X0 = 0
    XY_Y0 = 0
    Pos_X0 = 0
    Pos_Y0 = 0
    Pos0 = 0
    XY_X1 = 0
    XY_Y1 = 0
    Pos_X1 = 0
    Pos_Y1 = 0
    Pos1 = 0
    Tmp = smart.read64(10470) 
    nTouch0 = Tmp[0] & 0xffffffff
    nTouch1 = Tmp[1] & 0xffffffff
    IsChanged = False
    if (nTouch0 > 0) :
        XY_X0 = nTouch0 & 0x0000FFFF
        XY_Y0 = (nTouch0 >> 16) & 0x0000FFFF
        Pos_X0 = (int)((XY_X0 / CVar.nScreenWidth) * 5 + 1)
        Pos_Y0 = (int)((XY_Y0 / CVar.nScreenHeight) * 5 + 1)
        Pos0 = Pos_X0 + (Pos_Y0 - 1) * 5
        XY_X0 = (int)(XY_X0 * _RATIO / CVar.nScreenWidth)
        XY_Y0 = (int)(XY_Y0 * _RATIO / CVar.nScreenHeight)
        if (nTouch1 > 0) :
            XY_X1 = nTouch1 & 0x0000FFFF
            XY_Y1 = (nTouch1 >> 16) & 0x0000FFFF
            Pos_X1 = (int)((XY_X1 / CVar.nScreenWidth) * 5 + 1)
            Pos_Y1 = (int)((XY_Y1 / CVar.nScreenHeight) * 5 + 1)
            Pos1 = Pos_X1 + (Pos_Y1 - 1) * 5
            XY_X1 = (int)(XY_X1 * _RATIO / CVar.nScreenWidth)
            XY_Y1 = (int)(XY_Y1 * _RATIO / CVar.nScreenHeight)
        CVar.nTouch_Pos0 = Pos0
        CVar.nTouch_Pos_X0 = Pos_X0
        CVar.nTouch_Pos_Y0 = Pos_Y0
        CVar.nTouch_XY_X0 = XY_X0
        CVar.nTouch_XY_Y0 = XY_Y0
        CVar.nTouch_Pos1 = Pos1
        CVar.nTouch_Pos_X1 = Pos_X1
        CVar.nTouch_Pos_Y1 = Pos_Y1
        CVar.nTouch_XY_X1 = XY_X1
        CVar.nTouch_XY_Y1 = XY_Y1
    else :
        CVar.nTouch_Pos0 = 0
        CVar.nTouch_Pos_X0 = 0
        CVar.nTouch_Pos_Y0 = 0
        CVar.nTouch_XY_X0 = 0
        CVar.nTouch_XY_Y0 = 0
        CVar.nTouch_Pos1 = 0
        CVar.nTouch_Pos_X1 = 0
        CVar.nTouch_Pos_Y1 = 0
        CVar.nTouch_XY_X1 = 0
        CVar.nTouch_XY_Y1 = 0
def GetResolution():
    for i in range(0, 100):
        screen = smart.read32(10460)
        CVar.nScreenWidth = screen & 0x0000FFFF
        CVar.nScreenHeight = (screen & 0xFFFF0000) >> 16
        if CVar.nScreenWidth > 0 and CVar.nScreenWidth < 65535 and CVar.nScreenHeight > 0 and CVar.nScreenHeight < 65535:
            break
def Show_Background(nValue):
    if (nValue != CVar.nBack_Background):
        smart.display.back_image(nValue)
        CVar.nBack_Background = nValue



def rotate(aMotion, nCnt, nStart = 0, nEnd = 0):
    if not aMotion:
        return aMotion
    nCnt %= len(aMotion)
    if not nCnt:
        return aMotion

    left = aMotion[nStart:-nCnt]
    if nEnd <= nStart:
        nEnd = len(aMotion)
    right = aMotion[-nCnt:nEnd]  

    return right + left

def CheckJoystick():
    global m_anJoystick
    n1 = etc.read16(61) # 데이터
    #n3 = etc.read8(63) # 도착했는지 확인
    nVal1 = n1 & 0xff
    nVal2 = n1 >> 8 & 0xff
    #print("nVal2={0}".format(nVal2))
    if (nVal2 > 0):                    
        if (nVal1 < len(m_anJoystick)):
            m_anJoystick[nVal1] = ((nVal2 - 120) / 128)
################################################################
################################################################
################################################################
console(USB)
#console(BLE)


# 토크를 Off 하고 액츄에이터의 설정 및 컨트롤러의 설정을 로봇에 맞게 수정한다.
TorqAll(False)

# controller direction : 0-vertical(Humanoid), 1-Horizontal
eeprom.imu_type(1)
# profile -> velocity-based
#DXL(254).write8(10, 4) # 0 -> velocity-based profile, 4 -> time-based profile
# Secondary ID(255: No Use, 0 ~ 252: ID)
#DXL(254).write8(12, 255) # 255 -> No Use(Clear)
# Operation Mode(1:velocity[wheel], 3:position)
#DXL(254).mode(3) # position

# 토크를 Off 하고 액츄에이터의 설정을 모두 Time-based profile 로 변경한다.
#TorqAll(False)
#DXL(254).write8(10, 4) # 0 -> velocity-based profile, 4 -> time-based profile



# Flysky Controller 를 위한 UART Setting
etc.write8(43,1) # 0 : BLE, 1 : UArt, 2 : USB
etc.write8(88,0) # 0 : False, 1 : 저전압일때 경고음



TorqAll(True)

for i in range(0, 6):
    m_anJoystick.append(0)



# for j in range(1, 5):
#     for i in range(1, m_nInterval+1):
#         #print(CalcSnake(i, 1000))   
#         Move(m_anIDs, CalcSnake(i, 300, -40), 1.0, 0.9)
#         #Move(m_anIDs, [1000, 0, -85, -65, 30])

nMotionIndex = 0
aData = []
aMotion = []
anIDs = []
IsPhone = False
IsJoystick = True
m_nSpeed = 300
m_fTurn = 0

# m_lstMotion = [m_nInterval]
# m_lstMotion.clear()
IsFirst = True
IsChanging = False

# 0: Normal, 1: gradually
m_nControlMode = 1

aMotion.append(m_nSpeed)
for i in range(0, 26):
    nRaw = 0
    nRaw = DXL(i + 1).present_position()
    aMotion.append(CalcRaw2Angle(nRaw))

while(True) :
    if (IsPhone == False) and (IsJoystick == False) :
        if (smart.is_connected() == True):
            smart.wait_connected()
            smart.display.screen_orientation(2)
            delay(500)
            GetResolution()
            Show_Background(1)
            IsPhone = True
    else :
        IsMove = False
        m_fTurn = 0

        if (IsJoystick == False):
            GetTouch_Down()
        if (CVar.nTouch_Pos_X0 > 0) or (IsJoystick == True):
            fTurn_Value = 70
            if (IsJoystick == False):
                if (CVar.nTouch_Pos_X0 == 2) and (CVar.nTouch_Pos_Y0 == 3): # 전진
                    IsMove = True
                    m_fTurn = 0
                    nMotionIndex = (nMotionIndex + 1) % m_nInterval
                elif (CVar.nTouch_Pos_X0 == 1) and (CVar.nTouch_Pos_Y0 == 3): # 전진 좌
                    IsMove = True
                    m_fTurn = -fTurn_Value
                    nMotionIndex = (nMotionIndex + 1) % m_nInterval
                elif (CVar.nTouch_Pos_X0 == 3) and (CVar.nTouch_Pos_Y0 == 3): # 전진 우
                    IsMove = True
                    m_fTurn = fTurn_Value
                    nMotionIndex = (nMotionIndex + 1) % m_nInterval

                elif (CVar.nTouch_Pos_X0 == 2) and (CVar.nTouch_Pos_Y0 == 5): # 후진
                    IsMove = True
                    m_fTurn = 0
                    nMotionIndex = (nMotionIndex - 1)
                elif (CVar.nTouch_Pos_X0 == 1) and (CVar.nTouch_Pos_Y0 == 5): # 후진 좌
                    IsMove = True
                    m_fTurn = -fTurn_Value
                    nMotionIndex = (nMotionIndex - 1)
                elif (CVar.nTouch_Pos_X0 == 3) and (CVar.nTouch_Pos_Y0 == 5): # 후진 우
                    IsMove = True
                    m_fTurn = fTurn_Value
                    nMotionIndex = (nMotionIndex - 1)
            
            nKey_F = 1 #2
            nKey_W = 0 #3
            nKey_F2 = 2
            nKey_W2 = 3
            
            nKey_Rot_L = 4
            nKey_Rot_R = 5

            fAngle_Head_Up = 10
            fAngle_Body_Up_Down = 10
            fAngle_Body_Left_Right = 70

            IsForward = True
            
            n1 = etc.read16(61) # 데이터
            #n3 = etc.read8(63) # 도착했는지 확인
            nVal1 = n1 & 0xff
            nVal2 = n1 >> 8 & 0xff
            #print("nVal2={0}".format(nVal2))
            if (nVal2 > 0):                    
                if (nVal1 < len(m_anJoystick)):
                    m_anJoystick[nVal1] = ((nVal2 - 120) / 128)

                fW = (m_anJoystick[nKey_W] - 0.5)
                if (fW < 0.1) and (fW > -0.1):
                    fW = 0.0

                if (m_anJoystick[nKey_F] > 0.9): #전진
                    IsMove = True
                    IsForward = True
                    nMotionIndex = (nMotionIndex + 1) % m_nInterval
                    m_fTurn = fTurn_Value * fW        
                    # aMotion.append(aMotion.pop(3)) 
                    # aMotion.append(aMotion.pop(3))    
                elif (m_anJoystick[nKey_F] < 0.1):
                    IsMove = True
                    IsForward = False
                    nMotionIndex = (nMotionIndex - 1)
                    m_fTurn = fTurn_Value * fW       
                    # aMotion.insert(3, aMotion.pop())
                    # aMotion.insert(3, aMotion.pop())   

            if nMotionIndex < 0:
                nMotionIndex = m_nInterval - 1

            #print(m_anJoystick)
            if (IsMove == True):
                aData = CalcSnake(nMotionIndex + 1, m_nSpeed + 700 * (1.0 - m_anJoystick[nKey_Rot_L]), m_fTurn, False, m_nCnt_Motor, fAngle_Head_Up + 20 * (m_anJoystick[nKey_W2] - 0.5), fAngle_Body_Up_Down + 20 * m_anJoystick[nKey_Rot_R], fAngle_Body_Left_Right - 40 * (1.0 - m_anJoystick[nKey_F2]))
                nCheckSpecialValue = m_anJoystick[0] + m_anJoystick[1] + m_anJoystick[2] + m_anJoystick[3] + m_anJoystick[4] + m_anJoystick[5]
                
                #print(nCheckSpecialValue)
                if (nCheckSpecialValue < 0.3) :
                    if (IsChanging == False):
                        #print(nCheckSpecialValue)
                        # 0: Normal, 1: gradually
                        if (m_nControlMode == 0):
                            m_nControlMode = 1                            
                            buzzer.melody(14)

                            dxlbus.reboot()
                            buzzer.melody(1)
                            delay(1500)
                            TorqAll(True)

                        else:
                            m_nControlMode = 0                          
                            buzzer.melody(15)

                            dxlbus.reboot()
                            buzzer.melody(1)
                            delay(1500)
                            TorqAll(True)


                        IsChanging = True
                else:
                    IsChanging = False

                if (m_nControlMode == 0):
                    aMotion = aData[:]
                else:
                    if IsFirst == True:
                        IsFirst = False
                        aMotion = aData[:]


                    if (IsForward == True):
                        aMotion.append(aMotion.pop(3)) 
                        aMotion.append(aMotion.pop(3))
                    else:             
                        aMotion.insert(1, aMotion.pop())
                        aMotion.insert(1, aMotion.pop())
                    aMotion[0] = aData[0] # Time
                    aMotion[1] = aData[1] # Head Up
                    aMotion[2] = aData[2] # Head Dir
                    aMotion[3] = aData[3] # T[0]
                    aMotion[4] = aData[4] # S[0]      

                    # aMotion[25] = 0                
                # aTmp = aMotion[:]
                # aTmp[25] = 0
                Move(m_anIDs, aMotion, 1.0, 0.8)
                # Move(m_anIDs, aTmp, 1.0, 0.8)
                # Move(m_anIDs, aData, 1.0, 0.8)