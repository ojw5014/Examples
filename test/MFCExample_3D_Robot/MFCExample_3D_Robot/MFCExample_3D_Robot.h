
// MFCExample_3D_Robot.h : PROJECT_NAME 응용 프로그램에 대한 주 헤더 파일입니다.
//

#pragma once

#ifndef __AFXWIN_H__
	#error "PCH에 대해 이 파일을 포함하기 전에 'stdafx.h'를 포함합니다."
#endif

#include "resource.h"		// 주 기호입니다.


// CMFCExample_3D_RobotApp:
// 이 클래스의 구현에 대해서는 MFCExample_3D_Robot.cpp을 참조하십시오.
//

class CMFCExample_3D_RobotApp : public CWinApp
{
public:
	CMFCExample_3D_RobotApp();

// 재정의입니다.
public:
	virtual BOOL InitInstance();

// 구현입니다.

	DECLARE_MESSAGE_MAP()
};

extern CMFCExample_3D_RobotApp theApp;