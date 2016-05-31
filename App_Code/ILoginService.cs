using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginService" in both code and config file together.
[ServiceContract]
public interface ILoginService
{
   /*
    This interface has methods for registering a reviewer
    and for letting the reviewer login
    You may want to create a DataContract for ShowTracker
    because it writes to two tables Venue and VenueLogin
    */
    [OperationContract]
    bool RegisterReviewer(Reviewer r);

    [OperationContract]
    int ReviewerLogin(string userName, string password);

    [OperationContract]
    bool AddAuthor(Author a);

    [OperationContract]
    bool AddBook(Book b);

    [OperationContract]
    bool AddReview(Review r);


}
