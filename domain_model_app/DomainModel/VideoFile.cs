using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("VideoFile")]
    public class VideoFile
    {
        [Key]
        private int _videoFileID;

        [ForeignKey("Procedure")]
        private int _procedureID;

        [Required]
        private string _filepath;


        private string _filename;

        public VideoFile()
        {

        }


        public int ProcedureID { get => _procedureID; set => _procedureID = value; }
        public string Filepath { get => _filepath; set => _filepath = value; }
        public string Filename { get => _filename; set => _filename = value; }
        public int VideoFileID { get => _videoFileID; set => _videoFileID = value; }
    }
}
