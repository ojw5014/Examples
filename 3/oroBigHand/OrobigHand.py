from pycm import *
import time
import math
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
    nPage                   = -1
    nPage_Prev              = -1
    nPoint_L                = 2
    IsWalking               = False
    nDemoMode               = 0 
    nDemoIndex              = 0
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
_INIT_FX = 0
_INIT_FY = 805
_LOAD       = 500#100 
_LOAD_DEMO  = 500#100 
m_fX = _INIT_FX
m_fY = _INIT_FY
_IDS_ARM = [9, 10, 16]
_IDS_HAND = [5]
_IDS_HAND_TURN = [6]
m_afArm = [  100, 0,  0,  0]
m_afManipulator = [  100, 0,  0,  0]
m_afHand = [ 200,        0,  0,  0 ]
_MNT_READY = [ 1000, -40, -30, 40, -30, 30, -50, -30, -50, 0]
nDemoV = 30
fDemoV_Per = 0.85
nDemoH = 30
nDemoH_Default = 30
nDemoStepTime = 300
_MNT_DEMO_STEP_Base = [ nDemoStepTime, -40         , -nDemoH_Default, 40         , -nDemoH_Default, 30         , -nDemoH_Default-20, -30         , -nDemoH_Default-20,       0             ]
_MNT_DEMO_STEP_0    = [ nDemoStepTime, -40 + nDemoV, -nDemoH_Default, 40 + nDemoV, -nDemoH_Default, 30 + nDemoV, -nDemoH_Default-20, -30 + nDemoV, -nDemoH_Default-20,  nDemoV * fDemoV_Per]
_MNT_DEMO_STEP_1    = [ nDemoStepTime, -40 - nDemoV, -nDemoH_Default, 40 - nDemoV, -nDemoH_Default, 30 - nDemoV, -nDemoH_Default-20, -30 - nDemoV, -nDemoH_Default-20, -nDemoV * fDemoV_Per]
_MNT_DEMO = [
    _MNT_DEMO_STEP_0,
    _MNT_DEMO_STEP_Base,
    _MNT_DEMO_STEP_1,
    _MNT_DEMO_STEP_Base
]
_MNT_DEMO2_STEP_Base= [ nDemoStepTime, -40         , -nDemoH_Default+nDemoH, 40         , -nDemoH_Default+nDemoH, 30         , -nDemoH_Default-20+nDemoH, -30         , -nDemoH_Default-20+nDemoH,       0             ]
_MNT_DEMO2_STEP_0   = [ nDemoStepTime, -40 + nDemoV, -nDemoH_Default+nDemoH, 40 + nDemoV, -nDemoH_Default+nDemoH, 30 + nDemoV, -nDemoH_Default-20+nDemoH, -30 + nDemoV, -nDemoH_Default-20+nDemoH,  nDemoV * fDemoV_Per]
_MNT_DEMO2_STEP_1   = [ nDemoStepTime, -40 - nDemoV, -nDemoH_Default+nDemoH, 40 - nDemoV, -nDemoH_Default+nDemoH, 30 - nDemoV, -nDemoH_Default-20+nDemoH, -30 - nDemoV, -nDemoH_Default-20+nDemoH, -nDemoV * fDemoV_Per]
_MNT_DEMO2 = [
    _MNT_DEMO2_STEP_1,
    _MNT_DEMO2_STEP_Base,
    _MNT_DEMO2_STEP_0,
    _MNT_DEMO2_STEP_Base
]
lstDemo = None
_MNT_READY_ARM = [ 1000,                                   0, -65, -20, 20, 75, -90]
_MOTION = []
def MotionSet(nDirection):
    global _MOTION
    if (nDirection == 0): 
        nTime = 300 / (nSpeed + 1)   
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 50, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 50, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 50, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 50, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -40, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -30, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -20, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -10, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP0,
            _MNT_F_STEP1,
            _MNT_F_STEP2,
            _MNT_F_STEP3,
            _MNT_F_STEP4,
            _MNT_F_STEP5,
            _MNT_F_STEP6,
            _MNT_F_STEP7,
            _MNT_F_STEP8,
            _MNT_F_STEP9,
            _MNT_F_STEP10,
            _MNT_F_STEP11
        ]
    elif (nDirection == 1):
        nTime = 300 / (nSpeed + 1)   
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 40, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 30, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 20, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 10, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -40, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -30, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -20, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -10, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP0,
            _MNT_F_STEP1,
            _MNT_F_STEP2,
            _MNT_F_STEP3,
            _MNT_F_STEP4,
            _MNT_F_STEP5,
            _MNT_F_STEP6,
            _MNT_F_STEP7,
            _MNT_F_STEP8,
            _MNT_F_STEP9,
            _MNT_F_STEP10,
            _MNT_F_STEP11
        ]
    elif (nDirection == 2): 
        nTime = 300 / (nSpeed + 1)   
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 40, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 30, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 20, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 10, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -50, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -50, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -50, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -50, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP0,
            _MNT_F_STEP1,
            _MNT_F_STEP2,
            _MNT_F_STEP3,
            _MNT_F_STEP4,
            _MNT_F_STEP5,
            _MNT_F_STEP6,
            _MNT_F_STEP7,
            _MNT_F_STEP8,
            _MNT_F_STEP9,
            _MNT_F_STEP10,
            _MNT_F_STEP11
        ]
    elif (nDirection == 3):
        _MNT_TL_STEP0 = [ 100, -55, -40, 55, -30, 45, -50, -45, -60, 0]
        _MNT_TL_STEP1 = [ 100, -70, -30, 70, -30, 60, -50, -60, -50, 0]
        _MNT_TL_STEP2 = [ 100, -55, -30, 55, -40, 45, -60, -45, -50, 0]
        _MNT_TL_STEP3 = [ 100, -40, -30, 40, -30, 30, -50, -30, -50, 0]
        _MOTION = [
            _MNT_TL_STEP0,
            _MNT_TL_STEP1,
            _MNT_TL_STEP2,
            _MNT_TL_STEP3
        ]
    elif (nDirection == 5):
        _MNT_TR_STEP0 = [ 100, -55, -30, 55, -40, 45, -60, -45, -50, 0]
        _MNT_TR_STEP1 = [ 100, -70, -30, 70, -30, 60, -50, -60, -50, 0]
        _MNT_TR_STEP2 = [ 100, -55, -40, 55, -30, 45, -50, -45, -60, 0]
        _MNT_TR_STEP3 = [ 100, -40, -30, 40, -30, 30, -50, -30, -50, 0]
        _MOTION = [
            _MNT_TR_STEP0,
            _MNT_TR_STEP1,
            _MNT_TR_STEP2,
            _MNT_TR_STEP3
        ]
    elif (nDirection == 6): 
        nTime = 300 / (nSpeed + 1)    
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 50, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 50, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 50, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 50, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -40, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -30, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -20, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -10, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP11,
            _MNT_F_STEP10,
            _MNT_F_STEP9,
            _MNT_F_STEP8,
            _MNT_F_STEP7,
            _MNT_F_STEP6,
            _MNT_F_STEP5,
            _MNT_F_STEP4,
            _MNT_F_STEP3,
            _MNT_F_STEP2,
            _MNT_F_STEP1,
            _MNT_F_STEP0
        ]
    elif (nDirection == 7):
        nTime = 300 / (nSpeed + 1)    
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 40, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 30, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 20, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 10, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -40, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -30, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -20, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -10, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP11,
            _MNT_F_STEP10,
            _MNT_F_STEP9,
            _MNT_F_STEP8,
            _MNT_F_STEP7,
            _MNT_F_STEP6,
            _MNT_F_STEP5,
            _MNT_F_STEP4,
            _MNT_F_STEP3,
            _MNT_F_STEP2,
            _MNT_F_STEP1,
            _MNT_F_STEP0
        ]
    elif (nDirection == 8): 
        nTime = 300 / (nSpeed + 1)    
        _MNT_F_STEP0  = [ nTime, -15, -50, 45, -50, 10, -20, -45, -30, 0 ]
        _MNT_F_STEP1  = [ nTime, -20, -30, 50, -50, 10, -10, -40, -50, 0 ]
        _MNT_F_STEP2  = [ nTime, -25, -30, 40, -50, 20, -10, -40, -40, 0 ]
        _MNT_F_STEP3  = [ nTime, -30, -30, 30, -50, 30, -10, -40, -50, 0 ]
        _MNT_F_STEP4  = [ nTime, -35, -30, 20, -50, 40, -10, -25, -40, 0 ]
        _MNT_F_STEP5  = [ nTime, -40, -30, 10, -50, 50, -10, -10, -30, 0 ]
        _MNT_F_STEP6  = [ nTime, -45, -50, 15, -50, 45, -30, -10, -20, 0 ]
        _MNT_F_STEP7  = [ nTime, -50, -50, 20, -30, 40, -50, -10, -10, 0 ]
        _MNT_F_STEP8  = [ nTime, -50, -50, 25, -30, 40, -40, -20, -10, 0 ]
        _MNT_F_STEP9  = [ nTime, -50, -50, 30, -30, 40, -50, -30, -10, 0 ]
        _MNT_F_STEP10 = [ nTime, -50, -50, 35, -30, 25, -40, -40, -10, 0 ]
        _MNT_F_STEP11 = [ nTime, -50, -50, 40, -30, 10, -30, -50, -10, 0 ]
        _MOTION = [
            _MNT_F_STEP11,
            _MNT_F_STEP10,
            _MNT_F_STEP9,
            _MNT_F_STEP8,
            _MNT_F_STEP7,
            _MNT_F_STEP6,
            _MNT_F_STEP5,
            _MNT_F_STEP4,
            _MNT_F_STEP3,
            _MNT_F_STEP2,
            _MNT_F_STEP1,
            _MNT_F_STEP0
        ]
