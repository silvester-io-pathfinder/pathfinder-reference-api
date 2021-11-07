using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipIntoShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("ced91860-0347-459c-905e-fbd2260129a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slip Into Shadow",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0eb5f22-89ef-4f16-8345-d6984f24836c"), Type = TextBlockType.Text, Text = "Your shadow magic bleeds into the space around you. Whenever you cast a spell with the (trait: darkness) trait, a lingering aura of shadows reduces bright light within a 5-foot emanation around you to dim light until the end of your turn. Like in natural dim light, you can use these shadows to (action: Hide), but the aura still makes your overall position obvious, so you can’t become undetected through the use of these shadows alone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnySpellSpecificTrait(Guid.Parse("78886a80-9ba7-4407-ba4a-03e19754f240"), Traits.Instances.Darkness.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75ed8fd4-dd38-4c8e-bd7c-f3ef48fc5f52"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
