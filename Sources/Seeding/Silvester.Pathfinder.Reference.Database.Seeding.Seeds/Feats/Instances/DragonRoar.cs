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
    public class DragonRoar : Template
    {
        public static readonly Guid ID = Guid.Parse("a22574ec-d138-4f0c-9c8a-be033d6ff907");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Roar",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1dbef62-60d0-40ce-950b-547a24f9ea39"), Type = TextBlockType.Text, Text = $"You bellow, instilling fear in your enemies. Enemies within a 15-foot emanation must succeed at a Will save against your Intimidation DC or be frightened 1 (frightened 2 on a critical failure). When a creature frightened by the roar begins its turn adjacent to you, it can't reduce its frightened value below 1 on that turn. Your first attack that hits a frightened creature after you roar and before the end of your next turn gains a +4 circumstance bonus to damage." };
            yield return new TextBlock { Id = Guid.Parse("5df1041b-2d71-49bb-90e2-cfdda2f71d1b"), Type = TextBlockType.Text, Text = $"After you use Dragon Roar, you can't use it again for 1d4 rounds. Its effects end immediately if you leave {ToMarkdownLink<Models.Entities.Feat>("Dragon Stance", Feats.Instances.DragonStance.ID)}. Creatures in the area of your roar are then temporarily immune for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("551ad178-1c6e-4489-829c-21cf4a378c11"), Feats.Instances.DragonStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6d19ce2a-d08e-47cf-88ab-86c30fbaad58"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("c56a9269-7736-4cd0-acc5-94c2f8a0ca79"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("20285947-9d7f-43a0-8ebf-e8d41f1afa82"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("29a9c4d5-d9a7-42a5-b469-cce34858a338"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("0686ddd6-f221-4831-9cb2-a3df4614c5e7"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d8ccd2e-8a90-4b52-961f-543e1a91c24e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
