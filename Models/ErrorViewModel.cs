namespace project_GVEncheva22.Models;

// ViewModel used for displaying error information in the UI
public class ErrorViewModel
{
    // Stores the unique request ID for the current HTTP request
    // Useful for debugging and tracing errors
        public string? RequestId { get; set; }

    // Returns true if RequestId is not null or empty
    // Used in the view to decide whether to display the RequestId
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
