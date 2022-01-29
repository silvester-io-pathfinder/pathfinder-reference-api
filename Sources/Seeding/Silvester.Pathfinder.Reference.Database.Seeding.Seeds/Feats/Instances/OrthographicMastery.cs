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
    public class OrthographicMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("1ce8b897-82c0-46ae-9a23-a3a349375951");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orthographic Mastery",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84e1e479-3766-43c1-9403-9c32cf8f5f01"), Type = TextBlockType.Text, Text = $"You understand the principles that underlie all written words, allowing you to read nearly any text. You can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} using Loremaster Lore in place of the required skill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c0853a49-f3f7-4552-8deb-b35353d0d2e8"), Feats.Instances.LoremasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("676c6ef7-caf7-491c-8bde-b618255b7d48"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
