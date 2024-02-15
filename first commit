using ImGuiNET;
using System.Numerics;

public static class ImGuiStyle
{
    public static void ApplyCustomStyle()
    {
        var style = ImGui.GetStyle();

        // Basic layout
        style.WindowPadding = new Vector2(15, 15);
        style.WindowRounding = 5.0f;
        style.FramePadding = new Vector2(5, 5);
        style.FrameRounding = 4.0f;
        style.ItemSpacing = new Vector2(12, 8);
        style.ItemInnerSpacing = new Vector2(8, 6);
        style.IndentSpacing = 25.0f;

        // Colors
        var baseDarkRed = new Vector4(0.7f, 0.1f, 0.1f, 1.0f);
        var baseDarkerRed = new Vector4(0.5f, 0.05f, 0.05f, 1.0f);
        var baseLightRed = new Vector4(0.9f, 0.2f, 0.2f, 1.0f);
        var backgroundDark = new Vector4(0.1f, 0.1f, 0.1f, 1.0f);
        var almostWhite = new Vector4(0.85f, 0.85f, 0.85f, 1.0f);
        var lightBackground = new Vector4(0.2f, 0.2f, 0.2f, 0.7f);

        style.Colors[(int)ImGuiCol.Text] = almostWhite;
        style.Colors[(int)ImGuiCol.WindowBg] = backgroundDark;
        style.Colors[(int)ImGuiCol.ChildBg] = backgroundDark;
        style.Colors[(int)ImGuiCol.PopupBg] = lightBackground;
        style.Colors[(int)ImGuiCol.Border] = baseDarkRed;
        style.Colors[(int)ImGuiCol.BorderShadow] = baseDarkerRed;
        style.Colors[(int)ImGuiCol.FrameBg] = lightBackground;
        style.Colors[(int)ImGuiCol.FrameBgHovered] = baseLightRed;
        style.Colors[(int)ImGuiCol.FrameBgActive] = baseDarkRed;
        style.Colors[(int)ImGuiCol.TitleBg] = baseDarkRed;
        style.Colors[(int)ImGuiCol.TitleBgActive] = baseDarkerRed;
        style.Colors[(int)ImGuiCol.TitleBgCollapsed] = baseDarkerRed;
        style.Colors[(int)ImGuiCol.MenuBarBg] = backgroundDark;
        style.Colors[(int)ImGuiCol.ScrollbarBg] = backgroundDark;
        style.Colors[(int)ImGuiCol.ScrollbarGrab] = baseDarkRed;
        style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = baseLightRed;
        style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = almostWhite;
        style.Colors[(int)ImGuiCol.CheckMark] = baseLightRed;
        style.Colors[(int)ImGuiCol.SliderGrab] = baseLightRed;
        style.Colors[(int)ImGuiCol.SliderGrabActive] = almostWhite;
        style.Colors[(int)ImGuiCol.Button] = baseDarkRed;
        style.Colors[(int)ImGuiCol.ButtonHovered] = baseLightRed;
        style.Colors[(int)ImGuiCol.ButtonActive] = almostWhite;
        style.Colors[(int)ImGuiCol.Header] = baseDarkRed;
        style.Colors[(int)ImGuiCol.HeaderHovered] = baseLightRed;
        style.Colors[(int)ImGuiCol.HeaderActive] = almostWhite;
        style.Alpha = 1.0f;
    }
}
