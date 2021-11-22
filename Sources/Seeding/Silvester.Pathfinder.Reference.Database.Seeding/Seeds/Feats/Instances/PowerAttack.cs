using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("cd377185-9c55-4a5f-be5f-cecf4487a802");

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
            yield return new TextBlock { Id = Guid.Parse("f300ecd4-f752-4c86-8bc0-0b474bda30f0"), Type = TextBlockType.Text, Text = "You unleash a particularly powerful attack that clobbers your foe but leaves you a bit unsteady. Make a melee (action: Strike). This counts as two attacks when calculating your multiple attack penalty. If this (action: Strike) hits, you deal an extra die of weapon damage. If you're at least 10th level, increase this to two extra dice, and if you're at least 18th level, increase it to three extra dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d7c043e6-2fb9-46b1-9b0a-280163c3d3cf"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f0f458f-24e7-4fc4-82a4-0484f94ecfdd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
