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
    public class DeftCooperation : Template
    {
        public static readonly Guid ID = Guid.Parse("d68e209d-867b-4d77-84d7-311efc3ec7f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deft Cooperation",
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
            yield return new TextBlock { Id = Guid.Parse("00acf1b1-ba41-4e44-a52c-b746b6b973c3"), Type = TextBlockType.Text, Text = $"When you set things up to help your allies, you also gain some of the fruits of your labors. When you successfully {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} an attack roll or AC, you gain a +1 circumstance bonus to attack rolls or AC against that enemy until the end of your next turn, whichever you granted to your ally. When you successfully {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} a skill check, if you attempt the exact same skill check (not just using the same skill, but using it for the same purpose, for instance a check to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)} the same wall) on your next turn, you gain a +1 circumstance bonus to your skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f4c4844-47e8-4982-b183-7ff7560383b6"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("490d6f01-94d0-4c35-9c73-88f0028e05fd"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
