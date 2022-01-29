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
    public class BloodyDebilitation : Template
    {
        public static readonly Guid ID = Guid.Parse("b5e3b3aa-9e73-4b1d-8ab9-57157131db30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloody Debilitation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9836e75e-cb95-4037-82d9-b16b0b88c244"), Type = TextBlockType.Text, Text = $"Your attacks slice arteries and veins. Add the following debilitation to the list you can choose from when you use {ToMarkdownLink<Models.Entities.Feat>("Debilitating Strike", Feats.Instances.DebilitatingStrike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("d49be051-0cf7-4378-856f-d015739c874e"), Type = TextBlockType.Enumeration, Text = $" Debilitation: The target takes 3d6 persistent bleed damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7dba4b04-cf83-4c1b-bc34-345f7f74ab9d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("21aa3304-0c80-445a-ba5f-e527d74ff7d0"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c063dd3-0691-434e-b6e4-80f22a6055e4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
