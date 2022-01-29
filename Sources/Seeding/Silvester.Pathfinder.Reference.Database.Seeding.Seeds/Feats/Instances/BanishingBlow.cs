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
    public class BanishingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("cc86bde0-0041-4789-b274-9407985ce1c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Banishing Blow",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use your champion's reaction, triggered by a fiend within your reach.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6ccf362-9985-45bb-aa0e-36a73a4dca8a"), Type = TextBlockType.Text, Text = $"The erratic teleportation magic you experienced in the Kortos Mounts has taught you a few tricks. You attempt an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} the fiend that triggered your champion's reaction; on a success, the target can't teleport or summon creatures for 1 minute. On a critical success, the target is also stunned 1 and can't teleport or summon creatures for 1 hour, and if you are on your home plane and the target is a fiend of level 18 or lower from another plane, it is also banished to its home plane. Your multiple attack penalty doesn't apply to this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8a2540bb-2344-4015-9dd2-b4a1125f638e"), Feats.Instances.FiendsbaneOath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2cfaac18-7089-4a8d-9dc3-0b49971682cd"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73dc5ab5-3249-42c5-b27a-c7919e5e8a39"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
