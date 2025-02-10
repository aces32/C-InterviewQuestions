namespace LLMs.DelegatesAndEvents
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: seding an Email .... {e.Video.Title}");
        }
    }
}