_COLOR_NONE         = 0
_COLOR_WHITE        = 1
_COLOR_BLACK        = 2
_COLOR_RED          = 3
_COLOR_GREEN        = 4
_COLOR_BLUE         = 5
_COLOR_YELLOW       = 6
_COLOR_GRAY_LIGHT   = 7
_COLOR_GRAY         = 8
_COLOR_GRAY_DARK    = 9
_SHOW_IMAGE         = 0
_SHOW_TEXT          = 1
_SHOW_SHAPE         = 2
_SHOW_NUM           = 3
_RATIO              = 1000
_BTN_INDEX          = 4
_BTN_ARM_F          = [610,220,700,356,30]
_BTN_ARM_B          = [610,400,700,530,31]
_BTN_ARM_ORG        = [736,310,826,440,32]
_BTN_ARM_UP         = [860,220,950,356,33]
_BTN_ARM_DN         = [860,400,950,530,34]
_BTN_ARM_LEFT       = [672,550,766,678,35]
_BTN_ARM_RIGHT      = [800,550,892,678,36]
_BTN_HAND_IN        = [610,802,700,936,37]
_BTN_HAND_ORG       = [736,802,826,936,38]
_BTN_HAND_OUT       = [860,802,950,936,39]
_BTN_TURN_L         = [30,320,100,440,6]
_BTN_TURN_R         = [240,310,310,440,7]
_BTN_MOVE_UL        = [40,490,110,630,12]
_BTN_MOVE_U         = [140,390,200,530,13]
_BTN_MOVE_UR        = [230,490,300,630,14]
_BTN_MOVE_DL        = [40,700,110,830,17]
_BTN_MOVE_D         = [140,800,200,930,18]
_BTN_MOVE_DR        = [230,700,300,830,19]
_BTN_MOVE_X         = [120,560,220,770,20]
_BTN_TORQ           = [20,40,160,150,21]
_BTN_DEMO           = [830,40,970,150,22]
_BTN_SPD_TOP        = 450   
_BTN_SPD_BOTTM      = 900   
_BTN_SPD_X          = 458   
_BTN_SPD_W          = 60    
_BTN_COUNT          = 5     
nSpdBtnW            = int(_BTN_SPD_W / 2)
nSpdBtnH            = int((_BTN_SPD_BOTTM - _BTN_SPD_TOP) / (_BTN_COUNT - 1) / 2)
nTmp = 0
_BTN_SPD_L5         = [_BTN_SPD_X - nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * nTmp)*2 - nSpdBtnH, _BTN_SPD_X + nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * (nTmp + 1))*2 + nSpdBtnH - 1, 1]
nTmp = 1
_BTN_SPD_L4         = [_BTN_SPD_X - nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * nTmp)*2 - nSpdBtnH, _BTN_SPD_X + nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * (nTmp + 1))*2 + nSpdBtnH - 1, 1]
nTmp = 2
_BTN_SPD_L3         = [_BTN_SPD_X - nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * nTmp)*2 - nSpdBtnH, _BTN_SPD_X + nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * (nTmp + 1))*2 + nSpdBtnH - 1, 1]
nTmp = 3
_BTN_SPD_L2         = [_BTN_SPD_X - nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * nTmp)*2 - nSpdBtnH, _BTN_SPD_X + nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * (nTmp + 1))*2 + nSpdBtnH - 1, 1]
nTmp = 4
_BTN_SPD_L1         = [_BTN_SPD_X - nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * nTmp)*2 - nSpdBtnH, _BTN_SPD_X + nSpdBtnW, _BTN_SPD_TOP + (nSpdBtnH * (nTmp + 1))*2 + nSpdBtnH - 1, 1]
_PAGE_MAIN                  = 1
btnList             = None
tmrTorqBtn          = CTimer()
IsPhone             = False
nSpeed              = 0
def DelayForRun(nMilliSecond):
    Wait(int(nMilliSecond / CVar.nPoint_L))
