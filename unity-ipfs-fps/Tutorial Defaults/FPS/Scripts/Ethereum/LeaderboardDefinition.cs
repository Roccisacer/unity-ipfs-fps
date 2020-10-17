﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace LeaderboardSolidityContract.Contracts.Leaderboard.ContractDefinition
{
  public partial class LeaderboardDeployment : LeaderboardDeploymentBase
  {
    public LeaderboardDeployment() : base(BYTECODE) { }
    public LeaderboardDeployment(string byteCode) : base(byteCode) { }
  }

  public class LeaderboardDeploymentBase : ContractDeploymentMessage
  {
    public static string BYTECODE = "6080604052600a60015534801561001557600080fd5b50600080546001600160a01b03191633179055610641806100376000396000f3fe608060405234801561001057600080fd5b50600436106100365760003560e01c8063bf3683991461003b578063f4c5cd3c146100d7575b600080fd5b6100586004803603602081101561005157600080fd5b5035610193565b6040518080602001838152602001828103825284818151815260200191508051906020019080838360005b8381101561009b578181015183820152602001610083565b50505050905090810190601f1680156100c85780820380516001836020036101000a031916815260200191505b50935050505060405180910390f35b61017f600480360360408110156100ed57600080fd5b81019060208101813564010000000081111561010857600080fd5b82018360208201111561011a57600080fd5b8035906020019184600183028401116401000000008311171561013c57600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295505091359250610234915050565b604080519115158252519081900360200190f35b600260208181526000928352604092839020805484516001821615610100026000190190911693909304601f81018390048302840183019094528383529283918301828280156102245780601f106101f957610100808354040283529160200191610224565b820191906000526020600020905b81548152906001019060200180831161020757829003601f168201915b5050505050908060010154905082565b600080546001600160a01b0316331461028c576040805162461bcd60e51b815260206004820152601560248201527414d95b99195c881b9bdd08185d5d1a1bdc9a5e9959605a1b604482015290519081900360640190fd5b60018054600019016000908152600260205260409020015482116102b257506000610511565b60005b60015481101561050f57600081815260026020526040902060010154831115610507576102e0610517565b600082815260026020818152604092839020835181546060601f600019610100600185161502019092169590950490810184900490930281018401855293840182815290928492849184018282801561037a5780601f1061034f5761010080835404028352916020019161037a565b820191906000526020600020905b81548152906001019060200180831161035d57829003601f168201915b505050918352505060019182015460209091015290915082015b600154600101811015610496576103a9610517565b600082815260026020818152604092839020835181546060601f60001961010060018516150201909216959095049081018490049093028101840185529384018281529092849284918401828280156104435780601f1061041857610100808354040283529160200191610443565b820191906000526020600020905b81548152906001019060200180831161042657829003601f168201915b50505091835250506001919091015460209182015260008481526002825260409020855180519394508693919261047f92849290910190610531565b506020919091015160019182015590925001610394565b5060408051808201825286815260208082018790526000858152600282529290922081518051929391926104cd9284920190610531565b50602091820151600191820155546000908152600290915260408120906104f482826105af565b5060006001918201559250610511915050565b6001016102b5565b505b92915050565b604051806040016040528060608152602001600081525090565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061057257805160ff191683800117855561059f565b8280016001018555821561059f579182015b8281111561059f578251825591602001919060010190610584565b506105ab9291506105f6565b5090565b50805460018160011615610100020316600290046000825580601f106105d557506105f3565b601f0160209004906000526020600020908101906105f391906105f6565b50565b5b808211156105ab57600081556001016105f756fea26469706673582212206b5be60a7d25d6730ce6b803cda3309cd583b902abc29a9537dce37749377ef264736f6c63430007000033";
    public LeaderboardDeploymentBase() : base(BYTECODE) { }
    public LeaderboardDeploymentBase(string byteCode) : base(byteCode) { }

  }

  public partial class AddScoreFunction : AddScoreFunctionBase { }

  [Function("addScore", "bool")]
  public class AddScoreFunctionBase : FunctionMessage
  {
    [Parameter("string", "user", 1)]
    public virtual string User { get; set; }
    [Parameter("uint256", "score", 2)]
    public virtual BigInteger Score { get; set; }
  }

  public partial class LeaderboardFunction : LeaderboardFunctionBase { }

  [Function("leaderboard", typeof(LeaderboardOutputDTO))]
  public class LeaderboardFunctionBase : FunctionMessage
  {
    [Parameter("uint256", "", 1)]
    public virtual BigInteger ReturnValue1 { get; set; }
  }



  public partial class LeaderboardOutputDTO : LeaderboardOutputDTOBase { }

  [FunctionOutput]
  public class LeaderboardOutputDTOBase : IFunctionOutputDTO
  {
    [Parameter("string", "user", 1)]
    public virtual string User { get; set; }
    [Parameter("uint256", "score", 2)]
    public virtual BigInteger Score { get; set; }
  }
}
