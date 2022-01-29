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
    public class GreaterMagicalEdification : Template
    {
        public static readonly Guid ID = Guid.Parse("fc1e1568-e594-44e8-ab29-82e28d8997d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Magical Edification",
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
            yield return new TextBlock { Id = Guid.Parse("d45209c7-bb37-4907-9291-70b467678ec2"), Type = TextBlockType.Text, Text = $"You've continued to expand your compendium of tools to compile knowledge. You can cast {ToMarkdownLink<Models.Entities.Spell>("comprehend language", Spells.Instances.ComprehendLanguage.ID)}, {ToMarkdownLink<Models.Entities.Spell>("mindlink", Spells.Instances.Mindlink.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("secret page", Spells.Instances.SecretPage.ID)} as innate occult spells, each once per day. When you cast {ToMarkdownLink<Models.Entities.Spell>("secret page", Spells.Instances.SecretPage.ID)}, it is automatically heightened to the same spell level as your cantrips from {ToMarkdownLink<Models.Entities.Feat>("Magical Edification", Feats.Instances.MagicalEdification.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ff7b27f-f1ae-41d5-98ba-b113b0162553"), Feats.Instances.MagicalEdification.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e63f00ac-9b8d-47c2-9797-e74c026f4f22"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
