using System;
using System.Threading.Tasks;
using Content.Server.Administration.Managers;
using Robust.Shared.Network;

// ReSharper disable once CheckNamespace
namespace Content.Server.Connection;

public partial interface IConnectionManager
{
    Task<bool> HavePrivilegedJoin(NetUserId userId);
    event EventHandler<PlayerConnectingWithBanEvent>? PlayerConnectingWithBan;
}
