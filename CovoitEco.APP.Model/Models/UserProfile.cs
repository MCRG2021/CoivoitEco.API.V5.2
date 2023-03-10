namespace CovoitEco.APP.Model.Models
{
    public class UserProfile
    {
        #region Properties

        public int UTL_Id { get; set; }
        public string UTL_Nom { get; set; }
        public string UTL_Prenom { get; set; }
        public bool UTL_Actif { get; set; }
        public string UTL_Mail { get; set; }
        public int UTL_IdAuth0 { get; set; }

        #endregion
    }
    public class UserProfileVm
    {
        public List<UserProfile> Lists { get; set; }
    }
}
