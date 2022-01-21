using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestigatorsStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("d31ea2d6-7a7f-40dd-a43f-5342ed588f4f");

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
            yield return new TextBlock { Id = Guid.Parse("716549f2-10d2-43ce-b92e-4d815f09369d"), Type = TextBlockType.Text, Text = "You play out battles in your head, allowing you to strike when the time is right. You gain the (feat: Devise a Stratagem) action; however, when you substitute its result for your attack roll, you can't use your Intelligence modifier in place of your Strength or Dexterity modifier. You also can't use your Intelligence modifier on other rolls from abilities that expand (feat: Devise a Stratagem), such as the (feat: Athletic Strategist) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b87567ef-42f9-43b3-9d35-01a93be15bc0"), Feats.Instances.InvestigatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37047b4e-1d87-41cc-8875-3949a2887659"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
