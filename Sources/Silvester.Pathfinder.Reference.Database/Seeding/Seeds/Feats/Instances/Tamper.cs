using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Tamper : Template
    {
        public static readonly Guid ID = Guid.Parse("1ce6d290-2742-42aa-9e88-513cc4dfe971");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tamper",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ce15c20-0246-474c-8db4-934d71faee5c"), Type = TextBlockType.Text, Text = "You tamper with a foe’s weapon or armor, using a free hand. Choose either a weapon held by an enemy in your reach or a suit of armor worn by an enemy in your reach. Attempt a Crafting check against the enemy’s Reflex DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dfa00efe-7d4f-4391-a0d1-10797306f6f2"),
                CriticalSuccess = "Your tampering is incredibly effective. If you tampered with a weapon, the enemy takes a –2 circumstance penalty to attack rolls and damage rolls with that weapon. If you tampered with armor, the armor hampers the enemy’s movement, making the enemy flat-footed and inflicting a –10-foot penalty to its Speeds. The effect lasts until the enemy (action: Interacts | Interact) to remove it, regardless of which one you used.",
                Success = "Your tampering is temporarily effective. As critical success, but the effect ends at the start of your next turn, even if the enemy doesn’t (action: Interact) to end it.",
                
                CriticalFailure = "Your tampering backfires dramatically, creating a small explosion from your own tools or gear. You take fire damage equal to your level.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebfd196b-5d7f-4837-a76f-2f481f970ce6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
