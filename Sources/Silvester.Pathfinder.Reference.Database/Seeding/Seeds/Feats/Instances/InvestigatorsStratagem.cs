using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestigatorsStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("9e2d6247-2059-47da-822b-f096c0c6d999");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Investigator's Stratagem",
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
            yield return new TextBlock { Id = Guid.Parse("15d7b407-d0ef-47d0-8583-0273a8926473"), Type = TextBlockType.Text, Text = "You play out battles in your head, allowing you to strike when the time is right. You gain the (feat: Devise a Stratagem) action; however, when you substitute its result for your attack roll, you can’t use your Intelligence modifier in place of your Strength or Dexterity modifier. You also can’t use your Intelligence modifier on other rolls from abilities that expand (feat: Devise a Stratagem), such as the (feat: Athletic Strategist) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0e2cf104-3040-475b-9054-13fe93dfc5a4"), Feats.Instances.InvestigatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a696b336-a866-4b6c-a93f-e4d20c78fa76"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
