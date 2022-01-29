using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Tamper : Template
    {
        public static readonly Guid ID = Guid.Parse("5fbf798a-2d30-4b59-b8cc-f4f94bc3e103");

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
            yield return new TextBlock { Id = Guid.Parse("7098fc7f-c145-463b-9cdc-fd510d72b466"), Type = TextBlockType.Text, Text = $"You tamper with a foe's weapon or armor, using a free hand. Choose either a weapon held by an enemy in your reach or a suit of armor worn by an enemy in your reach. Attempt a Crafting check against the enemy's Reflex DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a5abbd45-a5be-442c-bcd0-c5b9e6fb357c"),
                CriticalSuccess = "Your tampering is incredibly effective. If you tampered with a weapon, the enemy takes a –2 circumstance penalty to attack rolls and damage rolls with that weapon. If you tampered with armor, the armor hampers the enemy's movement, making the enemy flat-footed and inflicting a –10-foot penalty to its Speeds. The effect lasts until the enemy (action: Interacts | Interact) to remove it, regardless of which one you used.",
                Success = "Your tampering is temporarily effective. As critical success, but the effect ends at the start of your next turn, even if the enemy doesn't (action: Interact) to end it.",
                
                CriticalFailure = "Your tampering backfires dramatically, creating a small explosion from your own tools or gear. You take fire damage equal to your level.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bed9e32-3f96-46d1-8341-ffc685812e0c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
