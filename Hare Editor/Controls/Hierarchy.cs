﻿using HareEngine;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HareEditor {

    public class Hierarchy : DBPanel {

        private List<Label> toAdd = new List<Label>();

        public void Reload() {
            Controls.Clear();
            Program.editor.ContextGO = null;
            string x = "";
            foreach (GameObject go in Program.editor.currentScene.gameObjects) {
                if (go.transform.parent == null) {
                    PrintGameObject(go, x);
                    if (go.transform.childs.Count > 0) {
                        PrintChildrens(go, x + "  ");
                    }
                }
            }
            for (int i = toAdd.Count - 1; i >= 0; i--) {
                Controls.Add(toAdd[i]);
            }
            toAdd.Clear();
        }

        private void PrintChildrens(GameObject parent, string x) {
            foreach (Transform t in parent.transform.childs) {
                PrintGameObject(t.gameObject, x);
                if (t.childs.Count > 0) {
                    PrintChildrens(t.gameObject, x + "  ");
                }
            }
        }

        private void PrintGameObject(GameObject go, string x) {
            Label label = new Label();
            label.Text = x + go.Name;
            label.Dock = DockStyle.Top;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.MouseDown += (o, e) => {
                if (e.Button == MouseButtons.Right) {
                    Program.editor.ContextGO = go;
                }
            };
            label.ContextMenu = this.ContextMenu;
            label.Click += (o, e) => {
                Program.editor.SelectedGameObject = go;
                this.Reload();
            };
            if (Program.editor.SelectedGameObject != go) {
                label.ForeColor = Program.colorFont;
                label.BackColor = System.Drawing.Color.Transparent;
            } else {
                label.ForeColor = Program.colorAccentFont;
                label.BackColor = Program.colorAccent;
            }
            toAdd.Add(label);
        }

    }

}
