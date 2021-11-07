using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitualResearcher : Template
    {
        public static readonly Guid ID = Guid.Parse("42b999c8-f55c-4d36-bf3b-de91f1162517");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ritual Researcher",
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
            yield return new TextBlock { Id = Guid.Parse("8b600591-0d08-4035-8beb-5d6f60f04f67"), Type = TextBlockType.Text, Text = "Careful research into the art of rituals has made you better at performing them. You gain a +2 circumstance bonus to all primary and secondary checks you attempt as part of casting a ritual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("c8598222-98e1-4057-a612-d5c4f8287fda"), Muses.Instances.Enigma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("81978d0a-fe32-451b-b8ea-d3306b609fc7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9791cb47-2355-47b8-8770-b9cbff780a80"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
