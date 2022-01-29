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
    public class FamiliarsEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("50c20462-46a9-48e4-b639-4a8a1e556b8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar's Eyes",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4186bc5c-7327-48aa-9725-1865a59a4059"), Type = TextBlockType.Text, Text = $"You use your familiar's senses as easily as your own. You project your senses into your familiar. When you do, you lose all sensory information from your own body, but you can sense through your familiar's body until you {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the effect. While projecting your senses in this way, you can converse telepathically with your familiar if it understands a language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("839bd04c-8510-4886-acd8-a3547d42477d"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fae40c37-14b6-4ec6-9fbe-25931a93dd67"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("9ea44c5a-2bc5-4572-9982-cda091a99678"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("361fb483-9189-4e4b-b237-932a1cc2723f"), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5d864f8-bc60-427d-a464-11a731f9f4c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
