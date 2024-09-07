using CommandSystem;
using Exiled.API.Features;
using PlayerRoles;
using System;
using System.Linq;

namespace ScpList
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class SCPListCommand : ICommand
    {
        public string Command => "scplist";
        public string[] Aliases => new string[] { };
        public string Description => "shows a list of SCPs";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is CommandSender commandSender && Player.Get(commandSender) is Player player)
            {
                var scpPlayers = Player.List.Where(p => IsSCPRole(p.Role.Type));

                if (!scpPlayers.Any())
                {
                    response = "no SCPs are currently in the game.";
                    return false;
                }

                string message = "<color=#4fa831>List of SCPs:</color>\n";
                foreach (var scpPlayer in scpPlayers)
                {
                    message += $"<color=#bdb253>{scpPlayer.Role.Type}</color>";
                }

                response = message;
                return true;
            }

            response = "this command can only be used by PLAYERS";
            return false;
        }

        private bool IsSCPRole(RoleTypeId role)
        {
            return role == RoleTypeId.Scp049 || role == RoleTypeId.Scp0492 ||
                   role == RoleTypeId.Scp079 || role == RoleTypeId.Scp096 ||
                   role == RoleTypeId.Scp106 || role == RoleTypeId.Scp173 ||
                   role == RoleTypeId.Scp939;
        }
    }
}