def ShowPage(nPage):
    global btnList
    global nSpeed
    CVar.nPage_Prev = CVar.nPage
    CVar.nPage = nPage
    if nPage == _PAGE_MAIN:
        Clear_All()
        btnList = [
            _BTN_TORQ,
            _BTN_DEMO,
            _BTN_ARM_F,
            _BTN_ARM_B,
            _BTN_ARM_ORG,
            _BTN_ARM_UP,
            _BTN_ARM_DN,
            _BTN_ARM_LEFT,
            _BTN_ARM_RIGHT,
            _BTN_HAND_IN,
            _BTN_HAND_ORG,
            _BTN_HAND_OUT,
            _BTN_TURN_L,
            _BTN_TURN_R,
            _BTN_MOVE_UL,
            _BTN_MOVE_U,
            _BTN_MOVE_UR,
            _BTN_MOVE_DL,
            _BTN_MOVE_D,
            _BTN_MOVE_DR,
            _BTN_MOVE_X,
            _BTN_SPD_L1,
            _BTN_SPD_L2,
            _BTN_SPD_L3,
            _BTN_SPD_L4,
            _BTN_SPD_L5
            ]
        Show_Background(nSpeed + 1)
    else :
        btnList = [
            _BTN_ROCK
            ]
def Clear_Point(nX, nY):
    Clear(_SHOW_SHAPE, nX, nY)
def ShowGage(nValue):
    if nValue != CVar.nPoint_L:
        if (CVar.nPoint_L > 0):
            nGap = nSpdBtnH * 2
            nX = _BTN_SPD_X
            nY = (_BTN_SPD_L1[1] - (nGap * (CVar.nPoint_L-1))) + nSpdBtnH
            Clear_Point(nX, nY)
    CVar.nPoint_L = nValue
    nGap = nSpdBtnH * 2
    nX = _BTN_SPD_X
    nY = (_BTN_SPD_L1[1] - (nGap * (nValue-1))) + nSpdBtnH
    Show_Point(nX, nY, _COLOR_BLACK)
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
            CVar.IsTorqOn = True
    else :
        CVar.IsTorqOn = False
        if IsSound == True :
            buzzer.melody(15)
        if (nNum >= 0) :
            DXL(nNum).torque_off()
        else :
            dxlbus.torque_off()
def GetResolution():
    for i in range(0, 100):
        screen = smart.read32(10460)
        CVar.nScreenWidth = screen & 0x0000FFFF
        CVar.nScreenHeight = (screen & 0xFFFF0000) >> 16
        if CVar.nScreenWidth > 0 and CVar.nScreenWidth < 65535 and CVar.nScreenHeight > 0 and CVar.nScreenHeight < 65535:
            break
def GetTouch_Down():
    if (smart.is_connected() == True):
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
    else :
        IsPhone = False
def Set(nX, nY):
    nResX = nX * CVar.nScreenWidth / _RATIO
    nResY = nY * CVar.nScreenHeight / _RATIO
    return nResX, nResY
def IsButton(nX, nY, Btn):
    if (Btn[0] < 0):
        right = (Btn[0] * -200)
        left = right - 200
        bottom = (Btn[1] * -200)
        top = bottom - 200
        if ((nY >= top) and (nY <= bottom)):
            if ((nX >= left) and (nX <= right)):
                return True
    else:
        if ((nY >= Btn[1]) and (nY <= Btn[3])):
            if ((nX >= Btn[0]) and (nX <= Btn[2])):
                return True
    return False
def PositionUpdate():
    etc.write8(65,3)
    while(True) :
        if etc.read8(65) == 0 :
            break
