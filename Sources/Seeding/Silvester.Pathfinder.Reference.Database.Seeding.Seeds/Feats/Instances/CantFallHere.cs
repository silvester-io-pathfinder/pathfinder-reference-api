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
    public class CantFallHere : Template
    {
        public static readonly Guid ID = Guid.Parse("203b945b-f9a4-4d82-aefd-f50b8c266f4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Can't Fall Here",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent and willing ally would be reduced to 0 HP but not killed.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f3f5f4e-6e82-4b54-87f2-3cabc5e290a8"), Type = TextBlockType.Text, Text = $"You physically help an ally remain standing and encourage them to push through their pain against dire odds. Your ally doesn't fall unconscious and remains at 1 Hit Point. The ally also gains a number of temporary Hit Points equal to your level that last for 1 minute. Fighting onward with such an injury isn't without consequence; your ally's wounded condition increases by 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("98a33e1b-4f0f-442b-a09c-77fab6c430dd"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("3975f2e3-25e5-4753-aa55-dd8920f9625d"), Traits.Instances.Hobgoblin.ID);
            builder.Add(Guid.Parse("bef5c2c8-ef04-49bf-b4a8-505e51e13205"), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa4089b1-bb4f-4312-a301-979f6ea30b37"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
