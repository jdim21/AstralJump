using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            if (player.IsDoubleJump())
            {
                if (player.audioSource && player.doubleJumpAudio)
                    player.audioSource.PlayOneShot(player.doubleJumpAudio);
            } else
            {
                if (player.audioSource && player.jumpAudio)
                    player.audioSource.PlayOneShot(player.jumpAudio);

            }
        }
    }
}