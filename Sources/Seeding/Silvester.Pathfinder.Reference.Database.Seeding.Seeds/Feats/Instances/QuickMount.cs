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
    public class QuickMount : Template
    {
        public static readonly Guid ID = Guid.Parse("de96ba80-1670-4715-89d8-1a59aa805b0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Mount",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27c346a9-7939-4cd7-af67-dd26e335813d"), Type = TextBlockType.Text, Text = $"You and your mount can spring into action at a moment's notice. You {ToMarkdownLink<Models.Entities.Action>("Mount", Actions.Instances.Mount.ID)} / {ToMarkdownLink<Models.Entities.Action>("Dismount", Actions.Instances.Mount.ID)} the creature and {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} to issue it an order of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ffc28cc-629e-495d-b825-300b2f9b1736"), Feats.Instances.CavalierDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("79a55d98-e49c-40dc-abf9-f8e178133dbd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1f8482f6-5dea-48a1-aa79-e24b0a1e67f2"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("3d457eaa-da04-444d-a76e-1320f63f9a43"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b96ddf10-cbe8-4b53-8627-e16fc7a65783"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
