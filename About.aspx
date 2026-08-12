<%@ Page Title="About Me" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PathFinder.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title" class="centerAlignmentHeader"><%: Title %></h2>
        <%--<h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>--%>

        <div>
            <p class="paragraphStyle">
                Physics is one of the most fascinating subjects in science, as it helps us understand the laws that govern the universe—from the motion of planets to the behavior of tiny particles.
                 As a 12th science student, I have created the Physics Pathfinder website to make learning easier and more engaging for students like me.
                 This platform is designed to provide clear explanations, useful resources, and problem-solving guidance that can help learners strengthen their concepts and prepare confidently
                 for exams. My aim is to build a space where physics becomes not just a subject to study, but an exciting journey of discovery.
            </p>
        </div>
    </main>
</asp:Content>
