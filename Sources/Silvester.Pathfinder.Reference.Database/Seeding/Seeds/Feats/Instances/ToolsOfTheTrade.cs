using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToolsOfTheTrade : Template
    {
        public static readonly Guid ID = Guid.Parse("ce8b52bc-610a-44f5-abb6-d6fa387f33f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tools of the Trade",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("558a551b-7eef-438c-878b-8973d6c79063"), Type = TextBlockType.Text, Text = "You’re well-versed in weapons that allow you to bring bounties in alive. You are trained with the following weapons: (item: bola), (item: sap), and (item: whip). You gain access to bolas. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the weapons listed." };
            yield return new TextBlock { Id = Guid.Parse("ef46c5a1-5263-4134-b77f-307ff1dfdb73"), Type = TextBlockType.Text, Text = "In addition, you take no penalty when making a nonlethal attack with a weapon without the (trait: nonlethal) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("893ea0ca-3f46-4748-a74a-4ec2428a67cb"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("223bd9e0-1209-4f37-be75-4b30a355dd7a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
