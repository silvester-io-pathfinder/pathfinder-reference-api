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
    public class GnomePolyglot : Template
    {
        public static readonly Guid ID = Guid.Parse("011bc359-7e97-467b-833f-a47405efc893");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Polyglot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea16f8a5-5870-4fdc-b452-44a5ccea9593"), Type = TextBlockType.Text, Text = $"Your extensive travels, curiosity, and love of learning help you to learn languages quickly. You learn three new languages, chosen from common languages and uncommon languages you have access to. These languages take the same form (signed or spoken) as your other languages. When you select the {ToMarkdownLink<Models.Entities.Feat>("Multilingual", Feats.Instances.Multilingual.ID)} feat, you learn three new languages instead of two." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("af620b8f-7ad1-46d6-b24a-c555575e5f09"), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa26144b-d937-4cbf-bdba-d5e681616a78"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
