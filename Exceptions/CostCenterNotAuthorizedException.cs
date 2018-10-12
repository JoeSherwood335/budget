
namespace budget.Exceptions
{

[System.Serializable]
  public class CostCenterNotAuthorizedException : System.Exception
  {
      public CostCenterNotAuthorizedException(CostCenterModel CostCenter)
      :this($@"CostCenter {CostCenter.CostCenter} is not Authorized for this User") { }
      public CostCenterNotAuthorizedException(string message) : base(message) { }
      public CostCenterNotAuthorizedException(string message, System.Exception inner) : base(message, inner) { }
      protected CostCenterNotAuthorizedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
  }


  public class CostCenterModel{

    public string CostCenter { get; set; }

    public CostCenterModel(string costcenter){
        CostCenter = costcenter;

    }
  }
}