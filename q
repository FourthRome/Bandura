[1mdiff --git a/BlazorImp/Pages/Course.razor b/BlazorImp/Pages/Course.razor[m
[1mindex 2fc31dd..19fc5fb 100644[m
[1m--- a/BlazorImp/Pages/Course.razor[m
[1m+++ b/BlazorImp/Pages/Course.razor[m
[36m@@ -7,19 +7,19 @@[m
     @switch (CurrentPageType)[m
     {[m
         case PageType.InfoPage:[m
[31m-            <BlazorImp.Pages.MinimalSequence.InfoPage Model=@InfoPage GoToNextStep=@GoToNextStep/>[m
[32m+[m[32m            <BlazorImp.Pages.MinimalSequence.InfoPage Model=@InfoPage GoToNextStep=@GoToNextStep SessionInfo=@SessionInfo/>[m
             break;[m
         case PageType.SurveyPage:[m
[31m-            <BlazorImp.Pages.MinimalSequence.SurveyPage  Model=@SurveyPage GoToNextStep=@GoToNextStep/>[m
[32m+[m[32m            <BlazorImp.Pages.MinimalSequence.SurveyPage  Model=@SurveyPage GoToNextStep=@GoToNextStep SessionInfo=@SessionInfo/>[m
             break;[m
         case PageType.VideoPage:[m
[31m-            <BlazorImp.Pages.MinimalSequence.VideoPage Model=@VideoPage GoToNextStep=@GoToNextStep/>[m
[32m+[m[32m            <BlazorImp.Pages.MinimalSequence.VideoPage Model=@VideoPage GoToNextStep=@GoToNextStep SessionInfo=@SessionInfo/>[m
             break;[m
         case PageType.TaskPage:[m
[31m-            <BlazorImp.Pages.MinimalSequence.TaskPage Model=@TaskPage GoToNextStep=@GoToNextStep/>[m
[32m+[m[32m            <BlazorImp.Pages.MinimalSequence.TaskPage Model=@TaskPage GoToNextStep=@GoToNextStep SessionInfo=@SessionInfo/>[m
             break;[m
         case PageType.FinalPage:[m
[31m-            <BlazorImp.Pages.MinimalSequence.FinalPage Model=@FinalPage/>[m
[32m+[m[32m            <BlazorImp.Pages.MinimalSequence.FinalPage Model=@FinalPage SessionInfo=@SessionInfo/>[m
             break;[m
         default:[m
             <p>PageType is not specified</p>[m
[36m@@ -42,9 +42,19 @@[m
     private FinalPageModel? FinalPage { get; set; }[m
     public int? UserID { get; set; }[m
     public int StepNumber { get; set; } = 0;[m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
[32m+[m
[32m+[m[32m    protected override async Task OnInitializedAsync()[m
[32m+[m[32m    {[m
[32m+[m[32m        SessionInfo = new();[m
[32m+[m[32m        StepNumber = 0;[m
[32m+[m[32m    }[m
 [m
     protected override async Task OnParametersSetAsync()[m
     {[m
[32m+[m[32m        SessionInfo.CourseID = CourseID;[m
[32m+[m[32m        SessionInfo.UserID = UserID;[m
[32m+[m[32m        SessionInfo.StepNumber = StepNumber;[m
         await LoadCurrentStep();[m
     }[m
 [m
[36m@@ -92,6 +102,7 @@[m
     public async Task GoToNextStep()[m
     {[m
         StepNumber += 1;[m
[32m+[m[32m        SessionInfo.StepNumber = StepNumber;[m
         await LoadCurrentStep();[m
     }[m
 }[m
[1mdiff --git a/BlazorImp/Pages/MinimalSequence/FinalPage.razor b/BlazorImp/Pages/MinimalSequence/FinalPage.razor[m
[1mindex 9facaed..f8052dc 100644[m
[1m--- a/BlazorImp/Pages/MinimalSequence/FinalPage.razor[m
[1m+++ b/BlazorImp/Pages/MinimalSequence/FinalPage.razor[m
[36m@@ -19,4 +19,6 @@[m
     //-------------------------------------[m
     [Parameter][m
     public FinalPageModel Model { get; set; }[m
[32m+[m[32m    [Parameter][m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
 }[m
[1mdiff --git a/BlazorImp/Pages/MinimalSequence/InfoPage.razor b/BlazorImp/Pages/MinimalSequence/InfoPage.razor[m
[1mindex 688177f..515ff9a 100644[m
[1m--- a/BlazorImp/Pages/MinimalSequence/InfoPage.razor[m
[1m+++ b/BlazorImp/Pages/MinimalSequence/InfoPage.razor[m
[36m@@ -22,6 +22,8 @@[m
     [Parameter][m
     public InfoPageModel Model { get; set; }[m
     [Parameter][m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
[32m+[m[32m    [Parameter][m
     public EventCallback<Task> GoToNextStep { get; set; }[m
 [m
     private async Task ButtonOnClick()[m
[1mdiff --git a/BlazorImp/Pages/MinimalSequence/SurveyPage.razor b/BlazorImp/Pages/MinimalSequence/SurveyPage.razor[m
[1mindex 431f50e..b4f8e6c 100644[m
[1m--- a/BlazorImp/Pages/MinimalSequence/SurveyPage.razor[m
[1m+++ b/BlazorImp/Pages/MinimalSequence/SurveyPage.razor[m
[36m@@ -25,6 +25,8 @@[m
     [Parameter][m
     public SurveyPageModel Model { get; set; }[m
     [Parameter][m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
[32m+[m[32m    [Parameter][m
     public EventCallback<Task> GoToNextStep { get; set; }[m
 [m
     private async Task ButtonOnClick()[m
[1mdiff --git a/BlazorImp/Pages/MinimalSequence/TaskPage.razor b/BlazorImp/Pages/MinimalSequence/TaskPage.razor[m
[1mindex 4b78499..d3b35a3 100644[m
[1m--- a/BlazorImp/Pages/MinimalSequence/TaskPage.razor[m
[1m+++ b/BlazorImp/Pages/MinimalSequence/TaskPage.razor[m
[36m@@ -44,6 +44,8 @@[m
     [Parameter][m
     public TaskPageModel Model { get; set; }[m
     [Parameter][m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
[32m+[m[32m    [Parameter][m
     public EventCallback<Task> GoToNextStep { get; set; }[m
     private bool AnswerCorrectness { get; set; }[m
 [m
[1mdiff --git a/BlazorImp/Pages/MinimalSequence/VideoPage.razor b/BlazorImp/Pages/MinimalSequence/VideoPage.razor[m
[1mindex 0d79c19..a150596 100644[m
[1m--- a/BlazorImp/Pages/MinimalSequence/VideoPage.razor[m
[1m+++ b/BlazorImp/Pages/MinimalSequence/VideoPage.razor[m
[36m@@ -42,6 +42,8 @@[m
     [Parameter][m
     public VideoPageModel Model { get; set; }[m
     [Parameter][m
[32m+[m[32m    public SessionInfo SessionInfo { get; set; }[m
[32m+[m[32m    [Parameter][m
     public EventCallback<Task> GoToNextStep { get; set; }[m
     private string VideoURI { get; set; } = "https://www.youtube.com/embed/dQw4w9WgXcQ";[m
     private string PlayerOptions { get; set; } = "?disablekb=1&iv_load_policy=3&modestbranding=1";[m
