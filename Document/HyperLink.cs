﻿namespace Document
{
    public class HyperLink : DocumentPart
    {
        public HyperLink(string text, string url) : base(text)
        {
            Url = url;
        }

        public string Url { get; private set; }

        public override string Accept(IVisitor document)
        {
            return document.VisitHyperLink(this);
        }
    }
}