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
    public class ForcefulShot : Template
    {
        public static readonly Guid ID = Guid.Parse("d942723e-d65c-417f-976b-2071e4e6f5d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forceful Shot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e76ffd39-c279-4835-abc1-b654d65f955c"), Type = TextBlockType.Text, Text = $"Your ranged attacks push your foes away from your allies. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, adding the following effects in addition to the normal effects of the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("64d4ab5e-e9fa-430b-9954-1bb31299c884"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("815f4f19-94cc-4f5d-9dab-3984a5cba4f1"),
                CriticalSuccess = "The target is pushed 10 feet away from you.",
                Success = "The target is pushed 5 feet away from you.",
                Failure = "The target is flat-footed for 1 round.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eec5e10f-3cb5-43c2-93a1-56b803acacc7"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
