using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterInterpose : Template
    {
        public static readonly Guid ID = Guid.Parse("c7806a52-216f-4d16-a7b2-a2ceedf325ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Interpose",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37070708-453a-42f9-88ef-6a3f78149079"), Type = TextBlockType.Text, Text = "You&#39;re able to avoid hits that others could not. You can use (feat: Sacrifice Armor) to reduce any type of damage from an attack or effect requiring a Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("c60d5046-4944-429d-b3b2-61bf7ccd7ada"), Type = TextBlockType.Text, Text = "When you use (feat: Sacrifice Armor) against a critical hit or a critical failure on a Reflex save that would otherwise cause you to take double damage, you take the normal amount of damage instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f590dc17-5139-4654-a7bb-7c7bd1018057"), Feats.Instances.SacrificeArmor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e677689-ae9f-4bc5-9e36-7c4e3412b545"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
