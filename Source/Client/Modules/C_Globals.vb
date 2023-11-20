﻿Imports Core
Imports Mirage.Sharp.Asfw.IO.Encryption

Module C_Globals
    ' Global dialogue index
    Public diaHeader As String
    Public diaBody As String
    Public diaBody2 As String
    Public diaIndex As Long
    Public diaData1 As Long
    Public diaDataString As String
    Public diaStyle As Byte

    ' Char creation/selecting
    Public SelectedChar As Byte

    ' Directional blocking
    Public DirArrowX(4) As Byte
    Public DirArrowY(4) As Byte

    Public UseFade As Boolean
    Public FadeType As Integer
    Public FadeAmount As Integer
    Public FlashTimer As Integer

    ' Targetting
    Public MyTarget As Integer
    Public MyTargetType As Integer

    ' Chat bubble
    Public ChatBubble(Byte.MaxValue) As ChatBubbleStruct
    Public ChatBubbleindex As Integer

    ' Skill drag + drop
    Public DragSkillSlotNum As Integer

    Public SkillX As Integer
    Public SkillY As Integer

    ' Gui
    Public EqX As Integer

    Public EqY As Integer
    Public Fps As Integer
    Public Lps As Integer
    Public PingToDraw As String
    Public ShowRClick As Boolean

    Public LastSkillDesc As Integer ' Stores the last skill we showed in desc

    Public TmpCurrencyItem As Integer

    Public CurrencyMenu As Byte
    Public HideGui As Boolean

    ' Player variables
    Public Myindex As Integer ' Index of actual player

    Public InventoryItemSelected As Integer
    Public SkillBuffer As Integer
    Public SkillBufferTimer As Integer
    Public StunDuration As Integer
    Public NextlevelExp As Integer

    ' Stops movement when updating a map
    Public CanMoveNow As Boolean

    ' Controls main gameloop
    Public InGame As Boolean

    Public IsLogging As Boolean
    Public MapData As Boolean
    Public PlayerData As Boolean

    ' Draw map name location
    Public DrawMapNameX As Single = 80
    Public DrawMapNameY As Single = 70
    Public DrawMapNameColor As SFML.Graphics.Color

    ' Game direction vars
    Public DirUp As Boolean
    Public DirDown As Boolean
    Public DirLeft As Boolean
    Public DirRight As Boolean

    ' Used for dragging Picture Boxes
    Public SOffsetX As Integer
    Public SOffsetY As Integer

    ' Used to freeze controls when getting a new map
    Public GettingMap As Boolean

    ' Used to check if FPS needs to be drawn
    Public Bfps As Boolean

    Public Blps As Boolean
    Public BLoc As Boolean

    ' FPS and Time-based movement vars
    Public ElapsedTime As Integer
    Public GameFps As Integer
    Public GameLps As Integer

    ' Text vars
    Public VbQuote As String

    ' Mouse cursor tile location
    Public CurX As Integer
    Public CurY As Integer
    Public CurMouseX As Integer
    Public CurMouseY As Integer

    ' Game editors
    Public Editor As Integer
    Public Editorindex As Integer

    ' Spawn
    Public SpawnNpcNum As Integer
    Public SpawnNpcDir As Integer

    ' Items
    Public ItemEditorNum As Integer
    Public ItemEditorValue As Integer

    ' Resources
    Public ResourceEditorNum As Integer

    ' Used for map editor heal & trap & slide tiles
    Public MapEditorHealType As Integer
    Public MapEditorHealAmount As Integer
    Public MapEditorSlideDir As Integer

    Public Camera As Rectangle
    Public TileView As RectStruct

    ' Pinging
    Public PingStart As Integer

    Public PingEnd As Integer
    Public Ping As Integer

    ' indexing
    Public ActionMsgIndex As Byte

    Public BloodIndex As Byte

    ' New char
    Public NewCharJob As Integer

    Public TempMapData() As Byte

    'dialog
    Public DialogType As Byte

    Public DialogMsg1 As String
    Public DialogMsg2 As String
    Public DialogMsg3 As String
    Public UpdateDialog As Boolean
    Public DialogButton1Text As String
    Public DialogButton2Text As String

    Public ShakeTimerEnabled As Boolean
    Public ShakeTimer As Integer
    Public ShakeCount As Byte
    Public LastDir As Byte

    Public ShowAnimLayers As Boolean
    Public ShowAnimTimer As Integer

    Public EKeyPair As New KeyPair()

    ' Stream Content
    Public Item_Loaded(MAX_ITEMS)
    Public NPC_Loaded(MAX_NPCS)
    Public Resource_Loaded(MAX_RESOURCES)
    Public Animation_Loaded(MAX_ANIMATIONS)
    Public Skill_Loaded(MAX_SKILLS)
    Public Shop_Loaded(MAX_SHOPS)
    Public Pet_Loaded(MAX_PETS)

    ' Editor edited items array
    Public Item_Changed(MAX_ITEMS) As Boolean
    Public NPC_Changed(MAX_NPCS) As Boolean
    Public Resource_Changed(MAX_RESOURCES) As Boolean
    Public Animation_Changed(MAX_ANIMATIONS) As Boolean
    Public Skill_Changed(MAX_SKILLS) As Boolean
    Public Shop_Changed(MAX_SHOPS) As Boolean
    Public Pet_Changed(MAX_PETS) As Boolean
    Public Job_Changed(MAX_JOBS) As Boolean

    Public AnimEditorFrame(1) As Integer
    Public AnimEditorTimer(1) As Integer

    'Editors
    Public InitEditor As Boolean
    Public InitMapEditor As Boolean
    Public InitPetEditor As Boolean
    Public InitItemEditor As Boolean
    Public InitResourceEditor As Boolean
    Public InitNPCEditor As Boolean
    Public InitSkillEditor As Boolean
    Public InitShopEditor As Boolean
    Public InitAnimationEditor As Boolean
    Public InitJobEditor As Boolean
    Public InitQuestEditor As Boolean
End Module