def Show_Num(nX, nY, nValue, nColor = _COLOR_NONE, nSize = None):
    if (nSize == 0):
        Clear_Num(nX, nY)
    elif (nColor == _COLOR_NONE):
        Show(_SHOW_NUM, nX, nY, 60, _COLOR_RED, nValue)
    elif (nSize == None):
        Show(_SHOW_NUM, nX, nY, 60, nColor, nValue)
    else:
        Show(_SHOW_NUM, nX, nY, nSize, nColor, nValue)
def Show_Point(nX, nY, nColor, nSize = None):
    if (nSize == None):
        Show(_SHOW_SHAPE, nX, nY, 20, nColor, 1)
    else:
        Show(_SHOW_SHAPE, nX, nY, nSize, nColor, 1)
def Show_Text(nX, nY, nValue, nColor = _COLOR_NONE, nSize = None):
    if (nColor == _COLOR_NONE):
        Show(_SHOW_TEXT, nX, nY, 60, _COLOR_RED, nValue)
    elif (nSize == None):
        Show(_SHOW_TEXT, nX, nY, 60, nColor, nValue)
    else:
        Show(_SHOW_TEXT, nX, nY, nSize, nColor, nValue)
def Show_Image(nX, nY, nValue, nSize = None):
    if (nSize == None):
        Show(_SHOW_IMAGE, nX, nY, 1, 0, nValue)
    else:
        Show(_SHOW_SHAPE, nX, nY, nSize, 0, nValue)
def Show_Background(nValue):
    if (nValue != CVar.nBack_Background):
        smart.display.back_image(nValue)
        CVar.nBack_Background = nValue
def Show(nShowType, nX, nY, nSize, nColor, nValue):
    if ((nShowType >= 0) and (nShowType < 4)):
        nX, nY = Set(nX, nY)
        smart.write32(10480, int(nX) | (int(nY) << 16))
        nTmp = nValue * 256 + nSize * 65536 + nColor * 16777216
        if (nShowType == _SHOW_IMAGE) : 
            smart.display.front_image(nTmp & 16777215) 
        elif (nShowType == _SHOW_SHAPE) :
            smart.display.shape(nTmp)
        elif (nShowType == _SHOW_TEXT) :
            smart.display.text(nTmp)
        elif (nShowType == _SHOW_NUM) :
            smart.display.number(nTmp)
def Clear(nShowType, nX, nY):
    if ((nShowType >= 0) and (nShowType < 4)):
        nX, nY = Set(nX, nY)
        smart.write32(10480, int(nX) | (int(nY) << 16))
        if (nShowType == _SHOW_IMAGE) :
            smart.display.front_image(0)
        elif (nShowType == _SHOW_SHAPE) :
            smart.display.shape(0)
        elif (nShowType == _SHOW_TEXT) :
            smart.display.text(0)
        elif (nShowType == _SHOW_NUM) :
            smart.display.number(0)
def Clear_All():
    smart.write32(10480, 0)
    smart.display.front_image(0)
    smart.display.shape(0)
    smart.display.text(0)
    smart.display.number(0)
def Clear_Image():
    smart.write32(10480, 0)
    smart.display.front_image(0)
def Clear_Shape():
    smart.write32(10480, 0)
    smart.display.shape(0)
def Clear_Text():
    smart.write32(10480, 0)
    smart.display.text(0)
def Clear_Num(nX = None, nY = None):
    if (nX == None) or (nY == None) :
        smart.write32(10480, 0)
        smart.display.number(0)
    else :
        Show(_SHOW_NUM, nX, nY, 0, 0, 0)
def CalcAngle2Raw(fAngle) :
    if fAngle == None :
        fAngle = 0.0
    return (int)(round(fAngle * 4096.0 / 360.0 + 2048.0))
def Get_Load(nID):
    return DXL(nID).read16(126)
def Get_Position(nID):
    return DXL(nID).present_position() - aOffset[nID]
def CalcRaw2Angle(nRaw) :
    if nRaw == None :
        nRaw = 0
    return (float)(360.0 * ((nRaw - 2048.0) / 4096.0))
def Rad2Deg(rad):
    return rad * 180.0 / math.pi
def Deg2Rad(Angle):
    return Angle * math.pi / 180.0
def Atan(fAngle):
    return Rad2Deg(math.atan(Deg2Rad(fAngle)))
def Atan2(x,y):
    return Rad2Deg(math.atan2(y, x))
def Acos(val):
    tmp=math.acos(val)
    return Rad2Deg(tmp)
def Sin(fAngle):
    return Rad2Deg(math.sin(Deg2Rad(fAngle)))
def Cos(fAngle):
    return Rad2Deg(math.cos(Deg2Rad(fAngle)))
def Get_Angle(nID):
    return CalcRaw2Angle(DXL(nID).present_position())
def CalcCosAngle(a, b, another):
    return Acos((a*a + b*b - another*another) / (2 * a * b))
def GetXY():
    MotBase = Get_Angle(10)
    MotElbow = Get_Angle(16)
    return CalcXY(MotBase, MotElbow)
def CalcXY(MotBase, MotElbow):
    t10 = MotBase
    t16 = MotElbow
    P = Cos(45)
    C10 = Cos(t10)
    S10 = Sin(t10)
    C14 = Cos(t16)
    S14 = Sin(t16)
    r0 = C10*P+S10*P
    r1 = C10*P-S10*P
    r2 = r0*S14 - r1*C14
    r3 = r1*S14 + r0*C14
    x =-r2 * 55 + r3 * 40 + r0*45 + C10*55
    y = r3 * 55 + r2 * 40 - r1*45 + S10*55
    return x,-y
