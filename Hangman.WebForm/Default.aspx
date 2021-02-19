<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hangman.WebForm._Default"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12" style="min-height:20px">
            <asp:Label ID="ResultBox" runat="server"></asp:Label>
        </div>
</div>
<div class="row" style="min-height:40px">
    <div class="col-md-12">
        <div>
            <asp:TextBox ID="SubmitWord" runat="server" MaxLength="1" style='text-transform:uppercase; width:60px' AutoCompleteType="Disabled" ></asp:TextBox>
            <asp:Button ID="Submitter" runat="server" Text="Submit" OnClick="Submitter_Click" CssClass="btn btn-outline-dark"/>
        </div>
        <div id="DivErrorMessage">
            <asp:Label ID="ErrorMessage" runat="server"></asp:Label>
        </div>
    </div>
</div>

<div class="row">
    <div class="col-md-6">
        <div id="DivPlayingWord">
            <asp:Label ID="PlayingWord" runat="server"></asp:Label>
        </div>
        <div id="DivWordHint">
            <asp:Label ID="HintText" runat="server"></asp:Label>
        </div>
    </div>
    <div class="col-md-6">
        <div id="lives">
            <asp:Label ID="LivesCounterTitle" runat="server" Text="Lives: "></asp:Label>
            <asp:Label ID="LivesCounter" runat="server"></asp:Label>
        </div>
        <asp:Image ID="hangmanImage" runat="server" ImageUrl = "Images/hangman/lives6.png"/>
    </div>
</div>

<div class="row" style="min-height:50px">
    <div class="col-md12">
        <div>
            <asp:Label ID="IncorrectGuessesBoxTitle" runat="server" Text="Incorrect Guesses"></asp:Label>
        </div>
        <div>
            <%--<asp:Label ID="IncorrectGuessesBox" runat="server" Style="min-height: 26px; display: inline-block; border: 1px solid; width: 50%;"></asp:Label>--%>
            <asp:TextBox ID="IncorrectGuessesBox" runat="server" style='text-transform:uppercase; ' AutoCompleteType="Disabled" ReadOnly="True" Wrap="False" ></asp:TextBox>
        </div>

    </div>
</div>
<div class="row">
    <div class="col-md-12">

        <asp:Button ID="HintButton" runat="server" Text="Hint? You'll lose 2 lives!" OnClick="HintButton_Click" CssClass="btn btn-outline-dark" />

        <asp:Button ID="GenerateWord" runat="server" Text="Generate a new Word" OnClick="GenerateWord_Click" CssClass="btn btn-outline-dark" />

        <asp:Button ID="RestartApp" runat="server" Text="Restart App" OnClick="RestartApp_Click" CssClass="btn btn-outline-dark" />

    </div>
</div>

<%--<div class="btn-group" role="group" aria-label="Button group with nested dropdown">
  <div class="btn-group" role="group">
    <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
      Background selector
    </button>
    <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
       <button onclick = "Dotted(); return false" runat="server" >Click here</button> 
       <button onclick = "Dotted(); return false" >Click here</button> 
    </div>
  </div>
</div>--%>

</asp:Content>

