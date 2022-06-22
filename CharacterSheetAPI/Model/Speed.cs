namespace CharacterSheetAPI.Models
{
    public class Speed
    {
        public int SpeedID { get; set; }

        public int CharacterID { get; set; }

        public short SpeedPoints { get; set; }

        public short WalkPoints { get; set; }

        public short RunPoints { get; set; }
    }
}
