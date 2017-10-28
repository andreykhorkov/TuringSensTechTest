public class PagesModel : TuringSensElement
{
    public int CurrentPageId { get; private set; }

    public void SetCurrentView(int pageId)
    {
        CurrentPageId = pageId;
    }
}