def SetXY(x, y, z, nTime=100, IsDelay=True):
    try:
        #bk2=t3
        #bk1=t2
        #bk3=t4
        print(x,y,z)
        fx=y-331
        fy=x
        fz=z

        up=237
        dn=237

        # Up 모터의 각도 알아내기
        tup=Atan2(fz,fy)

        # clipping #
        # 작으면 1, 같거나 크면 0
       
        if (tup >= 360):
          tup = tup - 360
        elif (tup <= -360):
          tup = tup + 360
        tup = tup - 360
        
        if (tup >= 180):
          tup = tup * -1
        
        t_turn=tup

        # 이제 Base와 Down 모터의 각을 알아보자
        # Down
        d=math.sqrt(((fx * fx) + (fy * fy) + (fz * fz)))
        tdn=Acos(((up * up) + (dn * dn) - (d * d)) / (2 * up * dn))

        t_link = 180 - tdn

        # Base
        dy=math.sqrt(((fy * fy) + (fz * fz)))
        phi=Atan2(fx, dy)#Atan(dy/fx)#atan2(fx, dy)
        t_base=phi - Acos(((up*up) + (d*d) - (dn*dn)) / (2 * d * up))

        t1=-t_turn
        t2=-t_base
        t3=t_link



        #t_wrist=bk3+(bk1-t2)+(bk2-t3)
        #t_wrist=bk3+(bk1-t2)-(bk2-t3)
        #v0=(bk1-t2)
        #v1=(bk2-t3)
        #v2=t_wrist
        #t4=t_wrist



        #v0=tW
        #v1=-(tUp+270)
        #v2=-(tKnee-360-180+45)
        v1=t2
        v2=t3
        Move_Manipulator(v1, v2, nTime, -nTime*2/3, IsDelay)
        return True
    except ValueError:
        return False
def Test1(nBackgroundImage = 1, nImage = 0, x=500,y=500):
    if (CVar.nTouch_Pos0 > 0):
        Clear_All()
    Show_Background(nBackgroundImage)
    if (x>0) and (y>0) and (nImage>0):
        Show_Image(x, y, nImage)
    if (CVar.nTouch_Pos0 > 0):
        Clear_Num()
        Clear_Shape()
        nPos = 50
        nGap = 20
        nX = CVar.nTouch_XY_X0
        nY = CVar.nTouch_XY_Y0
        if nX < 100 :
            nX = 100
        elif nX > 900 :
            nX = 900
        if nY < 100 :
            nY = 100
        elif nY > 900 :
            nY = 900
        Show_Num(nX - nPos - nGap,   nY-40, (int)(CVar.nTouch_XY_X0 / 100 % 10))
        Show_Num(nX - nPos,          nY-40, (int)(CVar.nTouch_XY_X0 / 10 % 10))
        Show_Num(nX - nPos + nGap,   nY-40, (int)(CVar.nTouch_XY_X0 % 10))
        nPos = 50
        Show_Num(nX + nPos - nGap,   nY-40, (int)(CVar.nTouch_XY_Y0 / 100 % 10))
        Show_Num(nX + nPos,          nY-40, (int)(CVar.nTouch_XY_Y0 / 10 % 10))
        Show_Num(nX + nPos + nGap,   nY-40, (int)(CVar.nTouch_XY_Y0 % 10))
        Show_Num(nX-30, nY+40, CVar.nTouch_Pos_X0, _COLOR_GREEN)
        Show_Num(nX+30, nY+40, CVar.nTouch_Pos_Y0, _COLOR_GREEN)
        Show_Point(CVar.nTouch_XY_X0, CVar.nTouch_XY_Y0, _COLOR_BLUE)
    if (CVar.nTouch_Pos1 > 0):
        nPos = 50
        nGap = 20
        nX = CVar.nTouch_XY_X1
        nY = CVar.nTouch_XY_Y1
        if nX < 100 :
            nX = 100
        elif nX > 900 :
            nX = 900
        if nY < 100 :
            nY = 100
        elif nY > 900 :
            nY = 900
        Show_Num(nX - nPos - nGap,   nY-40, (int)(CVar.nTouch_XY_X1 / 100 % 10))
        Show_Num(nX - nPos,          nY-40, (int)(CVar.nTouch_XY_X1 / 10 % 10))
        Show_Num(nX - nPos + nGap,   nY-40, (int)(CVar.nTouch_XY_X1 % 10))
        nPos = 50
        Show_Num(nX + nPos - nGap,   nY-40, (int)(CVar.nTouch_XY_Y1 / 100 % 10))
        Show_Num(nX + nPos,          nY-40, (int)(CVar.nTouch_XY_Y1 / 10 % 10))
        Show_Num(nX + nPos + nGap,   nY-40, (int)(CVar.nTouch_XY_Y1 % 10))
        Show_Num(nX-30, nY+40, CVar.nTouch_Pos_X1, _COLOR_GREEN)
        Show_Num(nX+30, nY+40, CVar.nTouch_Pos_Y1, _COLOR_GREEN)
        Show_Point(CVar.nTouch_XY_X1, CVar.nTouch_XY_Y1, _COLOR_RED)
def Setup_Speed(nID, nValue) :
    DXL(nID).write32(112, nValue) 
def Move_Ready(nWith_Arm = 1):
    global m_afArm
    global m_afManipulator
    # IDs = [1,2,3,4,5,6,7,8,9]
    # Move(IDs, _MNT_READY)
    # Move_Yaw(0, 1.0, False)
    # if nWith_Arm == 1:
    #     Move_Ready_Arm()
    #     Move_Gripper(-50, 10)
    Move_Gripper(10, 10)
    Move_Yaw(0, 1.0, True, 2000)
def Move_Ready_Arm():
    global m_fX
    global m_fY
    m_fX = _INIT_FX
    m_fY = _INIT_FY
    SetXY(0, m_fY, m_fX, 1000)
def Delay_Body_Step(motions, nStepIndex, fPercent = 1.0):
    motion_step = motions[nStepIndex]
    tmr = CTimer()
    tmr.Set()
    while(tmr.Get() < int(motion_step[0] * fPercent)):
        if btnList != None:
            nNum0, nNum1, Event_Dn0, Event_Dn1, Event_Up0, Event_Up1, Btn0, Btn1 = GetButton(btnList)
