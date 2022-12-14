using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using System.Threading.Tasks;
using UnityEngine;

namespace Platformer.Gameplay
{

    /// <summary>
    /// This event is triggered when the player character enters a trigger with a VictoryZone component.
    /// </summary>
    /// <typeparam name="PlayerEnteredVictoryZone"></typeparam>
    public class PlayerEnteredVictoryZone : Simulation.Event<PlayerEnteredVictoryZone>
    {
        public VictoryZone victoryZone;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            Debug.Log("victory");
            AudioSource.PlayClipAtPoint(victoryZone.victoryZoneAudio, model.player.GetPosition());
            model.player.animator.SetTrigger("victory");
            model.player.controlEnabled = false;
            model.player.Invoke("CompleteLevel", 1.5f);
        }
    }
}