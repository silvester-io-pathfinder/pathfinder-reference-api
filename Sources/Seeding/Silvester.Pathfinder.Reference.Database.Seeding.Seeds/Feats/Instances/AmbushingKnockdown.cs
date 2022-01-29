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
    public class AmbushingKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("67f1ced0-1024-449b-a29e-d4de6edb7955");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ambushing Knockdown",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("032201c2-3644-4d86-9f46-39d1511b0297"), Type = TextBlockType.Text, Text = $"~ Access: Side with the Washboard Dogs in the gang conflict." };
            yield return new TextBlock { Id = Guid.Parse("eb4ec717-b2df-44a7-af3e-b8e842bfce99"), Type = TextBlockType.Text, Text = $"You emerge from hiding and deliver a blow that can knock an enemy sprawling to the ground. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to half your Speed, but you must end your movement next to a foe you're hidden from or undetected by. You then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that enemy with the required weapon; if you hit, the target is knocked prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("b8b9ef96-460e-453e-8adb-00c54668ada9"), Rackets.Instances.Ruffian.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("be1c6ab8-6950-461e-84ac-f1144744d038"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("613b6c6d-ee7d-4164-be6f-227464b22a5b"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
