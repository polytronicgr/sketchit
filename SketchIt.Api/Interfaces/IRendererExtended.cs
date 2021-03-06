﻿namespace SketchIt.Api.Interfaces
{
    public interface IRendererExtended
    {
        void BeginShape();
        void DrawArc(float x, float y, float width, float height, float start, float stop);
        void DrawEllipse(float x, float y, float diameter);
        void DrawEllipse(float x, float y, float width, float height);
        void DrawLine(float x1, float y1, float x2, float y2);
        void DrawPoint(float x, float y);
        void DrawQuad(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
        void DrawBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
        void DrawCurve(params float[] points);
        void DrawCurve(params Point[] points);
        void DrawRectangle(float x, float y, float size);
        void DrawRectangle(float x, float y, float width, float height);
        void DrawText(object text, float x, float y);
        void DrawText(object text, float x, float y, float width, float height);
        void DrawImage(IImage image, float x, float y);
        void DrawImage(IImage image, float x, float y, float width, float height);
        void DrawBackground(IImage image);
        void DrawBackground(float gray);
        void DrawBackground(float gray, float alpha);
        void DrawBackground(float r, float g, float b);
        void DrawBackground(float r, float g, float b, float alpha);
        void DrawBackground(Color color, float alpha);
        void DrawBackground(Color color);
        void Vertex(float x, float y);
    }
}
