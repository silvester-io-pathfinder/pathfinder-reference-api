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
    public class GravesVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("56c194ca-0274-4c4f-9b5f-b431f5c14b0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grave's Voice",
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
            yield return new TextBlock { Id = Guid.Parse("c00ab2ea-8acb-45d0-9b93-c1b01c46f70e"), Type = TextBlockType.Text, Text = $"You can use your choice of Spirit Lore or Haunt Lore to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} things of incorporeal creatures. At the GM's discretion, an incorporeal spirit might be willing to hear you out." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f06da2bf-49d5-419d-95ee-f3d7b41d2dd9"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7898edc-22ef-4cd6-84cc-d5581910e256"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