def Move_Body_Step(motions, nStepIndex, IsDelay = True, fPercent = 1.0):
    motion_step = motions[nStepIndex]
    IDs = [1,2,3,4,5,6,7,8]
    if (len(motion_step) == 9 + 1):
        IDs = [1,2,3,4,5,6,7,8,9]
    if (nStepIndex >= 0) and (nStepIndex < len(motions)):
        Writes(IDs, 116, motion_step, 4, fPercent)
        if (IsDelay):
            Wait(int(motion_step[0] * fPercent))
def Moves_Body(motions, fPercent = 1.0, fPercent_Delay = 0.0):
    IDs = [1,2,3,4,5,6,7,8,9]
    for values in motions:
        Move(IDs, values, fPercent, fPercent_Delay)
def Move_Manipulator(fBase, fElbow, fTime, fDelay, IsDelay = True):
    bRet = True
    if (fElbow < -90):
        bRet = False
        fElbow = -90
    fTilt = -(fBase-fElbow) - 90
    #if (fTilt > 105):
    #    bRet = False
    #    fTilt = 105

    fOffset_Elbow = 16
    fOffset_Base = 10
    
    fOffset_Tilt = 30 + 10

    IDs = [2, 3, 4]
    Writes(IDs, 116, [fTime, (fBase + fOffset_Base) * 6, (fElbow + fOffset_Elbow) * 6, (fTilt + fOffset_Tilt) * 6], 4, 1.0)
    m_afArm[2] = fBase 
    m_afArm[3] = fElbow 
    #m_afHand[1] = fTilt  
    m_afManipulator[1] = fBase 
    m_afManipulator[2] = fElbow 
    m_afManipulator[3] = fTilt  
    if (IsDelay):
        DelayForRun(int(fTime + fDelay))
    return bRet
def Move_Yaw(fYaw, fPercent = 1.0, IsDelay = True, fSpeed = 100):
    global m_afArm
    # if (fYaw >= 30):
    #     fYaw = 30
    # if (fYaw <= -30):
    #     fYaw = -30
    m_afArm[1] = fYaw  
    #fSpeed = 100
    Writes([1], 116, [fSpeed, fYaw * 6], 4, fPercent)
    if (IsDelay):
        DelayForRun(int(m_afArm[0] * fPercent * 0.5))
        

def Move_Gripper_Turn(fAngle, fPercent = 1.0, IsDelay = True):
    Writes(_IDS_HAND_TURN, 116, [1000, fAngle], 4, fPercent)
    if (IsDelay):
        DelayForRun(1000)

def IMove_Yaw(fYaw, fPercent = 1.0, IsDelay = True):
    Move_Yaw(m_afArm[1] + fYaw, fPercent, IsDelay)
def Move_Tilt_Gripper(fTilt, nTime = 0):
    global m_afHand
    m_afHand[1] = fTilt  
    Writes([15], 116, [nTime, fTilt], 4, 1.0)
    if nTime > 0:
        DelayForRun(int(nTime))
def Move_Gripper(fGrip, fPercent = 1.0, IsDelay = True):
    global m_afHand
    if (fGrip >= 10): 
        fGrip = 10
    if (fGrip <= -70): 
        fGrip = -70
    m_afHand[1] = fGrip
    Writes(_IDS_HAND, 116, m_afHand, 4, fPercent)
    if (IsDelay):
        DelayForRun(int(m_afHand[0] * fPercent * 0.5))
def IMove_Gripper(fGrip, fPercent = 1.0, IsDelay = True):
    Move_Gripper(m_afHand[1] + fGrip, fPercent, IsDelay)
def IMove_Tilt_Gripper(fTilt, nTime = 0):
    Move_Tilt_Gripper(m_afHand[1] + fTilt, nTime)
def Move(IDs, values, fPercent = 1.0, fPercent_Delay = 0.0) :
    if (fPercent_Delay == 0):
        fPercent_Delay = fPercent
    Writes(IDs, 116, values, 4, fPercent)
    Wait(int(values[0] * fPercent_Delay))
def Wait(nMilliseconds) :
    tmr = CTimer()
    tmr.Set()
    while(tmr.Get() < nMilliseconds) :
        if btnList != None:
            GetTouch_Down()
            nNum0, nNum1, Event_Dn0, Event_Dn1, Event_Up0, Event_Up1, Btn0, Btn1 = GetButton(btnList)
        delay(10)
    tmr = None
def Writes(IDs, nAddress, values, size = 4, fPercent = 1.0):
    Setup_Speed(254, int(values[0] * fPercent))
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
def WaitButtonUp():
    while(True) :
        GetTouch_Down()
        nNum0, nNum1, Event_Dn0, Event_Dn1, Event_Up0, Event_Up1, Btn0, Btn1 = GetButton(btnList)
        if ((nNum0 < 0) and (nNum1 < 0)):
            break
