using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToolsOfTheTrade : Template
    {
        public static readonly Guid ID = Guid.Parse("b107c6d7-6b60-4392-aebc-20714227b5a4");

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
            yield return new TextBlock { Id = Guid.Parse("8e2ec9ce-e885-417f-bea2-481967732e6d"), Type = TextBlockType.Text, Text = "You’re well-versed in weapons that allow you to bring bounties in alive. You are trained with the following weapons: (item: bola), (item: sap), and (item: whip). You gain access to bolas. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the weapons listed." };
            yield return new TextBlock { Id = Guid.Parse("d953d1f9-d2d5-4ab4-904c-14daf7e40e18"), Type = TextBlockType.Text, Text = "In addition, you take no penalty when making a nonlethal attack with a weapon without the (trait: nonlethal) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("10bc10a0-b5fb-4951-8a6b-27c37dc30d1c"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("057c39dc-deb2-45bc-80e3-615f84053984"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
