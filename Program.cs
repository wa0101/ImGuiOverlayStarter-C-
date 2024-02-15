using System;
using ImGuiNET;
using ClickableTransparentOverlay;
using System.Runtime.InteropServices;
using System.Numerics;

namespace IMGUITEST
{
    public class Program : Overlay
    {

        // -------------------- //
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }// -------------------- //




        // -------------------- //
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        // -------------------- //


        // -------------------- //
        private bool showMenu = true;
        private bool settingsVisible = false;
        private bool rainbowThemeEnabled = false;
        private bool keyPressedLastFrame = false;
        private int hotkey = 0x70; // Default to F1
        private bool waitingForKeyPress = false;
        // -------------------- //


        // -------------------- //
        protected override void Render()
        {
            bool isKeyPressed = (GetAsyncKeyState(hotkey) & 0x8000) > 0;

            if (isKeyPressed && !keyPressedLastFrame && !waitingForKeyPress)
            {
                showMenu = !showMenu;
            }
            keyPressedLastFrame = isKeyPressed;

            if (!showMenu) return;

            if (rainbowThemeEnabled)
            {
                ApplyRainbowTheme(0.1f); // Apply dynamic rainbow theme
            }
            else
            {
                ImGuiStyle.ApplyCustomStyle(); // u can edit it from ImGuiStyle.cs
            }

            ImGui.Begin("WA Overlay", ref showMenu);

            if (ImGui.BeginTabBar("OverlayTabBar"))
            {
                if (ImGui.BeginTabItem("Main"))
                {
                    ImGui.Text("WA");
                    ImGui.EndTabItem();
                }
                if (ImGui.BeginTabItem("Settings"))
                {
                    ImGui.Checkbox("Enable Rainbow Theme", ref rainbowThemeEnabled);

                    ImGui.Text("Hotkey Settings:");
                    if (ImGui.Button("Set New Hotkey for Hide/Show Menu"))
                    {
                        waitingForKeyPress = true;
                    }

                    if (waitingForKeyPress)
                    {
                        ImGui.Text("Press any key for the new hotkey...");
                        for (int key = 0x08; key <= 0xFF; key++)
                        {
                            if (!keyPressedLastFrame && GetAsyncKeyState(key) == -32767)
                            {
                                hotkey = key;
                                waitingForKeyPress = false;
                                ImGui.Text($"New hotkey set. Key code: {key}");
                                break;
                            }
                        }
                    }

                    ImGui.EndTabItem();
                }
                ImGui.EndTabBar();
            }

            ImGui.End();
        }
        // -------------------- //


        // -------------------- //
        private void ApplyRainbowTheme(float speed)
        {
            var time = (float)DateTime.Now.TimeOfDay.TotalSeconds;
            // Apply rainbow effect primarily to the window background and borders
            var bgColor = ColorFromHSV((time * speed) % 1.0f, 0.7f, 0.5f);
            var borderColor = ColorFromHSV((time * speed) % 1.0f, 0.7f, 0.5f);

            ImGui.GetStyle().Colors[(int)ImGuiCol.WindowBg] = bgColor;
            ImGui.GetStyle().Colors[(int)ImGuiCol.Border] = borderColor;

            // Maintain readability for text and essential elements
            var textColor = new Vector4(1.0f, 1.0f, 1.0f, 1.0f); // White color for text
            ImGui.GetStyle().Colors[(int)ImGuiCol.Text] = textColor;
            ImGui.GetStyle().Colors[(int)ImGuiCol.Button] = new Vector4(0.20f, 0.25f, 0.29f, 1.00f);
            ImGui.GetStyle().Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.3f, 0.35f, 0.39f, 1.00f);
            ImGui.GetStyle().Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.15f, 0.20f, 0.25f, 1.00f);
        }
        // -------------------- //



        // -------------------- //

        private Vector4 ColorFromHSV(float hue, float saturation, float value)
        {
            ImGui.ColorConvertHSVtoRGB(hue, saturation, value, out float r, out float g, out float b);
            return new Vector4(r, g, b, 1.0f); // Alpha is set to 1.0f
        }
        // -------------------- //



    }
}
