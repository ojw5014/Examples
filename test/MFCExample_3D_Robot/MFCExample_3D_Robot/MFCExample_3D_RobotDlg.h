
// MFCExample_3D_RobotDlg.h : 헤더 파일
//

#pragma once


// CMFCExample_3D_RobotDlg 대화 상자
class CMFCExample_3D_RobotDlg : public CDialogEx
{
// 생성입니다.
public:
	CMFCExample_3D_RobotDlg(CWnd* pParent = NULL);	// 표준 생성자입니다.

// 대화 상자 데이터입니다.
	enum { IDD = IDD_MFCEXAMPLE_3D_ROBOT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 지원입니다.


// 구현입니다.
protected:
	HICON m_hIcon;

	// 생성된 메시지 맵 함수
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
};
