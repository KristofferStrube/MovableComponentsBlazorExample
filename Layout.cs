using Microsoft.AspNetCore.Components;

namespace MovableComponentsBlazorExample;

public class Layout : ComponentBase
{
    protected List<RenderFragment> children { get; set; } = new List<RenderFragment>();

    [Parameter]
    public RenderFragment ChildComponent { set => AddChildToEnd(value); }

    public RenderFragment? FirstChild => children.FirstOrDefault();
    public RenderFragment? LastChild => children.LastOrDefault();

    public void AddChildToEnd(RenderFragment value)
    {
        children.Add(value);
        StateHasChanged();
    }

    public void AddChildToStart(RenderFragment value)
    {
        children.Insert(0, value);
        StateHasChanged();
    }

    public void RemoveChild(RenderFragment value)
    {
        children.Remove(value);
        StateHasChanged();
    }
}
