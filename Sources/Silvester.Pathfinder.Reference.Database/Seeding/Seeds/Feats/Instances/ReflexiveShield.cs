using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflexiveShield : Template
    {
        public static readonly Guid ID = Guid.Parse("0ff12aa2-c90d-4677-90df-0f6d74b84eeb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflexive Shield",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4583151-0d89-4160-973c-73bac86e9a16"), Type = TextBlockType.Text, Text = "You can use your shield to fend off the worst of area effects and other damage. When you (action: Raise your Shield | Raise a Shield), you gain your shield’s circumstance bonus to Reflex saves. Additionally, damage you take as a result of a Reflex save can trigger the (feat: Shield Block) reaction, even if the damage isn’t physical damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("669367bb-2681-44a0-979b-1ce122eb9d81"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e93dbe39-056f-4487-8e98-27880035efad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
