using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        /// <summary>
        /// Gets or sets the text message, change max len from 200 to 250.
        /// </summary>
        /// <value>
        /// The text message.
        /// </value>
        /// <remarks>
        /// The text message has a maximum length of 200 characters.
        /// </remarks>
        /// <exception cref="System.ComponentModel.DataAnnotations.ValidationException">
        /// Thrown when the text message exceeds 200 characters.
        /// </exception>
        //[StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
