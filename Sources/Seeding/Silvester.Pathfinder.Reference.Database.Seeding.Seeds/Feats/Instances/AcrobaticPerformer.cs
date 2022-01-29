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
    public class AcrobaticPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("41cc70ac-0751-4cda-9484-e1da77bb8ffe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acrobatic Performer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("242343f4-b57a-45fc-9b58-a35a46efc7c7"), Type = TextBlockType.Text, Text = $"You're an incredible acrobat, evoking wonder and enrapturing audiences with your prowess. It's almost a performance! You can roll an Acrobatics check instead of a Performance check when using the {ToMarkdownLink<Models.Entities.SkillAction>("Perform", SkillActions.Instances.Perform.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e21dee4c-a193-4ecb-b170-7739839657ca"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7428d904-39ae-4856-bc83-b6acf78f0f6d"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("0311263b-5207-446f-a383-c751b9a7824a"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35512597-1f7c-4050-a9a4-359c4574004f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
