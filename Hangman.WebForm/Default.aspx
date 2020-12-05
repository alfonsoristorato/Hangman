<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hangman.WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
            <asp:Label ID="ResultBox" runat="server" Text="ResultBox"></asp:Label>
    </div>
    <div class="col-md-4">
            <asp:TextBox ID="SubmitWord" runat="server"></asp:TextBox>
            <asp:Button ID="Submitter" runat="server" Text="Submitter" OnClick="Submitter_Click" />
            <asp:Label ID="ErrorMessage" runat="server" Text="ErrorMessage"></asp:Label>
            <asp:Label ID="PlayingWord" runat="server" Text="PlayingWord"></asp:Label>
            <asp:Label ID="ErrorText" runat="server" Text="ErrorText"></asp:Label>
            <asp:Label ID="IncorrectGuessesBoxTitle" runat="server" Text="IncorrectGuessesBoxTitle"></asp:Label>
            <asp:Label ID="IncorrectGuessesBox" runat="server" Text="IncorrectGuessesBox"></asp:Label>
    </div>

    <div class="col-md-4">
            <asp:Label ID="LivesCounterTitle" runat="server" Text="LivesCounterTitle"></asp:Label>
            <asp:Label ID="LivesCounter" runat="server" Text="LivesCounter"></asp:Label>
            <asp:Button ID="HintButton" runat="server" Text="HintButton" />
            <asp:Button ID="GenerateWord" runat="server" Text="GenerateWord" />
            <asp:Button ID="RestartApp" runat="server" Text="RestartApp" />
    </div>





    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>



</asp:Content>
