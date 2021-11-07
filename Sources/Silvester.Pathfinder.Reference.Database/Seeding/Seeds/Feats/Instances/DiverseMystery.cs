using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiverseMystery : Template
    {
        public static readonly Guid ID = Guid.Parse("10ca5909-f8c3-42aa-9a11-14d56b92d0a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverse Mystery",
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
            yield return new TextBlock { Id = Guid.Parse("a4c1e332-b686-48c5-9baa-6a8d5e60aa56"), Type = TextBlockType.Text, Text = "You have broadened your understanding of the divine and can tap into the wonders of a different mystery. Select one revelation spell from a mystery other than your own. You can choose only an initial revelation spell or an advanced revelation spell." };
            yield return new TextBlock { Id = Guid.Parse("5bbb6f9f-ca82-4813-81f1-fa0ab75d6dca"), Type = TextBlockType.Text, Text = "When you cast this revelation spell, you gain the effects of the minor curse from that mystery in addition to the normal curse effects you gain from casting a revelation spell. This additional minor curse effect remains until your next daily preparations. Any ability that lets you cast a revelation spell without increasing the severity of your curse also prevents you from gaining this additional curse effect." };
            yield return new TextBlock { Id = Guid.Parse("2654776a-3599-4a72-b469-cefaabf3ce6e"), Type = TextBlockType.Text, Text = "You can’t cast your chosen revelation spell if any of the following conditions are true: its mystery’s curse effects directly conflict with or negate the effects of your own mystery’s curse, the curse would have no effect on you (for example, removing an ability from your original mystery that you lack), or either of these criteria would be met once you finish (activity: Casting the Spell | Cast a Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd0780f5-4a0c-4a76-b34b-b4530b76b050"), Feats.Instances.AdvancedRevelation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5fc5a79-2767-45bc-b858-5bd9391e4463"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
