using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using ImGuiNET;
using System.Numerics;


namespace FOVChangerV1
{
    public class Renderer : Overlay
    {
        public float FOV = 65; // FOV değeri 
        private float defaultFov = 65; 
        protected override void Render()
        {
            // buraya GUI renderleniyor
            // here we render GUI
            // renk ekleme

            ImGui.PushStyleColor(ImGuiCol.WindowBg, new Vector4(0.0f, 0.0f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.Border, new Vector4(0.0f, 1.0f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.FrameBg, new Vector4(0.0f, 0.1f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.SliderGrab, new Vector4(0.0f, 0.8f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.SliderGrabActive, new Vector4(0.0f, 1.0f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.Button, new Vector4(0.0f, 0.5f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.ButtonHovered, new Vector4(0.0f, 0.7f, 0.0f, 1.0f));
            ImGui.PushStyleColor(ImGuiCol.ButtonActive, new Vector4(0.0f, 0.6f, 0.0f, 1.0f));

            ImGui.Begin("FOV Changer");

            ImGui.TextColored(new Vector4(0, 1, 0, 1), "Field of View (FOV) Adjuster");

            ImGui.Separator();

            ImGui.SliderFloat("FOV", ref FOV, 55, 160);

            if (ImGui.Button("Reset to default"))
            {
                FOV = defaultFov;
            }

            ImGui.Spacing();
            ImGui.End();
            ImGui.PopStyleColor(7);
        }
    }
}
