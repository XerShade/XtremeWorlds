﻿Imports System.IO
Imports System.Windows.Forms
Imports Core

Friend Class frmEditor_NPC

#Region "Form Code"

    Private Sub frmEditor_NPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudSprite.Maximum = GameState.NumCharacters

        lstIndex.Items.Clear()

        ' Add the names
        For i = 1 To MAX_NPCS
            lstIndex.Items.Add(i & ": " & Trim$(NPC(i).Name))
        Next

        'populate combo boxes
        cmbAnimation.Items.Clear()
        cmbAnimation.Items.Add("None")
        For i = 1 To MAX_ANIMATIONS
            cmbAnimation.Items.Add(i & ": " & Type.Animation(i).Name)
        Next

        cmbSkill1.Items.Clear()
        cmbSkill1.Items.Add("None")
        cmbSkill2.Items.Clear()
        cmbSkill2.Items.Add("None")
        cmbSkill3.Items.Clear()
        cmbSkill3.Items.Add("None")
        cmbSkill4.Items.Clear()
        cmbSkill4.Items.Add("None")
        cmbSkill5.Items.Clear()
        cmbSkill5.Items.Add("None")
        cmbSkill6.Items.Clear()
        cmbSkill6.Items.Add("None")
        For i = 1 To MAX_SKILLS
            cmbSkill1.Items.Add(i & ": " & Skill(i).Name)
            cmbSkill2.Items.Add(i & ": " & Skill(i).Name)
            cmbSkill3.Items.Add(i & ": " & Skill(i).Name)
            cmbSkill4.Items.Add(i & ": " & Skill(i).Name)
            cmbSkill5.Items.Add(i & ": " & Skill(i).Name)
            cmbSkill6.Items.Add(i & ": " & Skill(i).Name)
        Next

        cmbItem.Items.Clear()
        cmbItem.Items.Add("None")
        For i = 1 To MAX_ITEMS
            cmbItem.Items.Add(i & ": " & Type.Item(i).Name)
        Next
    End Sub

    Private Sub DrawSprite()
        Dim Sprite As Integer

        Sprite = nudSprite.Value

        If Sprite < 1 Or Sprite > GameState.NumCharacters Then
            picSprite.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(IO.Path.Combine(Core.Path.Characters, Sprite & GameState.GfxExt)) Then
            picSprite.Width =
                Drawing.Image.FromFile(IO.Path.Combine(Core.Path.Characters, Sprite & GameState.GfxExt)).Width / 4
            picSprite.Height =
                Drawing.Image.FromFile(IO.Path.Combine(Sprite, GameState.GfxExt)).Height / 4
            picSprite.BackgroundImage =
                Drawing.Image.FromFile(IO.Path.Combine(Core.Path.Characters, Sprite & GameState.GfxExt))
        End If
    End Sub

    Private Sub lstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        NpcEditorInit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        NpcEditorOk()
        Dispose()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearNPC(GameState.EditorIndex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(GameState.EditorIndex - 1)
        lstIndex.Items.Insert(GameState.EditorIndex - 1, GameState.EditorIndex & ": " & NPC(GameState.EditorIndex).Name)
        lstIndex.SelectedIndex = tmpindex

        NpcEditorInit()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        NpcEditorCancel()
        Dispose()
    End Sub

#End Region

#Region "Properties"

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer

        tmpindex = lstIndex.SelectedIndex
        NPC(GameState.EditorIndex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(GameState.EditorIndex - 1)
        lstIndex.Items.Insert(GameState.EditorIndex - 1, GameState.EditorIndex & ": " & NPC(GameState.EditorIndex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub TxtAttackSay_TextChanged(sender As Object, e As EventArgs) Handles txtAttackSay.TextChanged
        NPC(GameState.EditorIndex).AttackSay = txtAttackSay.Text
    End Sub

    Private Sub NudSprite_Click(sender As Object, e As EventArgs) Handles nudSprite.Click
        NPC(GameState.EditorIndex).Sprite = nudSprite.Value

        DrawSprite()
    End Sub

    Private Sub NudRange_ValueChanged(sender As Object, e As EventArgs) Handles nudRange.ValueChanged
        NPC(GameState.EditorIndex).Range = nudRange.Value
    End Sub

    Private Sub CmbBehavior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBehaviour.SelectedIndexChanged
        NPC(GameState.EditorIndex).Behaviour = cmbBehaviour.SelectedIndex
    End Sub

    Private Sub CmbFaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFaction.SelectedIndexChanged
        NPC(GameState.EditorIndex).Faction = cmbFaction.SelectedIndex
    End Sub

    Private Sub CmbAnimation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnimation.SelectedIndexChanged
        NPC(GameState.EditorIndex).Animation = cmbAnimation.SelectedIndex
    End Sub

    Private Sub NudSpawnSecs_ValueChanged(sender As Object, e As EventArgs) Handles nudSpawnSecs.ValueChanged
        NPC(GameState.EditorIndex).SpawnSecs = nudSpawnSecs.Value
    End Sub

    Private Sub NudHp_ValueChanged(sender As Object, e As EventArgs) Handles nudHp.ValueChanged
        NPC(GameState.EditorIndex).HP = nudHp.Value
    End Sub

    Private Sub NudExp_ValueChanged(sender As Object, e As EventArgs) Handles nudExp.ValueChanged
        NPC(GameState.EditorIndex).Exp = nudExp.Value
    End Sub

    Private Sub NudLevel_ValueChanged(sender As Object, e As EventArgs) Handles nudLevel.ValueChanged
        NPC(GameState.EditorIndex).Level = nudLevel.Value
    End Sub

    Private Sub NudDamage_ValueChanged(sender As Object, e As EventArgs) Handles nudDamage.ValueChanged
        NPC(GameState.EditorIndex).Damage = nudDamage.Value
    End Sub

    Private Sub CmbSpawnPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSpawnPeriod.SelectedIndexChanged
        NPC(GameState.EditorIndex).SpawnTime = cmbSpawnPeriod.SelectedIndex
    End Sub

#End Region

#Region "Stats"

    Private Sub NudStrength_ValueChanged(sender As Object, e As EventArgs) Handles nudStrength.ValueChanged
        NPC(GameState.EditorIndex).Stat(StatType.Strength) = nudStrength.Value
    End Sub

    Private Sub NudVitality_ValueChanged(sender As Object, e As EventArgs) Handles nudVitality.ValueChanged
        NPC(GameState.EditorIndex).Stat(StatType.Vitality) = nudVitality.Value
    End Sub

    Private Sub NudLuck_ValueChanged(sender As Object, e As EventArgs) Handles nudLuck.ValueChanged
        NPC(GameState.EditorIndex).Stat(StatType.Luck) = nudLuck.Value
    End Sub

    Private Sub NudIntelligence_ValueChanged(sender As Object, e As EventArgs) Handles nudIntelligence.ValueChanged
        NPC(GameState.EditorIndex).Stat(StatType.Intelligence) = nudIntelligence.Value
    End Sub

    Private Sub NudSpirit_ValueChanged(sender As Object, e As EventArgs) Handles nudSpirit.ValueChanged
        NPC(GameState.EditorIndex).Stat(StatType.Spirit) = nudSpirit.Value
    End Sub

#End Region

#Region "Drop Items"

    Private Sub CmbDropSlot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDropSlot.SelectedIndexChanged
        cmbItem.SelectedIndex = NPC(GameState.EditorIndex).DropItem(cmbDropSlot.SelectedIndex)

        nudAmount.Value = NPC(GameState.EditorIndex).DropItemValue(cmbDropSlot.SelectedIndex)

        nudChance.Value = NPC(GameState.EditorIndex).DropChance(cmbDropSlot.SelectedIndex)
    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItem.SelectedIndexChanged
        NPC(GameState.EditorIndex).DropItem(cmbDropSlot.SelectedIndex) = cmbItem.SelectedIndex
    End Sub

    Private Sub ScrlValue_Scroll(sender As Object, e As EventArgs) Handles nudAmount.ValueChanged
        NPC(GameState.EditorIndex).DropItemValue(cmbDropSlot.SelectedIndex) = nudAmount.Value
    End Sub

    Private Sub NudChance_ValueChanged(sender As Object, e As EventArgs) Handles nudChance.ValueChanged
        NPC(GameState.EditorIndex).DropChance(cmbDropSlot.SelectedIndex) = nudChance.Value
    End Sub

#End Region

#Region "Skills"

    Private Sub CmbSkill1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill1.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(1) = cmbSkill1.SelectedIndex
    End Sub

    Private Sub CmbSkill2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill2.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(2) = cmbSkill2.SelectedIndex
    End Sub

    Private Sub CmbSkill3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill3.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(3) = cmbSkill3.SelectedIndex
    End Sub

    Private Sub CmbSkill4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill4.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(4) = cmbSkill4.SelectedIndex
    End Sub

    Private Sub CmbSkill5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill5.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(5) = cmbSkill5.SelectedIndex
    End Sub

    Private Sub CmbSkill6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSkill6.SelectedIndexChanged
        NPC(GameState.EditorIndex).Skill(6) = cmbSkill6.SelectedIndex
    End Sub

    Private Sub frmEditor_NPC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NpcEditorCancel()
    End Sub

#End Region

End Class