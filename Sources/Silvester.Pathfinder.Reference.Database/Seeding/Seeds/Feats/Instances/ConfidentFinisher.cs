using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConfidentFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("8db2fdf0-22b1-46c2-93d2-2bac3e468541");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Confident Finisher",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("caac3c69-d5bf-4c0e-b77e-0838ed5e0cb7"), Type = TextBlockType.Text, Text = "You make an incredibly graceful attack, piercing your foe’s defenses. Make a (action: Strike) with a weapon or unarmed attack that would apply your precise strike damage, with the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f630f82a-d880-4aa7-b86e-bfd23a06faef"),
                
                
                Failure = "You deal half your precise strike damage to the target. This damage type is that of the weapon or unarmed attack you used for the (action: Strike).",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fac016fd-b0f3-4728-b7d9-90a666640b45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
