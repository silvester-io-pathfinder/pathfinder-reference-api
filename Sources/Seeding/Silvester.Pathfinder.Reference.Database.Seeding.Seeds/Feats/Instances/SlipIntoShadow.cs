using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipIntoShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("0cc80706-dea1-46a6-9082-e77bc76c8d28");

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
            yield return new TextBlock { Id = Guid.Parse("8cd934de-8c36-4f2d-8b03-fba5dd68f0a8"), Type = TextBlockType.Text, Text = $"Your shadow magic bleeds into the space around you. Whenever you cast a spell with the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)} trait, a lingering aura of shadows reduces bright light within a 5-foot emanation around you to dim light until the end of your turn. Like in natural dim light, you can use these shadows to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)}, but the aura still makes your overall position obvious, so you can't become undetected through the use of these shadows alone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnySpellSpecificTrait(Guid.Parse("c3aaa0e7-2055-400c-a197-1ca84d693b10"), Traits.Instances.Darkness.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dhampir.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85577a7d-7939-493f-89b8-499422e555e8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