def GetButton(btns):
    nNum0 = -1
    nNum1 = -1
    nDown0 = 0
    nDown1 = 0
    nUp0 = 0
    nUp1 = 0
    Btn0 = None
    Btn1 = None
    nNum = 0
    nCnt = 0
    if (CVar.nTouch_Pos0 > 0) :
        nCnt = nCnt + 1
    if (CVar.nTouch_Pos1 > 0) :
        nCnt = nCnt + 1
    nPass = 0
    for btn in btns:
        if (CVar.nTouch_Pos0 > 0):
            if (IsButton(CVar.nTouch_XY_X0, CVar.nTouch_XY_Y0, btn) == True) :
                nNum0 = btn[_BTN_INDEX]
                Btn0 = btn
                nPass = nPass | 0x01
        if (CVar.nTouch_Pos1 > 0):
            if (IsButton(CVar.nTouch_XY_X1, CVar.nTouch_XY_Y1, btn) == True) :
                nNum1 = btn[_BTN_INDEX]
                Btn1 = btn
                nPass = nPass | 0x10
        if (nCnt == 1) :
            if (nPass > 0):
                break
        else:
            if (nPass == 0x11):
                break
        nNum = nNum + 1
    if ((nNum1 == nNum0) and (nNum0 >= 0)):
        nNum1 = -1
    if (((nNum0 >= 0) and (nNum0 == CVar.nButton_1)) or ((nNum1 >= 0) and (nNum1 == CVar.nButton_0))) :
        nNum2 = nNum1
        nNum1 = nNum0
        nNum0 = nNum2
    if (nNum0 >= 0):
        if (CVar.nButton_0 != nNum0):
            nDown0 = 1
        CVar.btn0 = Btn0
    else :
        if (CVar.nButton_0 >= 0):
            nUp0 = 1
    if (nNum1 >= 0):
        if (CVar.nButton_1 != nNum1):
            nDown1 = 1
        CVar.btn1 = Btn1
    else :
        if (CVar.nButton_1 >= 0):
            nUp1 = 1
    CVar.nButton_0 = nNum0
    CVar.nButton_1 = nNum1
    if nUp0 == 1:
        Btn0 = CVar.btn0
    if nUp1 == 1:
        Btn1 = CVar.btn1
    return nNum0, nNum1, nDown0, nDown1, nUp0, nUp1, Btn0, Btn1
