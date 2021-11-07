using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("8cf91a73-b1e6-42d2-aa84-2fe2f265d94f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Power Attack",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90488a45-6f0a-4b4a-955b-1aa66613eba1"), Type = TextBlockType.Text, Text = "You unleash a particularly powerful attack that clobbers your foe but leaves you a bit unsteady. Make a melee (action: Strike). This counts as two attacks when calculating your multiple attack penalty. If this (action: Strike) hits, you deal an extra die of weapon damage. If you’re at least 10th level, increase this to two extra dice, and if you’re at least 18th level, increase it to three extra dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90af324c-865c-495d-a56f-db0d6954e250"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bdaf8fe-0526-4e8e-b81d-a599d9e5c428"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
