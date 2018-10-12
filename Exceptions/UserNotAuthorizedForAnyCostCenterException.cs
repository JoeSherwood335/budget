namespace budget.Exceptions
{
  
  
  [System.Serializable]
  public class UserNotAuthorizedForAnyCostCenterException : System.Exception
  {
      public UserNotAuthorizedForAnyCostCenterException():this("User Not Authorized For Any CostCenter ") { }
      public UserNotAuthorizedForAnyCostCenterException(string message) : base(message) { }
      public UserNotAuthorizedForAnyCostCenterException(string message, System.Exception inner) : base(message, inner) { }
      protected UserNotAuthorizedForAnyCostCenterException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
  }
}