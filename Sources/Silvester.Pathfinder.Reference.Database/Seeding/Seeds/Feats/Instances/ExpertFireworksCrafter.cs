using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertFireworksCrafter : Template
    {
        public static readonly Guid ID = Guid.Parse("9a5fdffd-ab7f-4d40-9f60-d8215d24f47b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Fireworks Crafter",
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
            yield return new TextBlock { Id = Guid.Parse("4195d16f-956c-42e7-b211-433f8b568a3c"), Type = TextBlockType.Text, Text = "You’re particularly adept at crafting fireworks, allowing you to create much more powerful fireworks than you otherwise could. Your advanced alchemy level for fireworks increases to your level – 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("17396db6-996a-4658-873b-099300ff3361"), Feats.Instances.FireworkTechnicianDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ad5f4059-4283-418c-946a-1aa47dec820a"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("151b4643-7332-4e21-ab1f-c7971141f80b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
