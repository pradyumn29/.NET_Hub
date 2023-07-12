
namespace PMS{

    public partial class Profile{

        public string aadharid;
        public string email;
        public string contactnumber;
        public string firstName;
        public string lastName;


        public override string ToString()
        {
            //return base.ToString();
            string data=string.Format( "{0}, {1}, {2} , {3}",
                                       this.firstName,
                                       this.lastName, 
                                       this.company,
                                       this.qualification);
            return data;
        }
    }
}