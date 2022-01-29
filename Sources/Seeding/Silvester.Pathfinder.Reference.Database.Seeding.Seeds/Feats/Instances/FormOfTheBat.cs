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
    public class FormOfTheBat : Template
    {
        public static readonly Guid ID = Guid.Parse("5dda6e38-af04-4a05-a48c-f11275791ee2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Bat",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce936a37-7b71-4ea7-adfb-22cb07b6cb9a"), Type = TextBlockType.Text, Text = $"You can transform into a harmless bat. You gain the effects of a 4th-level {ToMarkdownLink<Models.Entities.Spell>("pest form", Spells.Instances.PestForm.ID)}, except you always transform into a bat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("55d9cecf-725b-4c7e-8d22-0b1ba7f11b26"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("bbdbbfa1-7006-40d8-bef2-2eb2ab944c6f"), Traits.Instances.Dhampir.ID);
            builder.Add(Guid.Parse("0ee2fe1d-3389-498c-aaf3-2b662276a40a"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("72399e6e-e4b5-4117-8405-4ea90bbdd7ed"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("c385af0f-603d-410f-8db4-b5cf41334161"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11859cc7-3f7c-4ade-b3e2-59512ae8b401"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
