using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertHerbalism : Template
    {
        public static readonly Guid ID = Guid.Parse("c8135bdd-41ce-488d-895e-0b3e3262dc8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Herbalism",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c152101c-3127-4942-a7a7-884c6042450d"), Type = TextBlockType.Text, Text = "Your advanced alchemy level for herbalism increases to your level – 3. You gain the formulas for elixirs of life as soon as your advanced alchemy level is high enough to create them: lesser at 8th level, moderate at 12th level, greater at 16th level, and major at 18th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2796a76e-f405-4649-8eaa-99eb28fdb646"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("795a8744-4942-4622-bcff-6beeb0bfbd27"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a4832ea-9e93-4d24-8a11-107e00343333"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
