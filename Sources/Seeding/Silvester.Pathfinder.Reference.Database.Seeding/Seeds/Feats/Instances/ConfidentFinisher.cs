using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConfidentFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("d2c4f4d4-c6bb-47bb-a572-11e19d14cb29");

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
            yield return new TextBlock { Id = Guid.Parse("7150d28e-4188-4142-8cc3-a36b4e2b8bdd"), Type = TextBlockType.Text, Text = "You make an incredibly graceful attack, piercing your foe's defenses. Make a (action: Strike) with a weapon or unarmed attack that would apply your precise strike damage, with the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("98e3789e-6aa4-4586-804c-c9d79e50c298"),
                
                
                Failure = "You deal half your precise strike damage to the target. This damage type is that of the weapon or unarmed attack you used for the (action: Strike).",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dca1386e-05c1-4316-beb3-523fd2fd7208"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
