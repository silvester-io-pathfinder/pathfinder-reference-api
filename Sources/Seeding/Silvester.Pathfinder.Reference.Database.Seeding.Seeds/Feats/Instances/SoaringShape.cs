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
    public class SoaringShape : Template
    {
        public static readonly Guid ID = Guid.Parse("56aff1a9-8fee-4a3b-93e3-9dc158f047f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Shape",
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
            yield return new TextBlock { Id = Guid.Parse("d2bd8a0f-7b17-4f0a-8a1a-3a3606b6546c"), Type = TextBlockType.Text, Text = $"Wings free you from the shackles of the ground below. Add the bat and bird forms in {ToMarkdownLink<Models.Entities.Spell>("aerial form", Spells.Instances.AerialForm.ID)} to your wild shape list. If you have {ToMarkdownLink<Models.Entities.Feat>("Insect Shape", Feats.Instances.InsectShape.ID)}, you also add the wasp form to your wild shape list. If you have {ToMarkdownLink<Models.Entities.Feat>("Ferocious Shape", Feats.Instances.FerociousShape.ID)}, you also add the pterosaur form to your wild shape list. Whenever you use {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} to gain a form that grants you a specific Acrobatics modifier, you gain a +1 status bonus to Acrobatics checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69f670df-15a6-4d5d-b02b-567aa8c65d21"), Feats.Instances.WildShape.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a96666e0-5342-4c50-bdf7-9114f5c3fbdf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
