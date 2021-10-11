using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Engulf : Template
    {
        public static readonly Guid ID = Guid.Parse("a7ea6715-0132-4c40-99d7-cb349dc4b48b");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Engulf",
                Requirements = "",
                Trigger = "",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("6833ee78-7e3f-4007-9804-66b553ce5124"), Text = "The monster Strides up to double its Speed and can move through the spaces of any creatures in its path. Any creature of the monster�s size or smaller whose space the monster moves through can attempt a Reflex save with the listed DC to avoid being engulfed. A creature unable to act automatically critically fails this save. If a creature succeeds at its save, it can choose to be either pushed aside (out of the monster�s path) or pushed in front of the monster to the end of the monster�s movement. The monster can attempt to Engulf the same creature only once in a single use of Engulf. The monster can contain as many creatures as can fit in its space." };
            yield return new TextBlock { Id = Guid.Parse("ed710cb1-ecf6-4e33-8497-0457cfe5bf18"), Text = "A creature that fails its save is pulled into the monster�s body. It is grabbed, is slowed 1, and has to hold its breath or start suffocating. The creature takes the listed amount of damage when first engulfed and at the end of each of its turns while it�s engulfed. An engulfed creature can get free by Escaping against the listed escape DC. An engulfed creature can attack the monster engulfing it, but only with unarmed attacks or with weapons of light Bulk or less. The engulfing creature is flat-footed against the attack. If the monster takes piercing or slashing damage equaling or exceeding the listed Rupture value from a single attack or spell, the engulfed creature cuts itself free. A creature that gets free by either method can immediately breathe and exits the swallowing monster�s space." };
            yield return new TextBlock { Id = Guid.Parse("7962640e-aeb6-4651-af33-0f00ec1872a5"), Text = "If the monster dies, all creatures it has engulfed are automatically released as the monster�s form loses cohesion." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db6f2857-aeee-49f0-ae12-7061567cbdb3"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
