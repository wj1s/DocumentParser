﻿using Document;
using Xunit;

namespace DocumentTest
{
    public class DocumentTest
    {
        [Fact]
        public void should_output_html_for_document_with_plain_text_part()
        {
            var plainText = new PlainText("I am plain text");
            var document = new Document.Document(plainText);

            string html = document.Accept(new HtmlVisitor());

            Assert.Equal("I am plain text", html);
        }

        [Fact]
        public void should_output_html_for_document_with_bold_text_part()
        {
            var boldText = new BoldText("I am bold text");
            var document = new Document.Document(boldText);

            string html = document.Accept(new HtmlVisitor());

            Assert.Equal("<b>I am bold text</b>", html);
        }

        [Fact]
        public void should_output_html_for_document_with_hyperlink_part()
        {
            var hyperLink = new HyperLink("I am hyperlink", "http://www.visitor.com");
            var document = new Document.Document(hyperLink);

            string html = document.Accept(new HtmlVisitor());

            Assert.Equal("<a href='http://www.visitor.com'>I am hyperlink</a>", html);
        }

        [Fact]
        public void should_output_markdown_for_document_with_bold_text_part()
        {
            var boldText = new BoldText("I am bold text");
            var document = new Document.Document(boldText);

            string html = document.Accept(new MarkdownVisitor());

            Assert.Equal("_I am bold text_", html);
        }
    }
}