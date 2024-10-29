﻿Imports System.Drawing
Imports System.IO
Imports Mirage.Sharp.Asfw
Imports Core

Module Resource

#Region "Database"

    Sub ClearResource(index As Integer)
        Type.Resource(index) = Nothing
        Type.Resource(index).Name = ""
        GameState.Resource_Loaded(index) = 0
    End Sub

    Sub ClearResources()
        Dim i As Integer

       For i = 1 To MAX_RESOURCES
            ClearResource(i)
        Next

    End Sub

    Sub StreamResource(resourceNum As Integer)
        If resourceNum > 0 And Type.Resource(resourceNum).Name = "" Or GameState.Resource_Loaded(resourceNum) = 0 Then
            GameState.Resource_Loaded(resourceNum) = 1
            SendRequestResource(resourceNum)
        End If
    End Sub

#End Region

#Region "Incoming Packets"

    Sub Packet_MapResource(ByRef data() As Byte)
        Dim i As Integer
        Dim buffer As New ByteStream(data)
        GameState.ResourceIndex = buffer.ReadInt32
        GameState.ResourcesInit = 0

        If GameState.ResourceIndex > 0 Then
            ReDim Preserve MapResource(GameState.ResourceIndex)

            For i = 0 To GameState.ResourceIndex
                MyMapResource(i).State = buffer.ReadByte
                MyMapResource(i).X = buffer.ReadInt32
                MyMapResource(i).Y = buffer.ReadInt32
            Next

            GameState.ResourcesInit = 1
        End If

        buffer.Dispose()
    End Sub

    Sub Packet_UpdateResource(ByRef data() As Byte)
        Dim resourceNum As Integer
        Dim buffer As New ByteStream(data)
        resourceNum = buffer.ReadInt32

        Type.Resource(resourceNum).Animation = buffer.ReadInt32()
        Type.Resource(resourceNum).EmptyMessage = buffer.ReadString()
        Type.Resource(resourceNum).ExhaustedImage = buffer.ReadInt32()
        Type.Resource(resourceNum).Health = buffer.ReadInt32()
        Type.Resource(resourceNum).ExpReward = buffer.ReadInt32()
        Type.Resource(resourceNum).ItemReward = buffer.ReadInt32()
        Type.Resource(resourceNum).Name = buffer.ReadString()
        Type.Resource(resourceNum).ResourceImage = buffer.ReadInt32()
        Type.Resource(resourceNum).ResourceType = buffer.ReadInt32()
        Type.Resource(resourceNum).RespawnTime = buffer.ReadInt32()
        Type.Resource(resourceNum).SuccessMessage = buffer.ReadString()
        Type.Resource(resourceNum).LvlRequired = buffer.ReadInt32()
        Type.Resource(resourceNum).ToolRequired = buffer.ReadInt32()
        Type.Resource(resourceNum).Walkthrough = buffer.ReadInt32()

        buffer.Dispose()
    End Sub

#End Region

#Region "Outgoing Packets"

    Sub SendRequestResource(resourceNum As Integer)
        Dim buffer As New ByteStream(4)

        buffer.WriteInt32(ClientPackets.CRequestResource)

        buffer.WriteInt32(resourcenum)
        Socket.SendData(buffer.Data, buffer.Head)
        buffer.Dispose()
    End Sub

#End Region

#Region "Drawing"

    Friend Sub DrawResource(resource As Integer, dx As Integer, dy As Integer, rec As Rectangle)
        Dim x As Integer
        Dim y As Integer
        Dim width As Integer
        Dim height As Integer

        If resource < 1 Or resource > GameState.NumResources Then Exit Sub

        x = ConvertMapX(dx)
        y = ConvertMapY(dy)
        width = (rec.Right - rec.Left)
        height = (rec.Bottom - rec.Top)

        If rec.Width < 0 Or rec.Height < 0 Then Exit Sub

        GameClient.RenderTexture(System.IO.Path.Combine(Core.Path.Resources, resource), x, y, rec.X, rec.Y, rec.Width, rec.Height, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawMapResource(resourceNum As Integer)
        Dim resourceMaster As Integer

        Dim resourceState As Integer
        Dim resourceSprite As Integer
        Dim rec As Rectangle
        Dim x As Integer, y As Integer

        If GameState.GettingMap Then Exit Sub
        If GameState.MapData = 0 Then Exit Sub

        If MyMapResource(resourceNum).X > MyMap.MaxX Or MyMapResource(resourceNum).Y > MyMap.MaxY Then Exit Sub

        ' Get the Resource type
        resourceMaster = MyMap.Tile(MyMapResource(resourceNum).X, MyMapResource(resourceNum).Y).Data1

        If resourceMaster = 0 Then Exit Sub

        If Type.Resource(resourceMaster).ResourceImage = 0 Then Exit Sub

        StreamResource(resourceMaster)

        ' Get the Resource state
        resourceState = MyMapResource(resourceNum).State

        If resourceState = 0 Then ' normal
            resourceSprite = Type.Resource(resourceMaster).ResourceImage
        ElseIf resourceState = 1 Then ' used
            resourceSprite = Type.Resource(resourceMaster).ExhaustedImage
        End If

        ' src rect
        With rec
            .Y = 0
            .Height = GameClient.GetGfxInfo(System.IO.Path.Combine(Core.Path.Resources, resourceSprite)).Height
            .X = 0
            .Width = GameClient.GetGfxInfo(System.IO.Path.Combine(Core.Path.Resources, resourceSprite)).Width
        End With

        ' Set base x + y, then the offset due to size
        x = (MyMapResource(resourceNum).X * GameState.PicX) - (GameClient.GetGfxInfo(System.IO.Path.Combine(Core.Path.Resources, resourceSprite)).Width / 2) + 16
        y = (MyMapResource(resourceNum).Y * GameState.PicY) - GameClient.GetGfxInfo(System.IO.Path.Combine(Core.Path.Resources, resourceSprite)).Height + 32

        DrawResource(resourceSprite, x, y, rec)
    End Sub

#End Region

End Module