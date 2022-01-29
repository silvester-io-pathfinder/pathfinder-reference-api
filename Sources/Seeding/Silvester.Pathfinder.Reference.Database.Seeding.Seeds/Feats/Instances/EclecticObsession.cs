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
    public class EclecticObsession : Template
    {
        public static readonly Guid ID = Guid.Parse("470f4d2b-0377-4848-978f-b494502834cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Obsession",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62082003-6e62-4ddf-be49-49968fd66951"), Type = TextBlockType.Text, Text = $"Your desire for stimulation has led you from one pursuit to another and granted you a smattering of expertise with myriad crafts and professions." };
            yield return new TextBlock { Id = Guid.Parse("6b072f79-d98e-4071-8aed-d6fc64948879"), Type = TextBlockType.Text, Text = $"You reflect on snippets you've learned to temporarily become trained in one Lore skill of your choice. This proficiency lasts for 10 minutes or until you critically fail a check with that skill. Since this training is temporary, you can't use it as a prerequisite for a permanent character option like a feat or a skill increase." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b2f275e6-6d6f-441f-8597-24d1fa1aa8ea"), Feats.Instances.GnomeObsession.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ed03ddf-cc49-4e94-a552-e8578dd6a35e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
