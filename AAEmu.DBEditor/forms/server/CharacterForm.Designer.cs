﻿namespace AAEmu.DBEditor.forms.server
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("0");
            tFilter = new System.Windows.Forms.TextBox();
            lvCharacterList = new System.Windows.Forms.ListView();
            ilRaces = new System.Windows.Forms.ImageList(components);
            label1 = new System.Windows.Forms.Label();
            tcCharacter = new System.Windows.Forms.TabControl();
            tpServerStats = new System.Windows.Forms.TabPage();
            tpItems = new System.Windows.Forms.TabPage();
            lContainer = new System.Windows.Forms.Label();
            lvItems = new System.Windows.Forms.ListView();
            chItemTemplateId = new System.Windows.Forms.ColumnHeader();
            chItemCount = new System.Windows.Forms.ColumnHeader();
            chItemName = new System.Windows.Forms.ColumnHeader();
            chItemCategory = new System.Windows.Forms.ColumnHeader();
            chItemDbId = new System.Windows.Forms.ColumnHeader();
            chItemSlot = new System.Windows.Forms.ColumnHeader();
            gbContainerSelect = new System.Windows.Forms.GroupBox();
            rbPetGear = new System.Windows.Forms.RadioButton();
            rbSystem = new System.Windows.Forms.RadioButton();
            rbMail = new System.Windows.Forms.RadioButton();
            rbTrade = new System.Windows.Forms.RadioButton();
            rbWarehouse = new System.Windows.Forms.RadioButton();
            rbInventory = new System.Windows.Forms.RadioButton();
            rbEquipement = new System.Windows.Forms.RadioButton();
            lInventoryGold = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lBankGold = new System.Windows.Forms.Label();
            tcCharacter.SuspendLayout();
            tpServerStats.SuspendLayout();
            tpItems.SuspendLayout();
            gbContainerSelect.SuspendLayout();
            SuspendLayout();
            // 
            // tFilter
            // 
            tFilter.Location = new System.Drawing.Point(12, 32);
            tFilter.Name = "tFilter";
            tFilter.PlaceholderText = "<filter by name or ID>";
            tFilter.Size = new System.Drawing.Size(177, 23);
            tFilter.TabIndex = 0;
            tFilter.TextChanged += tFilter_TextChanged;
            // 
            // lvCharacterList
            // 
            lvCharacterList.AllowDrop = true;
            lvCharacterList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lvCharacterList.BackColor = System.Drawing.SystemColors.Window;
            lvCharacterList.FullRowSelect = true;
            lvCharacterList.LargeImageList = ilRaces;
            lvCharacterList.Location = new System.Drawing.Point(12, 61);
            lvCharacterList.MultiSelect = false;
            lvCharacterList.Name = "lvCharacterList";
            lvCharacterList.Size = new System.Drawing.Size(177, 346);
            lvCharacterList.SmallImageList = ilRaces;
            lvCharacterList.TabIndex = 6;
            lvCharacterList.TileSize = new System.Drawing.Size(255, 64);
            lvCharacterList.UseCompatibleStateImageBehavior = false;
            lvCharacterList.View = System.Windows.Forms.View.SmallIcon;
            lvCharacterList.SelectedIndexChanged += lvCharacterList_SelectedIndexChanged;
            // 
            // ilRaces
            // 
            ilRaces.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilRaces.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilRaces.ImageStream");
            ilRaces.TransparentColor = System.Drawing.Color.Transparent;
            ilRaces.Images.SetKeyName(0, "none.png");
            ilRaces.Images.SetKeyName(1, "nuian-male.png");
            ilRaces.Images.SetKeyName(2, "none.png");
            ilRaces.Images.SetKeyName(3, "none.png");
            ilRaces.Images.SetKeyName(4, "elf-male.png");
            ilRaces.Images.SetKeyName(5, "harani-male.png");
            ilRaces.Images.SetKeyName(6, "firran-male.png");
            ilRaces.Images.SetKeyName(7, "none.png");
            ilRaces.Images.SetKeyName(8, "none.png");
            ilRaces.Images.SetKeyName(9, "none.png");
            ilRaces.Images.SetKeyName(10, "nuian-female.png");
            ilRaces.Images.SetKeyName(11, "none.png");
            ilRaces.Images.SetKeyName(12, "none.png");
            ilRaces.Images.SetKeyName(13, "elf-female.png");
            ilRaces.Images.SetKeyName(14, "harani-female.png");
            ilRaces.Images.SetKeyName(15, "firran-female.png");
            ilRaces.Images.SetKeyName(16, "none.png");
            ilRaces.Images.SetKeyName(17, "none.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 16);
            label1.TabIndex = 7;
            label1.Text = "Filter";
            // 
            // tcCharacter
            // 
            tcCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcCharacter.Controls.Add(tpServerStats);
            tcCharacter.Controls.Add(tpItems);
            tcCharacter.Location = new System.Drawing.Point(195, 9);
            tcCharacter.Name = "tcCharacter";
            tcCharacter.SelectedIndex = 0;
            tcCharacter.Size = new System.Drawing.Size(620, 398);
            tcCharacter.TabIndex = 8;
            // 
            // tpServerStats
            // 
            tpServerStats.Controls.Add(label3);
            tpServerStats.Controls.Add(lBankGold);
            tpServerStats.Controls.Add(label2);
            tpServerStats.Controls.Add(lInventoryGold);
            tpServerStats.Location = new System.Drawing.Point(4, 25);
            tpServerStats.Name = "tpServerStats";
            tpServerStats.Padding = new System.Windows.Forms.Padding(3);
            tpServerStats.Size = new System.Drawing.Size(612, 369);
            tpServerStats.TabIndex = 0;
            tpServerStats.Text = "Stats";
            tpServerStats.UseVisualStyleBackColor = true;
            // 
            // tpItems
            // 
            tpItems.Controls.Add(lContainer);
            tpItems.Controls.Add(lvItems);
            tpItems.Controls.Add(gbContainerSelect);
            tpItems.Location = new System.Drawing.Point(4, 25);
            tpItems.Name = "tpItems";
            tpItems.Padding = new System.Windows.Forms.Padding(3);
            tpItems.Size = new System.Drawing.Size(612, 369);
            tpItems.TabIndex = 1;
            tpItems.Text = "Items";
            tpItems.UseVisualStyleBackColor = true;
            // 
            // lContainer
            // 
            lContainer.AutoSize = true;
            lContainer.Location = new System.Drawing.Point(6, 63);
            lContainer.Name = "lContainer";
            lContainer.Size = new System.Drawing.Size(58, 16);
            lContainer.TabIndex = 2;
            lContainer.Text = "Container";
            // 
            // lvItems
            // 
            lvItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chItemTemplateId, chItemCount, chItemName, chItemCategory, chItemDbId, chItemSlot });
            lvItems.FullRowSelect = true;
            lvItems.GridLines = true;
            lvItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            lvItems.Location = new System.Drawing.Point(6, 82);
            lvItems.MultiSelect = false;
            lvItems.Name = "lvItems";
            lvItems.Size = new System.Drawing.Size(600, 281);
            lvItems.TabIndex = 1;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = System.Windows.Forms.View.Details;
            // 
            // chItemTemplateId
            // 
            chItemTemplateId.Text = "TemplateId";
            chItemTemplateId.Width = 70;
            // 
            // chItemCount
            // 
            chItemCount.Text = "Amount";
            // 
            // chItemName
            // 
            chItemName.Text = "Name";
            chItemName.Width = 200;
            // 
            // chItemCategory
            // 
            chItemCategory.Text = "Category";
            chItemCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            chItemCategory.Width = 80;
            // 
            // chItemDbId
            // 
            chItemDbId.Text = "DBID";
            chItemDbId.Width = 80;
            // 
            // chItemSlot
            // 
            chItemSlot.Text = "Slot#";
            chItemSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            chItemSlot.Width = 80;
            // 
            // gbContainerSelect
            // 
            gbContainerSelect.Controls.Add(rbPetGear);
            gbContainerSelect.Controls.Add(rbSystem);
            gbContainerSelect.Controls.Add(rbMail);
            gbContainerSelect.Controls.Add(rbTrade);
            gbContainerSelect.Controls.Add(rbWarehouse);
            gbContainerSelect.Controls.Add(rbInventory);
            gbContainerSelect.Controls.Add(rbEquipement);
            gbContainerSelect.Location = new System.Drawing.Point(6, 6);
            gbContainerSelect.Name = "gbContainerSelect";
            gbContainerSelect.Size = new System.Drawing.Size(600, 54);
            gbContainerSelect.TabIndex = 0;
            gbContainerSelect.TabStop = false;
            gbContainerSelect.Text = "Container";
            // 
            // rbPetGear
            // 
            rbPetGear.AutoSize = true;
            rbPetGear.Location = new System.Drawing.Point(446, 22);
            rbPetGear.Name = "rbPetGear";
            rbPetGear.Size = new System.Drawing.Size(69, 20);
            rbPetGear.TabIndex = 6;
            rbPetGear.TabStop = true;
            rbPetGear.Tag = "EquipmentMate";
            rbPetGear.Text = "Pet Gear";
            rbPetGear.UseVisualStyleBackColor = true;
            rbPetGear.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbSystem
            // 
            rbSystem.AutoSize = true;
            rbSystem.Location = new System.Drawing.Point(378, 22);
            rbSystem.Name = "rbSystem";
            rbSystem.Size = new System.Drawing.Size(62, 20);
            rbSystem.TabIndex = 5;
            rbSystem.TabStop = true;
            rbSystem.Tag = "System";
            rbSystem.Text = "System";
            rbSystem.UseVisualStyleBackColor = true;
            rbSystem.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbMail
            // 
            rbMail.AutoSize = true;
            rbMail.Location = new System.Drawing.Point(324, 22);
            rbMail.Name = "rbMail";
            rbMail.Size = new System.Drawing.Size(48, 20);
            rbMail.TabIndex = 4;
            rbMail.TabStop = true;
            rbMail.Tag = "Mail";
            rbMail.Text = "Mail";
            rbMail.UseVisualStyleBackColor = true;
            rbMail.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbTrade
            // 
            rbTrade.AutoSize = true;
            rbTrade.Location = new System.Drawing.Point(265, 22);
            rbTrade.Name = "rbTrade";
            rbTrade.Size = new System.Drawing.Size(53, 20);
            rbTrade.TabIndex = 3;
            rbTrade.TabStop = true;
            rbTrade.Tag = "Trade";
            rbTrade.Text = "Trade";
            rbTrade.UseVisualStyleBackColor = true;
            rbTrade.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbWarehouse
            // 
            rbWarehouse.AutoSize = true;
            rbWarehouse.Location = new System.Drawing.Point(175, 22);
            rbWarehouse.Name = "rbWarehouse";
            rbWarehouse.Size = new System.Drawing.Size(84, 20);
            rbWarehouse.TabIndex = 2;
            rbWarehouse.TabStop = true;
            rbWarehouse.Tag = "Bank";
            rbWarehouse.Text = "Warehouse";
            rbWarehouse.UseVisualStyleBackColor = true;
            rbWarehouse.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbInventory
            // 
            rbInventory.AutoSize = true;
            rbInventory.Location = new System.Drawing.Point(94, 22);
            rbInventory.Name = "rbInventory";
            rbInventory.Size = new System.Drawing.Size(75, 20);
            rbInventory.TabIndex = 1;
            rbInventory.TabStop = true;
            rbInventory.Tag = "Inventory";
            rbInventory.Text = "Inventory";
            rbInventory.UseVisualStyleBackColor = true;
            rbInventory.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // rbEquipement
            // 
            rbEquipement.AutoSize = true;
            rbEquipement.Location = new System.Drawing.Point(6, 22);
            rbEquipement.Name = "rbEquipement";
            rbEquipement.Size = new System.Drawing.Size(82, 20);
            rbEquipement.TabIndex = 0;
            rbEquipement.TabStop = true;
            rbEquipement.Tag = "Equipment";
            rbEquipement.Text = "Equipment";
            rbEquipement.UseVisualStyleBackColor = true;
            rbEquipement.CheckedChanged += rbContainers_CheckedChanged;
            // 
            // lInventoryGold
            // 
            lInventoryGold.AutoSize = true;
            lInventoryGold.Location = new System.Drawing.Point(124, 5);
            lInventoryGold.Name = "lInventoryGold";
            lInventoryGold.Size = new System.Drawing.Size(20, 16);
            lInventoryGold.TabIndex = 0;
            lInventoryGold.Text = "0g";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 16);
            label2.TabIndex = 1;
            label2.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 16);
            label3.TabIndex = 3;
            label3.Text = "Warehouse";
            // 
            // lBankGold
            // 
            lBankGold.AutoSize = true;
            lBankGold.Location = new System.Drawing.Point(124, 27);
            lBankGold.Name = "lBankGold";
            lBankGold.Size = new System.Drawing.Size(20, 16);
            lBankGold.TabIndex = 2;
            lBankGold.Text = "0g";
            // 
            // CharacterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(827, 419);
            Controls.Add(tcCharacter);
            Controls.Add(label1);
            Controls.Add(lvCharacterList);
            Controls.Add(tFilter);
            Name = "CharacterForm";
            Text = "Character";
            FormClosed += CharacterForm_FormClosed;
            Load += CharacterForm_Load;
            tcCharacter.ResumeLayout(false);
            tpServerStats.ResumeLayout(false);
            tpServerStats.PerformLayout();
            tpItems.ResumeLayout(false);
            tpItems.PerformLayout();
            gbContainerSelect.ResumeLayout(false);
            gbContainerSelect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tFilter;
        private System.Windows.Forms.ListView lvCharacterList;
        private System.Windows.Forms.ImageList ilRaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcCharacter;
        private System.Windows.Forms.TabPage tpServerStats;
        private System.Windows.Forms.TabPage tpItems;
        private System.Windows.Forms.GroupBox gbContainerSelect;
        private System.Windows.Forms.RadioButton rbPetGear;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbMail;
        private System.Windows.Forms.RadioButton rbTrade;
        private System.Windows.Forms.RadioButton rbWarehouse;
        private System.Windows.Forms.RadioButton rbInventory;
        private System.Windows.Forms.RadioButton rbEquipement;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader chItemTemplateId;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemCategory;
        private System.Windows.Forms.ColumnHeader chItemDbId;
        private System.Windows.Forms.ColumnHeader chItemCount;
        private System.Windows.Forms.Label lContainer;
        private System.Windows.Forms.ColumnHeader chItemSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lBankGold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lInventoryGold;
    }
}