object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 544
  ClientWidth = 792
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  OnResize = FormResize
  DesignSize = (
    792
    544)
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 8
    Top = 136
    Width = 793
    Height = 400
    Anchors = [akLeft, akTop, akRight, akBottom]
    Caption = 'Panel1'
    TabOrder = 0
  end
  object Edit1: TEdit
    Left = 8
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 1
    Text = '0'
    OnChange = Edit1Change
  end
  object UpDown1: TUpDown
    Left = 129
    Top = 64
    Width = 16
    Height = 21
    Associate = Edit1
    Min = -360
    Max = 360
    Increment = 10
    TabOrder = 2
  end
  object Button1: TButton
    Left = 688
    Top = 60
    Width = 75
    Height = 25
    Caption = 'Paint'
    TabOrder = 3
    OnClick = Button1Click
  end
  object Edit2: TEdit
    Left = 234
    Top = 37
    Width = 121
    Height = 21
    TabOrder = 4
    Text = '1'
    OnChange = Edit2Change
  end
  object UpDown2: TUpDown
    Left = 355
    Top = 37
    Width = 16
    Height = 21
    Associate = Edit2
    Min = 1
    Position = 1
    TabOrder = 5
  end
  object CheckBox4: TCheckBox
    Left = 160
    Top = 32
    Width = 33
    Height = 17
    Caption = 'X'
    TabOrder = 6
  end
  object CheckBox5: TCheckBox
    Left = 160
    Top = 64
    Width = 33
    Height = 17
    Caption = 'Y'
    TabOrder = 7
  end
  object CheckBox6: TCheckBox
    Left = 160
    Top = 96
    Width = 33
    Height = 17
    Caption = 'Z'
    TabOrder = 8
  end
  object Edit3: TEdit
    Left = 234
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 9
    Text = '1'
    OnChange = Edit2Change
  end
  object Edit4: TEdit
    Left = 234
    Top = 91
    Width = 121
    Height = 21
    TabOrder = 10
    Text = '1'
    OnChange = Edit2Change
  end
  object textX: TStaticText
    Left = 377
    Top = 41
    Width = 10
    Height = 17
    Caption = 'X'
    TabOrder = 11
  end
  object StaticText1: TStaticText
    Left = 377
    Top = 68
    Width = 10
    Height = 17
    Caption = 'Y'
    TabOrder = 12
  end
  object StaticText2: TStaticText
    Left = 377
    Top = 96
    Width = 10
    Height = 17
    Caption = 'Z'
    TabOrder = 13
  end
  object UpDown3: TUpDown
    Left = 355
    Top = 64
    Width = 16
    Height = 21
    Associate = Edit3
    Min = 1
    Position = 1
    TabOrder = 14
  end
  object UpDown4: TUpDown
    Left = 355
    Top = 91
    Width = 16
    Height = 21
    Associate = Edit4
    Min = 1
    Position = 1
    TabOrder = 15
  end
  object Edit5: TEdit
    Left = 458
    Top = 37
    Width = 121
    Height = 21
    TabOrder = 16
    Text = '1'
    OnChange = Edit2Change
  end
  object UpDown5: TUpDown
    Left = 579
    Top = 37
    Width = 16
    Height = 21
    Associate = Edit5
    Min = -200
    Max = 200
    Increment = 10
    Position = 1
    TabOrder = 17
  end
  object Edit6: TEdit
    Left = 458
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 18
    Text = '1'
    OnChange = Edit2Change
  end
  object Edit7: TEdit
    Left = 458
    Top = 91
    Width = 121
    Height = 21
    TabOrder = 19
    Text = '1'
    OnChange = Edit2Change
  end
  object StaticText3: TStaticText
    Left = 601
    Top = 41
    Width = 10
    Height = 17
    Caption = 'X'
    TabOrder = 20
  end
  object StaticText4: TStaticText
    Left = 601
    Top = 68
    Width = 10
    Height = 17
    Caption = 'Y'
    TabOrder = 21
  end
  object StaticText5: TStaticText
    Left = 601
    Top = 96
    Width = 10
    Height = 17
    Caption = 'Z'
    TabOrder = 22
  end
  object UpDown6: TUpDown
    Left = 579
    Top = 64
    Width = 16
    Height = 21
    Associate = Edit6
    Min = -200
    Max = 200
    Increment = 10
    Position = 1
    TabOrder = 23
  end
  object UpDown7: TUpDown
    Left = 579
    Top = 91
    Width = 16
    Height = 21
    Associate = Edit7
    Min = -200
    Max = 200
    Increment = 10
    Position = 1
    TabOrder = 24
  end
  object StaticText6: TStaticText
    Left = 32
    Top = 41
    Width = 79
    Height = 17
    Caption = #1059#1075#1086#1083' '#1087#1086#1074#1086#1088#1086#1090#1072
    TabOrder = 25
  end
  object StaticText7: TStaticText
    Left = 256
    Top = 14
    Width = 97
    Height = 17
    Caption = #1052#1072#1089#1096#1090#1072#1073#1080#1088#1086#1074#1072#1085#1080#1077
    TabOrder = 26
  end
  object StaticText8: TStaticText
    Left = 488
    Top = 14
    Width = 73
    Height = 17
    Caption = #1055#1077#1088#1077#1084#1077#1096#1077#1085#1080#1077
    TabOrder = 27
  end
end
