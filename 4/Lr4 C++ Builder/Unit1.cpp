// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::FormResize(TObject *Sender) {
	GLfloat nRange = 300.0; // ������ ������� � ������� �����������
	// ������� ������ ��� ���� � ���������� �����������
	glViewport(0, 0, Panel1->Width, Panel1->Height);
	// ��������� ������� �������������
	glMatrixMode(GL_PROJECTION);
	// ����� �������
	glLoadIdentity();
	// ��������� ������������� �������� �� �������� ����
	if (Panel1->Width <= Panel1->Height)
		glOrtho(-nRange, nRange, -nRange*Panel1->Height / Panel1->Width,
		nRange*Panel1->Height / Panel1->Width, -nRange * 2, nRange * 2);
	else
		glOrtho(-nRange*Panel1->Width / Panel1->Height,
		nRange*Panel1->Width / Panel1->Height, -nRange, nRange, -2 * nRange,
		nRange * 2);
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::FormCreate(TObject *Sender) {
	// ���������� ������ � ������������� �������
	_control87(MCW_EM, MCW_EM);
	// ��������� ��������� ���� ���������� Panel1
	HDC hdc = GetDC(Panel1->Handle);
	// ��������� ������� ��������
	PIXELFORMATDESCRIPTOR pfd = {
		sizeof(PIXELFORMATDESCRIPTOR), 1,
		PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER,
		PFD_TYPE_RGBA, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0,
		PFD_MAIN_PLANE, 0, 0, 0, 0};
	int PixelFormat = ChoosePixelFormat(hdc, &pfd);
	SetPixelFormat(hdc, PixelFormat, &pfd);
	// �������� ��������� ����������� �� ���������� Panel1
	HGLRC hrc = wglCreateContext(hdc);
	wglMakeCurrent(hdc, hrc);

}

// ---------------------------------------------------------------------------
void TForm1::PaintIt() {
	// ��������� ������������ ������������ OpenGL
	glEnable(GL_COLOR_MATERIAL); // ��������� ������ ��������� ��������
	glEnable(GL_DEPTH_TEST); // �������� ������� ������ �������
	glEnable(GL_LIGHTING); // ������������ ���������
	glEnable(GL_LIGHT1); // �������� �������� ����� 1
	glShadeModel(GL_SMOOTH); // ��������� ������� �������� �����������
	// ������������� ������� ������
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	// ��������� ��������� �����
	GLfloat light1_diffuse[] = {4, 7, 2};
	GLfloat light1_position[] = {100.0, 100.0, 100.0, 1.0};
	glLightfv(GL_LIGHT1, GL_DIFFUSE, light1_diffuse);
	glLightfv(GL_LIGHT1, GL_POSITION, light1_position);
	// ��������� ���������� �������������� ��������
	// ������� �������� �� ���� �������� � Edit1, ������ ������� (1,1,1)
	glRotatef(Edit1->Text.ToDouble(), CheckBox4->Checked, CheckBox5->Checked, CheckBox6->Checked);
	// ��������� �������� �� �������� � Edit2 �� ���� ����
	glScalef(Edit2->Text.ToDouble()/2, Edit3->Text.ToDouble()/2,
		Edit4->Text.ToDouble()/2);
	//����������� �� ���� ����
	glTranslatef(Edit5->Text.ToDouble(), Edit6->Text.ToDouble(),
		Edit7->Text.ToDouble());
	// ����������� �� ��� �
	glTranslatef(-100, 0, 0);
	// �������� �������� �����������
	// ������� ����� ������
	glClearColor(1, 1, 1, 1);
	glClear(GL_DEPTH_BUFFER_BIT | GL_COLOR_BUFFER_BIT);
	GLUquadricObj *quadObj = gluNewQuadric();
	// �������� ����� �������� �����
	// glColor3f(1, 0, 0);
	// gluSphere(quadObj, 50, 50, 10);
	// ����������� ������ ���������
	glTranslatef(-100, 0, 0);
	// �������� ������
	glColor3f(0, 1, 0);
	gluCylinder(quadObj, 50, 50, 100, 100, 100);
	glTranslatef(200, 0, 0);

	gluCylinder(quadObj, 50, 50, 100, 100, 100);
	glTranslatef(200, 0, 0);

	gluCylinder(quadObj, 50, 50, 100, 100, 100);
	glTranslatef(200, 0, 0);

	gluCylinder(quadObj, 50, 50, 100, 100, 100);
	glTranslatef(-700, -50, -100);

	// �������� ��������������� �� ������
	glBegin(GL_QUADS);
	glColor3f(1, 0, 0);
	// �� ������ ������� �� �����
	glVertex3f(0, 0, 0);
	glVertex3f(0, 100, 0);
	glVertex3f(800, 100, 0);
	glVertex3f(800, 0, 0);
	glColor3f(1, 0, 0);
	glVertex3f(800, 0, 100);
	glVertex3f(800, 100, 100);
	glVertex3f(0, 100, 100);
	glVertex3f(0, 0, 100);
	glColor3f(1, 0, 1);
	glVertex3f(0, 0, 0);
	glVertex3f(0, 0, 100);
	glVertex3f(0, 100, 100);
	glVertex3f(0, 100, 0);
	glVertex3f(800, 0, 0);
	glVertex3f(800, 0, 100);
	glVertex3f(800, 100, 100);
	glVertex3f(800, 100, 0);
	glColor3f(1, 0, 0);
	glVertex3f(0, 0, 0);
	glVertex3f(0, 0, 50);
	glVertex3f(800, 0, 100);
	glVertex3f(800, 0, 0);
	glVertex3f(0, 100, 0);
	glVertex3f(0, 100, 100);
	glVertex3f(800, 100, 100);
	glVertex3f(800, 100, 0);
	glEnd();
	// -------------------
	glTranslatef(0, 0, 200);
	glBegin(GL_QUADS);
	glColor3f(0, 0, 1);

	glVertex3f(0, 0, 0);
	glVertex3f(800, 0, 0);
	glVertex3f(800, 100, 0);
	glVertex3f(0, 100, 0);

	glColor3f(0, 0, 1);
	glVertex3f(0, 0, 0);
	glVertex3f(400, 0, 100);
	glVertex3f(400, 100, 100);
	glVertex3f(0, 100, 0);

	glColor3f(0, 0, 1);
	glVertex3f(800, 0, 0);
	glVertex3f(800, 100, 0);
	glVertex3f(400, 100, 100);
	glVertex3f(400, 0, 100);

	glEnd();
	// ---------------------
	glBegin(GL_TRIANGLES);
	glColor3f(0, 0, 1);
	glVertex3f(0, 0, 0);
	glVertex3f(400, 0, 100);
	glVertex3f(800, 0, 0);

	glColor3f(0, 0, 1);
	glVertex3f(0, 100, 0);
	glVertex3f(800, 100, 0);
	glVertex3f(400, 100, 100);
	glEnd();
	// ����� ������ � ������������
	SwapBuffers(GetDC(Panel1->Handle));
}

void __fastcall TForm1::Button1Click(TObject *Sender) {
	PaintIt();
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Edit1Change(TObject *Sender) {
	PaintIt();
}
// ---------------------------------------------------------------------------
void __fastcall TForm1::Edit2Change(TObject *Sender)
{
	PaintIt();
}
//---------------------------------------------------------------------------


//---------------------------------------------------------------------------
