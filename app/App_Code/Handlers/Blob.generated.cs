namespace FreeTrial.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("AtachmentsAttachment", "\"dbo\".\"Atachments\"", "\"Attachment\"", new string[] {
                        "\"AttachmentID\""}, "Atachments Attachment", "Atachments", "Attachment");
        }
    }
}
