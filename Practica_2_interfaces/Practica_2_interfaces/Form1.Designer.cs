﻿namespace Practica_2_interfaces
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_crear_agenda = new System.Windows.Forms.Button();
            this.btn_nueva_tarea = new System.Windows.Forms.Button();
            this.btn_modificar_tarea = new System.Windows.Forms.Button();
            this.btn_borrar_tarea = new System.Windows.Forms.Button();
            this.btn_mostrar_tareas = new System.Windows.Forms.Button();
            this.btn_mostrar_tareas_por_dia = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crear_agenda
            // 
            this.btn_crear_agenda.Location = new System.Drawing.Point(349, 87);
            this.btn_crear_agenda.Name = "btn_crear_agenda";
            this.btn_crear_agenda.Size = new System.Drawing.Size(138, 23);
            this.btn_crear_agenda.TabIndex = 0;
            this.btn_crear_agenda.Text = "Crear Agenda";
            this.btn_crear_agenda.UseVisualStyleBackColor = true;
            this.btn_crear_agenda.Click += new System.EventHandler(this.btn_crear_agenda_Click);
            // 
            // btn_nueva_tarea
            // 
            this.btn_nueva_tarea.Location = new System.Drawing.Point(349, 131);
            this.btn_nueva_tarea.Name = "btn_nueva_tarea";
            this.btn_nueva_tarea.Size = new System.Drawing.Size(138, 23);
            this.btn_nueva_tarea.TabIndex = 1;
            this.btn_nueva_tarea.Text = "Nueva Tarea";
            this.btn_nueva_tarea.UseVisualStyleBackColor = true;
            this.btn_nueva_tarea.Click += new System.EventHandler(this.btn_nueva_tarea_Click);
            // 
            // btn_modificar_tarea
            // 
            this.btn_modificar_tarea.Location = new System.Drawing.Point(349, 176);
            this.btn_modificar_tarea.Name = "btn_modificar_tarea";
            this.btn_modificar_tarea.Size = new System.Drawing.Size(138, 23);
            this.btn_modificar_tarea.TabIndex = 2;
            this.btn_modificar_tarea.Text = "Modificar Tarea";
            this.btn_modificar_tarea.UseVisualStyleBackColor = true;
            // 
            // btn_borrar_tarea
            // 
            this.btn_borrar_tarea.Location = new System.Drawing.Point(349, 221);
            this.btn_borrar_tarea.Name = "btn_borrar_tarea";
            this.btn_borrar_tarea.Size = new System.Drawing.Size(138, 23);
            this.btn_borrar_tarea.TabIndex = 3;
            this.btn_borrar_tarea.Text = "Borrar Tarea";
            this.btn_borrar_tarea.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar_tareas
            // 
            this.btn_mostrar_tareas.Location = new System.Drawing.Point(349, 268);
            this.btn_mostrar_tareas.Name = "btn_mostrar_tareas";
            this.btn_mostrar_tareas.Size = new System.Drawing.Size(138, 23);
            this.btn_mostrar_tareas.TabIndex = 4;
            this.btn_mostrar_tareas.Text = "Mostrar Tareas";
            this.btn_mostrar_tareas.UseVisualStyleBackColor = true;
            this.btn_mostrar_tareas.Click += new System.EventHandler(this.btn_mostrar_tareas_Click);
            // 
            // btn_mostrar_tareas_por_dia
            // 
            this.btn_mostrar_tareas_por_dia.Location = new System.Drawing.Point(349, 314);
            this.btn_mostrar_tareas_por_dia.Name = "btn_mostrar_tareas_por_dia";
            this.btn_mostrar_tareas_por_dia.Size = new System.Drawing.Size(138, 23);
            this.btn_mostrar_tareas_por_dia.TabIndex = 5;
            this.btn_mostrar_tareas_por_dia.Text = "Mostrar Tareas de un Día";
            this.btn_mostrar_tareas_por_dia.UseVisualStyleBackColor = true;
            this.btn_mostrar_tareas_por_dia.Click += new System.EventHandler(this.btn_mostrar_tareas_por_dia_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(349, 363);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(138, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mostrar_tareas_por_dia);
            this.Controls.Add(this.btn_mostrar_tareas);
            this.Controls.Add(this.btn_borrar_tarea);
            this.Controls.Add(this.btn_modificar_tarea);
            this.Controls.Add(this.btn_nueva_tarea);
            this.Controls.Add(this.btn_crear_agenda);
            this.Name = "Form1";
            this.Text = "Mi Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_agenda;
        private System.Windows.Forms.Button btn_nueva_tarea;
        private System.Windows.Forms.Button btn_modificar_tarea;
        private System.Windows.Forms.Button btn_borrar_tarea;
        private System.Windows.Forms.Button btn_mostrar_tareas;
        private System.Windows.Forms.Button btn_mostrar_tareas_por_dia;
        private System.Windows.Forms.Button btn_salir;
    }
}

