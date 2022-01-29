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
    public class ElementalShape : Template
    {
        public static readonly Guid ID = Guid.Parse("c7631162-9b48-421a-80a5-3283eecba7f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Shape",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf4f5d5e-98aa-4208-abe9-4476a9df3669"), Type = TextBlockType.Text, Text = $"You understand the fundamental elements of nature such that you can imbue them into your body and manifest as a living embodiment of those elements. Add the forms in {ToMarkdownLink<Models.Entities.Spell>("elemental form", Spells.Instances.ElementalForm.ID)} to your wild shape list. Whenever you're polymorphed into another form using {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)}, you gain resistance 5 to fire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("51d94072-5186-4d89-bcb4-ad653c9099f5"), Feats.Instances.WildShape.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb4d4e19-e044-46fe-8526-1c71556bc277"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
