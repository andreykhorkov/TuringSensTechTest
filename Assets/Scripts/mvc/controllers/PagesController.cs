public class PagesController : TuringSensElement
{
    public void SetPage(int pageIdToSet)
    {
        if (App.Model.PagesModel.CurrentPageId == pageIdToSet)  // probably unnecessary check, since you can`t click btn on the other page
        {
            return;
        }

        App.View.MainCameraView.Anim.SetTrigger(pageIdToSet);
        App.Model.PagesModel.SetCurrentView(pageIdToSet);
    }
}
