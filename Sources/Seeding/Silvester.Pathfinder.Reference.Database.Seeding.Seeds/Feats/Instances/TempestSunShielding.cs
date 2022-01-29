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
    public class TempestSunShielding : Template
    {
        public static readonly Guid ID = Guid.Parse("954c5882-5ca3-430d-86e6-b04d737de111");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tempest-Sun Shielding",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or an ally within 30 feet takes damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1b16195-0093-4d01-a891-96582e9d2eeb"), Type = TextBlockType.Text, Text = $"You transform unrealized spell energy into a protective shield. If you're a spontaneous spellcaster, expend a spell slot; if you're a prepared spellcaster, expend a spell prepared in a spell slot. Reduce the triggering damage by an amount equal to four times the level of the expended slot or spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("36aa0c72-cc00-4044-a058-2c966998994e"), Feats.Instances.TempestSunRedirection.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4522a422-74c1-461f-b7d7-85ae5d1e1892"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
