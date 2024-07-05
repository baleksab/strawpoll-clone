using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities;

public enum PollType
{
    MultipleChoice,
    Meeting,
    Image,
    Ranking
}
public enum VotingSecurity
{
    AllowMultipleVotes,
    OneVotePerSession,
    OneVotePerIp,
    OneVotePerUser,
    OneVotePerCode
}
public enum ResultVisibility
{
    AlwaysPublic,
    PublicAfterClosing,
    Private
}
public enum EditVotePermissions
{
    Nobody,
    Creator,
    AllUsers
}
public enum OptionType
{
    MultipleChoice,
    Image,
    Ranking,
    Meeting
}