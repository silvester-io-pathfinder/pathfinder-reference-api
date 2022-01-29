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
    public class NarrativeConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("cd41e47b-3c79-491e-af0a-82b8086b30a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Narrative Conduit",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3352a1f3-8c2a-4c3e-ae9e-06eba59244c9"), Type = TextBlockType.Text, Text = $"You act as a conduit for your companions just as your stories are a conduit between teller and listener. When you Spin a Tale and the hero of your tale {ToMarkdownLink<Models.Entities.Rule>("Casts a Spell", Rules.Instances.CastASpell.ID)} against the villain, you warp the world, allowing the hero to calculate range and cover to the villain from your space instead of their own if they prefer. The hero must choose to calculate both range and cover from the same space; they can't use one space for range and the other for cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f478697a-e652-4d5b-8036-fbaaa09707bd"), Feats.Instances.FolkloristDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Magical.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bed30804-a313-4c3e-ba93-998510959308"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
