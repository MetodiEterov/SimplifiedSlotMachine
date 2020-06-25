// <auto-generated />
namespace SlotMachine.BisinessLayer
{
  using global::SlotMachine.Models;

  /// <summary>
  /// ISlotMachine
  /// </summary>
  public interface ISlotMachine
  {
    /// <summary>
    /// GetNewBettingCoefficents
    /// </summary>
    /// <returns></returns>
    SlotMachineModel GetNewBettingCoefficents();

    /// <summary>
    /// GetRandomNumberInRange
    /// </summary>
    /// <returns></returns>
    int GetRandomNumberInRange();

    /// <summary>
    /// CalculateProfit
    /// </summary>
    /// <param name="bet"></param>
    void CalculateProfit(ref SlotMachineModel bet);

    /// <summary>
    /// SumCoefficents
    /// </summary>
    /// <param name="coefficents"></param>
    /// <returns></returns>
    double SumCoefficents(ImageEntity coefficents);

    /// <summary>
    /// AllEqual
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    bool AllEqual(params double[] values);
  }
}