console(USB)
eeprom.imu_type(1)
TorqAll(False)
DXL(254).write8(10, 4) 
DXL(254).write8(12, 255) 
DXL(254).mode(3) 
TorqAll(True)
TorqAll(False)
DXL(254).write8(10, 4) 
TorqAll(True)
nTest = 0 
nTest_BackgroundImage = 1
Move_Ready()
nDemoPos_X_0 = 55
nDemoPos_X_1 = 55
nDemoPos_X = nDemoPos_X_0
IsGrapped = False
while(True) :
    if (IsPhone == False) :
        if (smart.is_connected() == True):
            smart.wait_connected()
            smart.display.screen_orientation(2)
            delay(500)
            GetResolution()
            ShowPage(_PAGE_MAIN)
            ShowGage(2)
            IsPhone = True
    else :
        GetTouch_Down()
        if (nTest == 1) :
            Test1(nTest_BackgroundImage)
        else: 
            nNum0, nNum1, Event_Dn0, Event_Dn1, Event_Up0, Event_Up1, Btn0, Btn1 = GetButton(btnList)
            if (Btn0 == _BTN_DEMO) and (Event_Dn0):
                if CVar.nDemoMode != 0:
                    CVar.nDemoMode = 0
                    Move_Ready()
                else:
                    Move_Yaw(0, 10.0, True)
                    CVar.nDemoMode = 1
                    CVar.nDemoIndex = 0
                    IsGrapped = False
                    lstDemo = _MNT_DEMO
                    nStartPos_X = _INIT_FX + 20 
                    nStartPos_Y = _INIT_FY -20
                    nLength = 50 
                    nSpeed_Demo = 50
                    SetXY(0, _INIT_FY, nStartPos_X, 1000, False)
                    Wait(1000)
                    SetXY(0, nStartPos_Y, nStartPos_X, 1000, False)
                    Wait(1000)
                    for i in range(0, nLength, 2): 
                        SetXY(0, nStartPos_Y, nStartPos_X + i, nSpeed_Demo, False)
                        Wait(int(nSpeed_Demo * 0.8))
            if CVar.nDemoMode != 0:
                if (CVar.nDemoIndex == 0):
                    delay(100)
                    if (lstDemo == _MNT_DEMO):
                        lstDemo = _MNT_DEMO2
                    elif lstDemo == _MNT_DEMO2:
                        lstDemo = _MNT_DEMO
                        if (nDemoPos_X == nDemoPos_X_0):
                            nDemoPos_X = nDemoPos_X_1
                        else:
                            nDemoPos_X = nDemoPos_X_0
                    else:
                        lstDemo = _MNT_DEMO
                        if (nDemoPos_X == nDemoPos_X_0):
                            nDemoPos_X = nDemoPos_X_1
                        else:
                            nDemoPos_X = nDemoPos_X_0
                if (IsGrapped):
                    Move_Body_Step(lstDemo, CVar.nDemoIndex, False)
                    nGap_H = 0
                    nGap_F = 0
                    if (lstDemo[CVar.nDemoIndex][2] == -nDemoH_Default+nDemoH):
                        nGap_H = -5
                        nGap_F = 10
                    else:
                        nGap_H = +40
                        nGap_F = 0
                    SetXY(0, _INIT_FY + nGap_H, _INIT_FX + nDemoPos_X + nGap_F, lstDemo[CVar.nDemoIndex][0], False)
                    Delay_Body_Step(lstDemo, CVar.nDemoIndex, 0.8)
                    CVar.nDemoIndex = (CVar.nDemoIndex + 1) % len(lstDemo)
                else:
                    nLoad1 = abs(Get_Load(5))
                    #nLoad2 = abs(Get_Load(14))
                    if (nLoad1 < _LOAD_DEMO):# and (nLoad2 < _LOAD_DEMO) :
                        IMove_Gripper(5, 1.0, False)
                        #if (m_afHand[1] >= 25):
                        #    CVar.nDemoMode = 0 
                        #    Move_Ready()
                    else :
                        IsGrapped = True
            if (Event_Dn1 == 1):
                smart.etc.vibrate(10)
            elif (Event_Dn0 == 1):
                smart.etc.vibrate(10)
            nBtn_Left = 0
            nClick = 0
            if (Btn0 == _BTN_SPD_L1) or (Btn1 == _BTN_SPD_L1):
                nBtn_Left = 1
            elif (Btn0 == _BTN_SPD_L2) or (Btn1 == _BTN_SPD_L2):
                nBtn_Left = 2
            elif (Btn0 == _BTN_SPD_L3) or (Btn1 == _BTN_SPD_L3):
                nBtn_Left = 3
            elif (Btn0 == _BTN_SPD_L4) or (Btn1 == _BTN_SPD_L4):
                nBtn_Left = 4
            elif (Btn0 == _BTN_SPD_L5) or (Btn1 == _BTN_SPD_L5):
                nBtn_Left = 5
            if (nBtn_Left > 0):
                ShowGage(nBtn_Left)
            IsWalking = False
            nMove = -1
            if (Btn0 == _BTN_TURN_L) or (Btn1 == _BTN_TURN_L):
                #IsWalking = True
                #nMove = 3
                Move_Gripper_Turn(90)
            if (Btn0 == _BTN_TURN_R) or (Btn1 == _BTN_TURN_R):
                #IsWalking = True
                #nMove = 5
                Move_Gripper_Turn(-90)
            #if (Btn0 == _BTN_MOVE_UL) or (Btn1 == _BTN_MOVE_UL):
            #    IsWalking = True
            #    nMove = 0
            if (Btn0 == _BTN_MOVE_U) or (Btn1 == _BTN_MOVE_U):
                #IsWalking = True
                #nMove = 1
                Move_Gripper_Turn(0)
            #if (Btn0 == _BTN_MOVE_UR) or (Btn1 == _BTN_MOVE_UR):
            #    IsWalking = True
            #    nMove = 2
            #if (Btn0 == _BTN_MOVE_DL) or (Btn1 == _BTN_MOVE_DL):
            #    IsWalking = True
            #    nMove = 6
            if (Btn0 == _BTN_MOVE_D) or (Btn1 == _BTN_MOVE_D):
                #IsWalking = True
                #nMove = 7                
                Move_Gripper_Turn(180)
            #if (Btn0 == _BTN_MOVE_DR) or (Btn1 == _BTN_MOVE_DR):
            #    IsWalking = True
            #    nMove = 8
            if (nMove >= 0):
                if (CVar.IsWalking == False):
                    CVar.IsWalking = True
                    IDs = [9,10,15,16]
                    Move(IDs, [1000, 0, -85, -65, 30])
                MotionSet(nMove)
                Moves_Body(_MOTION, 1.0, 0.6)
            if CVar.IsWalking == True and IsWalking == False:
                CVar.IsWalking = False
                Move_Ready(0)
                Move_Ready_Arm()
            IsChangeSpeed = False
            if (Btn0 == _BTN_MOVE_X) or (Btn1 == _BTN_MOVE_X):
                if (Btn0 == _BTN_MOVE_X):
                    if (Event_Dn0):
                        IsChangeSpeed = True
                else:
                    if (Event_Dn1):
                        IsChangeSpeed = True
                if (IsChangeSpeed):
                    nSpeed = (nSpeed + 1) % 2
                    Show_Background(nSpeed + 1)
            fLength = (CVar.nPoint_L - 1) + 3
            nTime = int(50 + CVar.nPoint_L * 400 / 5) 
            if (Btn0 == _BTN_ARM_F) or (Btn1 == _BTN_ARM_F):
                fX = m_fX + fLength
                #print(fX)
                if (fX <= 805):
                    if SetXY(0, m_fY, fX, nTime) == True:
                        m_fX = m_fX + fLength
            if (Btn0 == _BTN_ARM_B) or (Btn1 == _BTN_ARM_B):
                fX = m_fX - fLength
                if (fX >= _INIT_FX):
                    if SetXY(0, m_fY, fX, nTime) == True:
                        m_fX = m_fX - fLength
            if (Btn0 == _BTN_ARM_ORG) or (Btn1 == _BTN_ARM_ORG):
                Move_Ready_Arm()
            if (Btn0 == _BTN_ARM_UP) or (Btn1 == _BTN_ARM_UP):
                fY = m_fY + fLength
                if SetXY(0, fY, m_fX, nTime) == True:
                    m_fY = m_fY + fLength
            if (Btn0 == _BTN_ARM_DN) or (Btn1 == _BTN_ARM_DN):
                fY = m_fY - fLength
                if (fY >= 0):
                    if SetXY(0, fY, m_fX, nTime) == True:
                        m_fY = m_fY - fLength
            nMulti = 0.3
            if (Btn0 == _BTN_ARM_LEFT) or (Btn1 == _BTN_ARM_LEFT):
                IMove_Yaw(CVar.nPoint_L * -nMulti)
            if (Btn0 == _BTN_ARM_RIGHT) or (Btn1 == _BTN_ARM_RIGHT):
                IMove_Yaw(CVar.nPoint_L * nMulti)
            if (Btn0 == _BTN_HAND_IN) or (Btn1 == _BTN_HAND_IN):
                nLoad1 = abs(Get_Load(5))
                if (nLoad1 < _LOAD) :
                    IMove_Gripper(CVar.nPoint_L * nMulti)
            if (Btn0 == _BTN_HAND_ORG) or (Btn1 == _BTN_HAND_ORG):
                Move_Gripper(-20, 10)
            if (Btn0 == _BTN_HAND_OUT) or (Btn1 == _BTN_HAND_OUT):
                IMove_Gripper(CVar.nPoint_L * -nMulti)
            if (Btn0 == _BTN_TORQ):
                if Event_Dn0 == 1:
                    tmrTorqBtn.Set()
                    if (CVar.IsTorqOn == True):
                        TorqAll(False, True)
                    else :
                        TorqAll(True, True)
                        Move_Ready(0)
                elif Event_Up0 == 1:
                    tmrTorqBtn.Destroy()
                else:
                    if (tmrTorqBtn.Get() >= 3000):
                        dxlbus.reboot()
                        buzzer.melody(1)
                        CVar.IsTorqOn = False
                        tmrTorqBtn.Destroy()
